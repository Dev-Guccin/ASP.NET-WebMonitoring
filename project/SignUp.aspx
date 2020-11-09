<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="project.SignUp" %>
<link rel="Stylesheet" type="text/css" href="StyleSheet1.css" />

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link type="text/css" rel="stylesheet" href="~/css/bootstrap.min.css" />
    <link type="text/css" rel="stylesheet" href="~/css/normalize.css" />
</head>
<body>
    <h1 style="text-align:center; background-color:dimgrey">IoT home data monitoring</h1>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Enter your name</td>
                    <td>
                        <asp:TextBox ID="name" runat="server" placeholder="NAME"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="type your name" ControlToValidate="name" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>                        
                </tr>
                <tr>
                    <td>Enter your id</td>
                    <td>
                        <asp:TextBox ID="id" runat="server" placeholder="ID"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="type your id" ControlToValidate="id" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Enter your passwd</td>
                    <td>
                        <asp:TextBox ID="pw1" runat="server" Textmode="Password" placeholder="PASSWD"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="비밀번호를 입력해주세요" ControlToValidate="pw1" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="4~8자로 입력바람" ControlToValidate="pw1" Display="Dynamic" ValidationExpression="\w{4,8}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Confirm passwd</td>
                    <td>
                        <asp:TextBox ID="pw2" runat="server" Textmode="Password" placeholder="PASSWD"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="비밀번호를 확인해주세요" ControlToValidate="pw2" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="비밀번호가 일치하지 않습니다" ControlToValidate="pw2" ControlToCompare="pw1" SetFocusOnError="True" Display="Dynamic"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>Enter your deviceid</td>
                    <td>
                        <asp:TextBox ID="deviceid" runat="server" placeholder="DEVICE ID"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="deviceid" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                        <asp:Button ID="btnCancle" runat="server" Text="Cancle"  CausesValidation="false" OnClick="btnCancle_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
    <script type="text/javascript" src='<% ResolveUrl("~/Scripts/jquery-3.0.0.min.js"); %>'></script>
    <script src="~/js/bootstrap.min.js"></script>
</body>
</html>
