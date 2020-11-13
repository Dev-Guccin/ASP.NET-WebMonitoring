<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="FrmASView.aspx.cs" Inherits="project.MasterPage.FrmASView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table style="width: 400px">
            <tr>
                <td align="center" colspan="2" class="table-secondary">
                    게시판 글보기
                </td>
            </tr>
            <tr>
                <td>작성자 :
                        <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                     작성일 :
                        <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    제목 :
                    <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    비밀번호 : 
                    <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td class="text-danger">
                    <asp:Label ID="lblDisp" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:TextBox ID="txtContents" runat="server" TextMode="MultiLine" Width="400px" Height="200px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnModify" runat="server" Text="수정"  OnClick="btnModify_Click"/>
                    <asp:Button ID="btnRemove" runat="server" Text="삭제" OnClick="btnRemove_Click" />
                    <asp:Button ID="btnList" runat="server" Text="리스트" OnClick="btnList_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
