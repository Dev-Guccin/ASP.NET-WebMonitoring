<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="FrmFirebaseChart.aspx.cs" Inherits="project.MasterPage.FrmFirebaseChart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding:10px">
        <table>
            <tr>
                <td colspan="2">
                    <asp:Chart ID="Chart1" runat="server" Width="600px" Palette="Bright">
                        <Series>
                            <asp:Series Name="Temperature" ChartType="Line" ChartArea="ChartArea1" IsValueShownAsLabel="True" LabelBorderWidth="2" Legend="Legend1"></asp:Series>
                            <asp:Series Name="Humidity" ChartType="Line" ChartArea="ChartArea1" IsValueShownAsLabel="True" LabelBorderWidth="2" Legend="Legend1"></asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1" Area3DStyle-IsClustered="True" BorderWidth="2">
                                <Area3DStyle IsClustered="True"></Area3DStyle>
                            </asp:ChartArea>
                        </ChartAreas>
                        <Legends>
                            <asp:Legend Name="Legend1" Title="value">
                            </asp:Legend>
                        </Legends>
                    </asp:Chart>
                </td>
            </tr>
            <tr>
                <td style="padding:5px" colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Update Chart" OnClick="Button1_Click"  CssClass="btn btn-primary"/>
                    <asp:Button ID="Button2" runat="server" Text="Clac Average" OnClick="Button2_Click"  CssClass="btn btn-primary"/>
                    <asp:Button ID="Button3" runat="server" Text="Report Problem" OnClick="Button3_Click" CssClass="btn btn-primary"/>
                </td>
            </tr>
            <tr>
                <td>
                    평균 기온 : <asp:Label ID="lblTemp" runat="server" Text=""></asp:Label>
                </td>
                <td>
                    평균 습도 : <asp:Label ID="lblHumid" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <font style="color:red">최고</font> 기온 : <asp:Label ID="lblBigTemp" runat="server" Text=""></asp:Label>
                </td>
                <td>
                    <font style="color:red">최고</font> 습도 : <asp:Label ID="lblBigHumid" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
