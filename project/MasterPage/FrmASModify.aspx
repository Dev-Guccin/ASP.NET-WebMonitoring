<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="FrmASModify.aspx.cs" Inherits="project.MasterPage.FrmASModify" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table style="width: 400px;">
            <tr>
                <td align="center" colspan="2" class="table-secondary">
                    게시판 글 수정
                </td>
            </tr>
            <tr>
                <td>작성자:</td>
                <td>
                    <asp:Label ID="lblname" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>글제목 </td>
                <td><asp:TextBox ID="txttitle" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>글내용&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtcontents" runat="server" TextMode="MultiLine" Height="350px" Width="280px"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnUpdate" runat="server" Text="게시물수정" OnClick="btnUpdate_Click" />
                    &nbsp;
                    <asp:Button ID="btnCncel" runat="server" Text="수정취소" OnClick="btnCncel_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
