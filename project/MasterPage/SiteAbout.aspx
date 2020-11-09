<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="SiteAbout.aspx.cs" Inherits="project.MasterPage.SiteAbout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-muted">
        라즈베리파이를 이용하여 온도와 습도값을 실시간으로 모니터링한다.<br />
        해당 데이터는 firebase에 저장된다.<br />
        이때 실시간으로 받은 데이터를 사용자는 차트로 확인 가능하다.<br />
        또한 평균온도, 평균습도, 최고온도, 최고습도를 모니터링 할 수 있다.....<br />
    </div>
</asp:Content>
