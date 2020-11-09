<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="SiteAS.aspx.cs" Inherits="project.MasterPage.SiteAS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table style="width: 800px;">
            <tr>
                <td>
                    <div>
                        <span style="font-size:20px">QnA 게시판</span>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                        <asp:Button ID="btnWrite" runat="server" Text="글쓰기" OnClick="btnWrite_Click" CssClass="btn btn-primary"/>
                    </div>
                </td>

            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="num" DataSourceID="SqlDataSource1" Width="700px">
                        <Columns>
                            <asp:BoundField DataField="num" HeaderText="No" InsertVisible="False" ReadOnly="True" SortExpression="num" />

                            <asp:TemplateField HeaderText="제 목">
                                <ItemTemplate>
                                    <a href="<%# "FrmASView.aspx?No=" + Eval("num") %>">
                                        <%# Eval("title") %>
                                    </a>
                                </ItemTemplate>
                                <HeaderStyle Width="250px" />
                            </asp:TemplateField>


                            <asp:BoundField DataField="name" HeaderText="작성자" SortExpression="name" />
                            <asp:BoundField DataField="writedate" HeaderText="작성일" SortExpression="writedate" />
                            <asp:BoundField DataField="readcnt" HeaderText="조회수" SortExpression="readcnt" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Wed_Asp_DBConnectionString %>" SelectCommand="SELECT [num], [title], [name], [writedate], [readcnt] FROM [tblBrd]"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
