using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Data.Linq;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Matura
{
    public partial class Main : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            CheckIfUserExists();
        }

        private void CheckIfUserExists()
        {
            using (var ctx = new MaturaDataContext())
            {
                string userIp = GetIpAddress();
                string[] splitIp = userIp.Split(':');
                if (splitIp.Any())
                {
                    userIp = splitIp[0];
                }
                if (!(from i in ctx.UserDatas where i.IpAddress == userIp select i).Any())
                {
                    ctx.UserDatas.InsertOnSubmit(new UserData
                    {
                        CanPost = true,
                        IpAddress = userIp,
                        LastPosted = DateTime.Now
                    });
                    ctx.SubmitChanges();
                }
            }
        }

        public void Subject_Selected(object sender, CommandEventArgs e)
        {
            string subjectName = e.CommandArgument.ToString();
            Session["currentSubject"] = subjectName;
            int i = subjectName.LastIndexOf('c');
            if (i >= 0)
            {
                tableHeader.Text = subjectName.Substring(0, i) + "č" + subjectName.Substring(i + 1);
            }
            else
            {
                tableHeader.Text = subjectName;
            }
                
            IEnumerable<v_Question> fetched = FetchSubjectQuestions(subjectName);
            InsertCollectionIntoTable(fetched);
        }

        private void InsertCollectionIntoTable(IEnumerable<v_Question> items)
        {
            const string rowFormat = "<tr><td><b>{0}</b></td><td>{1}</td><td>{2}</td><td>{3}</td></tr>";
            const string newRowFormat = @"<tr><td class=""success""><b>{0}</b></td><td>{1}</td><td>{2}</td><td>{3}</td></tr>";
            var rowStrings =
                items.Select(
                    row =>
                        (DateTime.Now - row.PostedOn).TotalMinutes <= 15
                            ? string.Format(newRowFormat, row.QuestionNumber, row.Question1, row.Question2,
                                row.Question3)
                            : string.Format(rowFormat, row.QuestionNumber, row.Question1, row.Question2, row.Question3))
                    .ToArray();
            string html = string.Join(Environment.NewLine, rowStrings);
            columnData.Text = html;
        }

        private IEnumerable<v_Question> FetchSubjectQuestions(string subjectName)
        {
            using (var ctx = new MaturaDataContext())
            {
                ctx.DeferredLoadingEnabled = false;
                var query = from i in ctx.v_Questions
                    where i.SubjectName == subjectName
                    where !i.IsSpam
                    orderby i.PostedOn descending
                    select i;
                return query.ToList();
            }
        }

        protected void SubmitPost(object sender, EventArgs e)
        {
            int qNumber = -1;
            string q1 = inputQ1.Text;
            string q2 = inputQ2.Text;
            string q3 = inputQ3.Text;

            if (!string.IsNullOrEmpty(inputNumber.Text))
            {
                if (!int.TryParse(inputNumber.Text, out qNumber) || qNumber < -1 || qNumber > 35 || qNumber == 0)
                {
                    inputNumber.BackColor = Color.PaleVioletRed;
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                    return;
                }
            }
            inputNumber.BackColor = Color.White;

            if (ValidatePost(q1, q2, q3))
            {
                InsertPostToDb(qNumber, q1, q2, q3, inputSubject.SelectedValue);
                ClearModal();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            }
        }

        private void InsertPostToDb(int qNumber, string q1, string q2, string q3, string selectedSubject)
        {
            using (var ctx = new MaturaDataContext())
            {
                string userIp = GetIpAddress();
                string[] splitIp = userIp.Split(':');
                if (splitIp.Any())
                {
                    userIp = splitIp[0];
                }
                List<UserData> query = (from i in ctx.UserDatas where i.IpAddress == userIp select i).ToList();
                if (query.Any())
                {
                    InsertQuestion(qNumber, q1, q2, q3, selectedSubject, query, ctx);
                }
                else
                {
                    CheckIfUserExists();
                    query = (from i in ctx.UserDatas where i.IpAddress == userIp select i).ToList();
                    if (query.Any())
                    {
                        InsertQuestion(qNumber, q1, q2, q3, selectedSubject, query, ctx);
                    }
                }
            }
        }

        private void InsertQuestion(int qNumber, string q1, string q2, string q3, string selectedSubject, List<UserData> query,
            MaturaDataContext ctx)
        {
            UserData user = query.FirstOrDefault();
            int qCount = user.Questions.Count();
            if (!user.CanPost || qCount >= 10)
            {
                ctx.MarkSpamUser(user.Id);
                this.Show("Objavili ste veliko vprašanj v kratkem času in vas je sistem označil kot zlonamernega uporabnika. Objave so vam onemogočene, dokler" +
                    " se ročno ne preveri vašega stanja. V primeru nepravičnega postopka je naš kontakt objavljen na dnu spletne strani.");
            }
            double lastCount = (DateTime.Now - user.LastPosted).TotalMinutes;
            if (user.CanPost && (qCount <= 3 || lastCount > qCount))
            {
                ctx.UpdateUser(user.Id, DateTime.Now);
                ctx.Questions.InsertOnSubmit(new Question
                {
                    IsSpam = false,
                    PostedOn = DateTime.Now,
                    Question1 = q1,
                    Question2 = q2,
                    Question3 = q3,
                    QuestionNumber = qNumber,
                    SubjectId = GetSubjectIdByName(selectedSubject),
                    UserId = user.Id
                });
                ctx.SubmitChanges();
                ctx.DeleteDuplicateQuestions();
            }
            else
            {
                if (lastCount >= 1)
                {
                    this.Show("Objavil si preveč vprašanj v kratkem času, zato moraš počakati še "
                              + Math.Round(lastCount) +
                              " minut, preden lahko ponovno objaviš vprašanje. V primeru zlorabe ti bo onemogočen dostop.");
                }
                else
                {
                    this.Show("Objavil si preveč vprašanj v kratkem času, zato moraš počakati še "
                          + Math.Round(lastCount*60) + " sekund, preden lahko ponovno objaviš vprašanje. V primeru zlorabe ti bo onemogočen dostop.");
                }
                
            }
        }

        private int GetSubjectIdByName(string subjectName)
        {
            using (var ctx = new MaturaDataContext())
            {
                return (from i in ctx.Subjects where i.SubjectName == subjectName select i.Id).FirstOrDefault();
            }
        }

        private bool ValidatePost(string q1, string q2, string q3)
        {
            if (string.IsNullOrEmpty(q1) && string.IsNullOrEmpty(q2) && string.IsNullOrEmpty(q3))
            {
                inputQ1.BackColor = Color.PaleVioletRed;
                inputQ2.BackColor = Color.PaleVioletRed;
                inputQ3.BackColor = Color.PaleVioletRed;
                return false;
            }

            inputQ1.BackColor = Color.White;
            inputQ2.BackColor = Color.White;
            inputQ3.BackColor = Color.White;

            if (MaxLengthCheck(q1, q2, q3))
            {
                this.Show("V označenem polju ste presegli limit 1000 črk.");
                return false;
            }

            if (inputSubject.SelectedValue == "0")
            {
                inputSubject.BackColor = Color.PaleVioletRed;
                return false;
            }
            inputSubject.BackColor = Color.White;
            return true;
        }

        private bool MaxLengthCheck(string q1, string q2, string q3)
        {
            if (q1 != null && q1.Length > 1000)
            {
                inputQ1.BackColor = Color.PaleVioletRed;
                return true;
            }
            inputQ1.BackColor = Color.White;

            if (q2 != null && q2.Length > 1000)
            {
                inputQ2.BackColor = Color.PaleVioletRed;
                return true;
            }
            inputQ2.BackColor = Color.White;

            if (q3 != null && q3.Length > 1000)
            {
                inputQ3.BackColor = Color.PaleVioletRed;
                return true;
            }
            inputQ3.BackColor = Color.White;

            return false;
        }

        private void ClearModal()
        {
            inputNumber.Text = string.Empty;
            inputQ1.Text = string.Empty;
            inputQ2.Text = string.Empty;
            inputQ3.Text = string.Empty;
            inputSubject.SelectedIndex = 0;

            inputNumber.BackColor = Color.White;
            inputQ1.BackColor = Color.White;
            inputQ2.BackColor = Color.White;
            inputQ3.BackColor = Color.White;
            inputSubject.BackColor = Color.White;

        }

        protected void CloseModal(object sender, EventArgs e)
        {
            ClearModal();
        }

        protected string GetIpAddress()
        {
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipAddress))
            {
                string[] addresses = ipAddress.Split(',');
                if (addresses.Length != 0)
                {
                    return addresses[0];
                }
            }

            return context.Request.ServerVariables["REMOTE_ADDR"];
        }

        protected void OrderByAscending(object sender, EventArgs e)
        {
            if (Session["currentSubject"] != null)
            {
                IEnumerable<v_Question> fetched = FetchSubjectQuestions(Session["currentSubject"].ToString()).OrderBy(x => x.QuestionNumber);
                InsertCollectionIntoTable(fetched);
            }
        }

        protected void OrderByDescending(object sender, EventArgs e)
        {
            if (Session["currentSubject"] != null)
            {
                IEnumerable<v_Question> fetched = FetchSubjectQuestions(Session["currentSubject"].ToString()).OrderByDescending(x => x.QuestionNumber);

                InsertCollectionIntoTable(fetched);
            }
        }

    }

    
}

public static class MessageBox
{
    public static void Show(this Page Page, String Message)
    {
        Page.ClientScript.RegisterStartupScript(
           Page.GetType(),
           "MessageBox",
           "<script language='javascript'>alert('" + Message + "');</script>"
        );
    }
}