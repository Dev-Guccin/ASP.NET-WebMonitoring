<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="FrmASWrite.aspx.cs" Inherits="project.MasterPage.FrmASWrite" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="alert alert-dismissible alert-secondary" style="margin: 10px;">
        <table style="width: 400px;">
            <tr>
                <td align="center">
                    <h2>QnA 글쓰기</h2>
                </td>
            </tr>
            <tr>
                <td class="form-group">
                    <label for="exampleInputEmail1">작성자</label>
                    <asp:TextBox class="form-control" ID="txtname" runat="server" placeholder="Name"></asp:TextBox>
                    <small id="emailHelp" class="form-text text-muted">*필수</small>
                </td>
            </tr>
            <tr>
                <td>
                    <label for="exampleInputEmail1">비밀번호</label>
                    <asp:TextBox class="form-control" ID="txtpass" runat="server" placeholder="Password"></asp:TextBox>
                    <small id="emailHelp2" class="form-text text-muted">*필수(게시물수정,삭제시 필요)</small>
            </tr>
            <tr>
                <td>
                    <label for="exampleInputEmail1">E-Mail</label>
                    <asp:TextBox class="form-control" ID="txtemail" runat="server" placeholder="E-Mail"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <label for="exampleInputEmail1">글 제목</label>
                    <asp:TextBox class="form-control" ID="txttitle" runat="server" Width="200px" placeholder="Title"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <label for="exampleInputEmail1">글 내용</label>
                    <asp:TextBox class="form-control" ID="txtcontents" runat="server" Height="200px" TextMode="MultiLine" placeholder="문제상황을 명확히 명시해주십시오."></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button class="btn btn-primary" ID="btnWrite" runat="server" Text="Submit" OnClick="btnWrite_Click" />
                    <asp:Button class="btn btn-primary" ID="btnList" runat="server" Text="Cancle" OnClick="btnList_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
