<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Matura.Main" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="wColumnIdth=device-wColumnIdth, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="Spletna stran za pomoc dijakom pri ucenju ustne mature">
    <meta name="author" content="info@matura.xyz">
    
    <meta name="theme-color" content="##4285f4" />
    <meta name="msapplication-navbutton-color" content="#4285f4">
    
    <meta property="og:image" content="http://matura.xyz/Images/header.png"/>
    <meta property="og:image:secure_url" content="http://matura.xyz/Images/header.png" />

    <link rel="icon" type="image/gif" href="Images/favicon.ico">

    <title>Ustna matura 2016</title>
    <script type="text/javascript" src="scripts/jquery-1.9.1.js"></script>
    <script type="text/javascript" src="scripts/bootstrap.min.js"></script>
    <script type="text/javascript">
        function openModal() {
            $('#myModal').modal('show');
        }
    </script>

    <script>
        (function(i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r;
            i[r] = i[r] || function() {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date();
            a = s.createElement(o),
                m = s.getElementsByTagName(o)[0];
            a.async = 1;
            a.src = g;
            m.parentNode.insertBefore(a, m)
        })(window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga');

        ga('create', 'UA-77785119-1', 'auto');
        ga('send', 'pageview');

    </script>

    <!-- Bootstrap core CSS -->
    <link href="Content/bootstrap.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="style.css" rel="stylesheet">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
        <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>

<body>

<form id="form1" runat="server">

    <div class="container-fluid" runat="server">

        <!-- The justified navigation menu is meant for single line per list item.
        Multiple lines will require custom code not provColumnIded by Bootstrap. -->
        <div class="masthead" runat="server">
            <h3 class="custom-header">
                <%--<img class="img-responsive-centered" src="Images/header.png"/><br />--%>
                <a class="btn btn-lg btn-info center-block" role="button" data-toggle="modal" data-target="#myModal">
                    <span class="glyphicon glyphicon-plus-sign" aria-hidden="true"></span>
                    Objavi vprašanje
                </a>
            </h3>
            
            <nav runat="server">
                <ul class="nav nav-justified">
                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">
                            Splošna matura
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu col-xs-12">
                            <li class="dropdown-header">Osnovni predmeti</li>
                            <li role="separator" class="divider"></li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Slovenšcina" runat="server">Slovenščina</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Matematika OR" runat="server">Matematika OR</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Matematika VR" runat="server">Matematika VR</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Anglešcina OR" runat="server">Angleščina OR</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Anglešcina VR" runat="server">Angleščina VR</asp:LinkButton>
                            </li>
                            <li role="separator" class="divider"></li>
                            <li class="dropdown-header">Ostali jeziki</li>
                            <li role="separator" class="divider"></li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Nemšcina OR" runat="server">Nemščina OR</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Nemšcina VR" runat="server">Nemščina VR</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Francošcina OR" runat="server">Francoščina OR</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Francošcina VR" runat="server">Francoščina VR</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Španšcina OR" runat="server">Španščina OR</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Španšcina VR" runat="server">Španščina VR</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Italijanšcina OR" runat="server">Italijanščina OR</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Italijanšcina VR" runat="server">Italijanščina VR</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Rušcina OR" runat="server">Ruščina OR</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Rušcina VR" runat="server">Ruščina VR</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Latinšcina OR" runat="server">Latinščina OR</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="Latinšcina VR" runat="server">Latinščina VR</asp:LinkButton>
                            </li>

                        </ul>
                    </li>

                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">
                            Poklicna matura
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu col-xs-12">
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="PSlovenšcina" runat="server">Slovenščina</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="PMatematika" runat="server">Matematika</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton OnCommand="Subject_Selected" CommandArgument="PAnglešcina" runat="server">Angleščina</asp:LinkButton>
                            </li>
                        </ul>
                    </li>

                </ul>


            </nav>
            <br />

            <div class="table-responsive">
                <table class="table table-hover table-bordered">

                    <thead>
                    <tr>
                        <th colspan="4" class="text-center">
                            <span class="glyphicon glyphicon-book" aria-hidden="true"></span>
                            <asp:Label runat="server" ID="tableHeader">Predmet</asp:Label>
                        </th>
                    </tr>
                    <tr>
                        <th>
                            <asp:LinkButton runat="server" OnClick="OrderByAscending">
                                <span class="glyphicon glyphicon-sort-by-attributes" aria-hidden="true"></span> </asp:LinkButton>
                            <asp:LinkButton runat="server" OnClick="OrderByDescending">
                                <span class="glyphicon glyphicon-sort-by-attributes-alt" aria-hidden="true"></span> </asp:LinkButton>
                        </th>
                        <th>Vprašanje 1</th>
                        <th>Vprašanje 2</th>
                        <th>Vprašanje 3</th>
                    </tr>
                    </thead>
                    <tbody>
                    <asp:Literal id="columnData" runat="server"/>
                    </tbody>
                </table>
            </div>

        </div>

        <!-- Modal -->
        <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="myModalLabel">Objavi vprašanje</h4>
                    </div>
                    <div class="modal-body">
                        <asp:DropDownList runat="server" ID="inputSubject" placeholder="Izberi predmet" class="form-control">
                            <asp:ListItem Value="0" Text="-- Izberi predmet --"/>
                            <asp:ListItem Value="Slovenšcina" Text="Slovenščina"/>
                            <asp:ListItem Value="PSlovenšcina" Text="Slovenščina (poklicna)"/>
                            <asp:ListItem Value="Matematika OR" Text="Matematika OR"/>
                            <asp:ListItem Value="Matematika VR" Text="Matematika VR"/>
                            <asp:ListItem Value="PMatematika" Text="Matematika (poklicna)"/>
                            <asp:ListItem Value="Anglešcina OR" Text="Angleščina OR"/>
                            <asp:ListItem Value="Anglešcina VR" Text="Angleščina VR"/>
                            <asp:ListItem Value="PAnglešcina" Text="Angleščina (poklicna)"/>
                            <asp:ListItem Value="Nemšcina OR" Text="Nemščina OR"/>
                            <asp:ListItem Value="Nemšcina VR" Text="Nemščina VR"/>
                            <asp:ListItem Value="Francošcina OR" Text="Francoščina OR"/>
                            <asp:ListItem Value="Francošcina VR" Text="Francoščina VR"/>
                            <asp:ListItem Value="Španšcina OR" Text="Španščina OR"/>
                            <asp:ListItem Value="Španšcina VR" Text="Španšcina VR"/>
                            <asp:ListItem Value="Italijanšcina OR" Text="Italijanščina OR"/>
                            <asp:ListItem Value="Italijanšcina VR" Text="Italijanšcina VR"/>
                            <asp:ListItem Value="Rušcina OR" Text="Ruščina OR"/>
                            <asp:ListItem Value="Rušcina VR" Text="Rušcina VR"/>
                            <asp:ListItem Value="Latinšcina OR" Text="Latinščina OR"/>
                            <asp:ListItem Value="Latinšcina VR" Text="Latinščina VR"/>
                            
                        </asp:DropDownList>
                        <br />
                        <asp:TextBox runat="server" ID="inputNumber" maxlength="250" class="form-control" placeholder="Številka listka"></asp:TextBox><br />
                        <asp:TextBox runat="server" ID="inputQ1" maxlength="250" class="form-control" placeholder="Vprašanje 1 - max 250 znakov" Rows="5" TextMode="MultiLine"></asp:TextBox>
                        <asp:TextBox runat="server" ID="inputQ2" maxlength="250" class="form-control" placeholder="Vprašanje 2 - max 250 znakov" Rows="5" TextMode="MultiLine"></asp:TextBox>
                        <asp:TextBox runat="server" ID="inputQ3" maxlength="250" class="form-control" placeholder="Vprašanje 3 - če se katerega vprašanja ali številke listka ne spomniš, lahko polja pustiš prazna" Rows="5" TextMode="MultiLine"></asp:TextBox>
                    </div>
                    <div class="modal-footer">
                        <asp:LinkButton class="btn btn-default" OnClick="CloseModal" runat="server">Zapri</asp:LinkButton>
                        <asp:LinkButton class="btn btn-primary" OnClick="SubmitPost" runat="server">Objavi</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
        
        <div class="modal fade" id="aboutModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title">O spletni strani</h4>
                    </div>
                    <div class="modal-body">
                        <b>Spletna stran je namenjena zbiranju listkov iz ustnega dela mature.</b><br><br>
                        <b>Vsako leto morajo dijaki obvezno opraviti še ustni del, kjer pa velja naslednji scenarij:</b><br>
                        - vsaka srednja šola prejme identične pakete 35 listkov za vsak predmet, kar pomeni, da so listki po celotni Sloveniji identični<br>
                        - izjema je tukaj Slovenščina, kjer vsaka šola prejme dva paketa po 35 listkov, še vedno so te listki identični po celotni Sloveniji, vendar
                        pa je za izbiro paketa odvisna srednja šola, ki lahko izbere katerikoli izmed dveh paketov (s tem lahko šole prilagodijo ustni del mature, 
                        ker v nekaterih šolah niso vzeli popolnoma vse snovi)<br>
                        <br>
                        <b>Splošne informacije glede spletne strani:</b><br>
                        - listki, ki imajo številke obarvane z zeleno barvo, so bili objavljeni v zadnjih 15 minutah<br>
                        - listki, ki imajo številko enako -1, so bili objavljeni brez številke (uporabnik, ki je objavil listek, se ne spomni številke listka)<br>
                    </div>
                    <div class="modal-footer">
                        <asp:LinkButton class="btn btn-default" OnClick="CloseModal" runat="server">Zapri</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>

        <div id="footer">
            <div class="container text-center">
                

                <p class="text-muted credit"><a data-toggle="modal" data-target="#aboutModal">O spletni strani</a> | Kontakt: <a href="mailto:info@matura.xyz"><span class="glyphicon glyphicon-envelope" aria-hidden="true"></span></a></p>
                
            </div>
        </div>
    </div> <!-- /container -->



</form>

</body>
</html>
