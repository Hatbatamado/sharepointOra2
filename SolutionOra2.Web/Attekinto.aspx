<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Attekinto.aspx.cs" Inherits="SolutionOra2.Web.Attekinto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .piros {
            background-color: red;
            height:25px;
            width:25px;
            display:inline-block;
            padding-right:5px;
        }
        .kek {
            background-color: darkblue;
            height:25px;
            width:25px;
            display:inline-block;
            padding-right:5px;
        }
        .szurke {
            background-color: gray;
            height:25px;
            width:25px;
            display:inline-block;
            padding-right:5px;
        }
        .honapNeve{
            display:inline-block;
            width:150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater runat="server" ID="KulsoRepeater">
            <ItemTemplate>
                <div class="honapNeve"><%# Eval("HonapNeve") %></div>
                <asp:Repeater runat="server" ID="BelsoRepeater" DataSource='<%# Eval("BelsoLista") %>'>
                    <ItemTemplate>
                        <div runat="server" id="bejelentesKocka" class='<%# Eval("ElemOsztaly") %>'>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <br />
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
