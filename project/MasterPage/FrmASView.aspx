<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="FrmASView.aspx.cs" Inherits="project.MasterPage.FrmASView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table style="width: 80px">
            <tr>
                <td aling="center">
                    <span>게시판 글보기</span>
                </td>
            </tr>
            <tr>
                <td>
                    <hr />
                </td>
            </tr>
            <tr>
                <td>작성자 :
                        <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>&nbsp;
                    작성일 :
                        <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    제목 :
                    <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtContents" runat="server" TextMode="MultiLine" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnList" runat="server" Text="리스트" OnClick="btnList_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
