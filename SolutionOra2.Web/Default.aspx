<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SolutionOra2.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <script src="//code.jquery.com/jquery-1.10.2.js"></script>
  <script src="//code.jquery.com/ui/1.11.3/jquery-ui.js"></script>
    <link rel='stylesheet' href='Scripts/fullcalendar.css' />
<script src='Scripts/moment.min.js'></script>
<script src='Scripts/fullcalendar.js'></script>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox runat="server" ID="TextBoxDatum"></asp:TextBox>
         <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
       
        <asp:CustomValidator EnableClientScript="false" runat="server" ID="CustomValidatorDatum" ErrorMessage="Hiba a dátummal" Display="Dynamic"
             OnServerValidate="CustomValidatorDatum_ServerValidate"></asp:CustomValidator>
        <asp:Button Text="Mentsd el kérlek" runat="server" ID="SaveButton" OnClick="SaveButton_Click" />

        <asp:ListView runat="server" ID="listview">
            <ItemTemplate>
                <div>
                    <%# Eval("ID") %> : <%# Eval("StartDate") %> : <%# Eval("JogcimTitle") %>
                </div>
            </ItemTemplate>
        </asp:ListView>
        <div id="calendar"></div>

        <asp:DropDownList runat="server" ID="jogcimBLL" DataTextField="Title" DataValueField="ID"></asp:DropDownList>
    </div>
        <script>
            $('#calendar').fullCalendar({
                events: '/Services.asmx/GetEvents'
            });
        </script>
    </form>
</body>
</html>
