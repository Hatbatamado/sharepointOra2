<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kezdolap.aspx.cs" Inherits="SolutionOra2.Web.Kezdolap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Business | Acquire</title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css" />
    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap-theme.min.css" />
    <link rel="stylesheet" href='/Styles/MainStyle.css' type="text/css" />

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
    <script src="//code.jquery.com/jquery-1.11.2.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="topHeader fullWidth">
            <div class="icons">
                <span class="glyphicon glyphicon-envelope whiteicon" aria-hidden="true"></span>
                <span class="glyphicon glyphicon-glass whiteicon" aria-hidden="true"></span>
                <span class="glyphicon glyphicon-search whiteicon" aria-hidden="true"></span>
                <span class="glyphicon glyphicon-star whiteicon" aria-hidden="true"></span>
            </div>
        </div>
        <div class="header fullWidth">
            <div class="logoDiv">
                <div class="logoImage"></div>
                <div class="title1">Acquire</div>
                <div class="title2">Business Specialists</div>
            </div>
            <div class="menuDiv">
                <asp:Repeater runat="server" ID="ReaperMenu">
                    <HeaderTemplate>
                        <ul class="menu">
                    </HeaderTemplate>
                    <ItemTemplate>
                        <li class="menuitem">
                            <asp:HyperLink runat="server" ID="MenuItemHL" CssClass="menulink"
                                Text='<%# Eval("Cim") %>' NavigateUrl='<%# Eval("Link") %>'></asp:HyperLink>
                        </li>
                    </ItemTemplate>
                    <FooterTemplate>
                        </ul>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
        <div class="rotator fullWidth" id="rotatorDiv">
            <div class="rotatorManager"></div>
        </div>

        <script>
            var imgArray = new Array();
            var imgUrl = "/Images/slide-01.jpeg";
            imgArray.push(imgUrl);
            imgArray.push("/Images/slide-02.jpg");
            var index = 0;

            rotate();
            //initRotatorManager(imgArray, index);
            setInterval(rotate, 5000);

            function rotate() {
                if (imgArray.length == index)
                    index = 0;
                selectImg(index);
                index++;
            }

            function initRotatorManager(imgArray, selectedIndex) {
                $(".rotatorManager").html("");
                var index = 0;
                for (var img in imgArray) {
                    var recentHtml = $(".rotatorManager").html();
                    var newIcon = "<span onclick='selectImg("+index+")' class=\"glyphicon glyphicon-unchecked rotatoricon\" aria-hidden=\"true\"></span>";
                    if (selectedIndex == index)
                        newIcon = "<span onclick='selectImg(" + index + ")' class=\"glyphicon glyphicon-record rotatoricon\" aria-hidden=\"true\"></span>";
                    $(".rotatorManager").html(recentHtml + newIcon);
                    index++;
                }
            }

            function selectImg(selectedIndex)
            {
                $("#rotatorDiv").attr("style", "background: url('" + imgArray[selectedIndex] + "') no-repeat");
                initRotatorManager(imgArray, selectedIndex);
            }
        </script>
    </form>
</body>
</html>
