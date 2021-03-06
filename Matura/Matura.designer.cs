﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Matura
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MaturaDB")]
	public partial class MaturaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertQuestion(Question instance);
    partial void UpdateQuestion(Question instance);
    partial void DeleteQuestion(Question instance);
    partial void InsertSubject(Subject instance);
    partial void UpdateSubject(Subject instance);
    partial void DeleteSubject(Subject instance);
    partial void InsertUserData(UserData instance);
    partial void UpdateUserData(UserData instance);
    partial void DeleteUserData(UserData instance);
    #endregion
		
		public MaturaDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MaturaDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MaturaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MaturaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MaturaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MaturaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Question> Questions
		{
			get
			{
				return this.GetTable<Question>();
			}
		}
		
		public System.Data.Linq.Table<Subject> Subjects
		{
			get
			{
				return this.GetTable<Subject>();
			}
		}
		
		public System.Data.Linq.Table<UserData> UserDatas
		{
			get
			{
				return this.GetTable<UserData>();
			}
		}
		
		public System.Data.Linq.Table<v_Question> v_Questions
		{
			get
			{
				return this.GetTable<v_Question>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateUser")]
		public int UpdateUser([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserId", DbType="Int")] System.Nullable<int> userId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PostDate", DbType="DateTime")] System.Nullable<System.DateTime> postDate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userId, postDate);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.MarkSpamUser")]
		public int MarkSpamUser([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserId", DbType="Int")] System.Nullable<int> userId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteDuplicateQuestions")]
		public int DeleteDuplicateQuestions()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Question")]
	public partial class Question : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _QuestionNumber;
		
		private string _Question1;
		
		private string _Question2;
		
		private string _Question3;
		
		private int _SubjectId;
		
		private System.DateTime _PostedOn;
		
		private bool _IsSpam;
		
		private int _UserId;
		
		private EntityRef<Subject> _Subject;
		
		private EntityRef<UserData> _UserData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnQuestionNumberChanging(int value);
    partial void OnQuestionNumberChanged();
    partial void OnQuestion1Changing(string value);
    partial void OnQuestion1Changed();
    partial void OnQuestion2Changing(string value);
    partial void OnQuestion2Changed();
    partial void OnQuestion3Changing(string value);
    partial void OnQuestion3Changed();
    partial void OnSubjectIdChanging(int value);
    partial void OnSubjectIdChanged();
    partial void OnPostedOnChanging(System.DateTime value);
    partial void OnPostedOnChanged();
    partial void OnIsSpamChanging(bool value);
    partial void OnIsSpamChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    #endregion
		
		public Question()
		{
			this._Subject = default(EntityRef<Subject>);
			this._UserData = default(EntityRef<UserData>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionNumber", DbType="Int NOT NULL")]
		public int QuestionNumber
		{
			get
			{
				return this._QuestionNumber;
			}
			set
			{
				if ((this._QuestionNumber != value))
				{
					this.OnQuestionNumberChanging(value);
					this.SendPropertyChanging();
					this._QuestionNumber = value;
					this.SendPropertyChanged("QuestionNumber");
					this.OnQuestionNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Question1", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Question1
		{
			get
			{
				return this._Question1;
			}
			set
			{
				if ((this._Question1 != value))
				{
					this.OnQuestion1Changing(value);
					this.SendPropertyChanging();
					this._Question1 = value;
					this.SendPropertyChanged("Question1");
					this.OnQuestion1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Question2", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Question2
		{
			get
			{
				return this._Question2;
			}
			set
			{
				if ((this._Question2 != value))
				{
					this.OnQuestion2Changing(value);
					this.SendPropertyChanging();
					this._Question2 = value;
					this.SendPropertyChanged("Question2");
					this.OnQuestion2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Question3", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Question3
		{
			get
			{
				return this._Question3;
			}
			set
			{
				if ((this._Question3 != value))
				{
					this.OnQuestion3Changing(value);
					this.SendPropertyChanging();
					this._Question3 = value;
					this.SendPropertyChanged("Question3");
					this.OnQuestion3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectId", DbType="Int NOT NULL")]
		public int SubjectId
		{
			get
			{
				return this._SubjectId;
			}
			set
			{
				if ((this._SubjectId != value))
				{
					if (this._Subject.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSubjectIdChanging(value);
					this.SendPropertyChanging();
					this._SubjectId = value;
					this.SendPropertyChanged("SubjectId");
					this.OnSubjectIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostedOn", DbType="DateTime NOT NULL")]
		public System.DateTime PostedOn
		{
			get
			{
				return this._PostedOn;
			}
			set
			{
				if ((this._PostedOn != value))
				{
					this.OnPostedOnChanging(value);
					this.SendPropertyChanging();
					this._PostedOn = value;
					this.SendPropertyChanged("PostedOn");
					this.OnPostedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsSpam", DbType="Bit NOT NULL")]
		public bool IsSpam
		{
			get
			{
				return this._IsSpam;
			}
			set
			{
				if ((this._IsSpam != value))
				{
					this.OnIsSpamChanging(value);
					this.SendPropertyChanging();
					this._IsSpam = value;
					this.SendPropertyChanged("IsSpam");
					this.OnIsSpamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._UserData.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subject_Question", Storage="_Subject", ThisKey="SubjectId", OtherKey="Id", IsForeignKey=true)]
		public Subject Subject
		{
			get
			{
				return this._Subject.Entity;
			}
			set
			{
				Subject previousValue = this._Subject.Entity;
				if (((previousValue != value) 
							|| (this._Subject.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Subject.Entity = null;
						previousValue.Questions.Remove(this);
					}
					this._Subject.Entity = value;
					if ((value != null))
					{
						value.Questions.Add(this);
						this._SubjectId = value.Id;
					}
					else
					{
						this._SubjectId = default(int);
					}
					this.SendPropertyChanged("Subject");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserData_Question", Storage="_UserData", ThisKey="UserId", OtherKey="Id", IsForeignKey=true)]
		public UserData UserData
		{
			get
			{
				return this._UserData.Entity;
			}
			set
			{
				UserData previousValue = this._UserData.Entity;
				if (((previousValue != value) 
							|| (this._UserData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._UserData.Entity = null;
						previousValue.Questions.Remove(this);
					}
					this._UserData.Entity = value;
					if ((value != null))
					{
						value.Questions.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("UserData");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Subject")]
	public partial class Subject : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _SubjectName;
		
		private EntitySet<Question> _Questions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSubjectNameChanging(string value);
    partial void OnSubjectNameChanged();
    #endregion
		
		public Subject()
		{
			this._Questions = new EntitySet<Question>(new Action<Question>(this.attach_Questions), new Action<Question>(this.detach_Questions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string SubjectName
		{
			get
			{
				return this._SubjectName;
			}
			set
			{
				if ((this._SubjectName != value))
				{
					this.OnSubjectNameChanging(value);
					this.SendPropertyChanging();
					this._SubjectName = value;
					this.SendPropertyChanged("SubjectName");
					this.OnSubjectNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subject_Question", Storage="_Questions", ThisKey="Id", OtherKey="SubjectId")]
		public EntitySet<Question> Questions
		{
			get
			{
				return this._Questions;
			}
			set
			{
				this._Questions.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Questions(Question entity)
		{
			this.SendPropertyChanging();
			entity.Subject = this;
		}
		
		private void detach_Questions(Question entity)
		{
			this.SendPropertyChanging();
			entity.Subject = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserData")]
	public partial class UserData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _IpAddress;
		
		private System.DateTime _LastPosted;
		
		private bool _CanPost;
		
		private EntitySet<Question> _Questions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnIpAddressChanging(string value);
    partial void OnIpAddressChanged();
    partial void OnLastPostedChanging(System.DateTime value);
    partial void OnLastPostedChanged();
    partial void OnCanPostChanging(bool value);
    partial void OnCanPostChanged();
    #endregion
		
		public UserData()
		{
			this._Questions = new EntitySet<Question>(new Action<Question>(this.attach_Questions), new Action<Question>(this.detach_Questions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IpAddress", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string IpAddress
		{
			get
			{
				return this._IpAddress;
			}
			set
			{
				if ((this._IpAddress != value))
				{
					this.OnIpAddressChanging(value);
					this.SendPropertyChanging();
					this._IpAddress = value;
					this.SendPropertyChanged("IpAddress");
					this.OnIpAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastPosted", DbType="DateTime NOT NULL")]
		public System.DateTime LastPosted
		{
			get
			{
				return this._LastPosted;
			}
			set
			{
				if ((this._LastPosted != value))
				{
					this.OnLastPostedChanging(value);
					this.SendPropertyChanging();
					this._LastPosted = value;
					this.SendPropertyChanged("LastPosted");
					this.OnLastPostedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CanPost", DbType="Bit NOT NULL")]
		public bool CanPost
		{
			get
			{
				return this._CanPost;
			}
			set
			{
				if ((this._CanPost != value))
				{
					this.OnCanPostChanging(value);
					this.SendPropertyChanging();
					this._CanPost = value;
					this.SendPropertyChanged("CanPost");
					this.OnCanPostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserData_Question", Storage="_Questions", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<Question> Questions
		{
			get
			{
				return this._Questions;
			}
			set
			{
				this._Questions.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Questions(Question entity)
		{
			this.SendPropertyChanging();
			entity.UserData = this;
		}
		
		private void detach_Questions(Question entity)
		{
			this.SendPropertyChanging();
			entity.UserData = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.v_Question")]
	public partial class v_Question
	{
		
		private string _SubjectName;
		
		private int _QuestionNumber;
		
		private string _Question1;
		
		private string _Question2;
		
		private string _Question3;
		
		private System.DateTime _PostedOn;
		
		private string _IpAddress;
		
		private System.DateTime _LastPosted;
		
		private bool _CanPost;
		
		private bool _IsSpam;
		
		public v_Question()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string SubjectName
		{
			get
			{
				return this._SubjectName;
			}
			set
			{
				if ((this._SubjectName != value))
				{
					this._SubjectName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionNumber", DbType="Int NOT NULL")]
		public int QuestionNumber
		{
			get
			{
				return this._QuestionNumber;
			}
			set
			{
				if ((this._QuestionNumber != value))
				{
					this._QuestionNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Question1", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Question1
		{
			get
			{
				return this._Question1;
			}
			set
			{
				if ((this._Question1 != value))
				{
					this._Question1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Question2", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Question2
		{
			get
			{
				return this._Question2;
			}
			set
			{
				if ((this._Question2 != value))
				{
					this._Question2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Question3", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Question3
		{
			get
			{
				return this._Question3;
			}
			set
			{
				if ((this._Question3 != value))
				{
					this._Question3 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostedOn", DbType="DateTime NOT NULL")]
		public System.DateTime PostedOn
		{
			get
			{
				return this._PostedOn;
			}
			set
			{
				if ((this._PostedOn != value))
				{
					this._PostedOn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IpAddress", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string IpAddress
		{
			get
			{
				return this._IpAddress;
			}
			set
			{
				if ((this._IpAddress != value))
				{
					this._IpAddress = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastPosted", DbType="DateTime NOT NULL")]
		public System.DateTime LastPosted
		{
			get
			{
				return this._LastPosted;
			}
			set
			{
				if ((this._LastPosted != value))
				{
					this._LastPosted = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CanPost", DbType="Bit NOT NULL")]
		public bool CanPost
		{
			get
			{
				return this._CanPost;
			}
			set
			{
				if ((this._CanPost != value))
				{
					this._CanPost = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsSpam", DbType="Bit NOT NULL")]
		public bool IsSpam
		{
			get
			{
				return this._IsSpam;
			}
			set
			{
				if ((this._IsSpam != value))
				{
					this._IsSpam = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
