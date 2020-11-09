<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="project.Main" %>

<link rel="Stylesheet" type="text/css" href="StyleSheet1.css" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link type="text/css" rel="stylesheet" href="~/css/bootstrap.min.css" />
    <link type="text/css" rel="stylesheet" href="~/css/normalize.css" />
</head>
<body>
    <h1 style="text-align: center; background-color: dimgrey">IoT home data monitoring</h1>
    <form id="form1" runat="server" method="post">
        <table style="margin-left: auto; margin-right: auto; margin-top: auto; margin-bottom: auto;">
            <tr>
                <td>
                    <asp:TextBox ID="txtID" runat="server" placeholder="ID" style="text-align: center"></asp:TextBox>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtPW" runat="server" placeholder="PW" style="text-align: center"></asp:TextBox>
            </tr>
            <tr>
                <td style="text-align:center">
                    <asp:Label ID="lblDisp" runat="server" Text="" style="text-align: center" CssClass="badge badge-danger"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: center">
                    <asp:Button ID="LogIn" runat="server" Text="LogIn" OnClick="LogIn_Click"/>
                    <asp:Button ID="SignUp" runat="server" Text="SignUp" OnClick="SignUp_Click" />
                </td>
            </tr>
        </table>
        <br />


    </form>
    <script type="text/javascript" src='<% ResolveUrl("~/Scripts/jquery-3.0.0.min.js"); %>'></script>
    <script src="~/js/bootstrap.min.js"></script>
</body>

</html>
