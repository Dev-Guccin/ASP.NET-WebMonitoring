<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="project.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LoginView ID="LoginView1" runat="server">
                <AnonymousTemplate>
                    로그인 해 주세요
                    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/TestRegister.aspx">로그인</asp:LinkButton>
                </AnonymousTemplate>
                <LoggedInTemplate>
                    <asp:LoginName ID="LoginName1" runat="server" />님 반갑습니다.
                    <asp:LoginStatus ID="LoginStatus1" runat="server" />
                </LoggedInTemplate>
            </asp:LoginView>
        </div>
    </form>
</body>
</html>
