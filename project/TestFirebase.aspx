<%@ Page Language="C#" EnableViewState="true" AutoEventWireup="true" CodeBehind="TestFirebase.aspx.cs" Inherits="project.TestFirebase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click"/>
            <asp:Chart ID="Chart1" runat="server">
                <Series>
                    <asp:Series Name="Series1" ChartType="Line"></asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
