<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body >
    <form id="form1" runat="server">
    <div style="margin:200px; width: 813px">
    
        <asp:TextBox ID="TextBox1" runat="server" Width="420px" Height="33px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="29px" Text="1" Width="105px" OnClick="Button1_Click" />
&nbsp;<asp:Button ID="Button2" runat="server" Height="29px" Text="2" Width="105px" OnClick="Button2_Click" />
&nbsp;<asp:Button ID="Button3" runat="server" Height="29px" Text="3" Width="105px" OnClick="Button3_Click" />
&nbsp;<asp:Button ID="Umn" runat="server" Height="29px" Text="*" Width="105px" OnClick="Umn_Click"/>
        <br />
        <asp:Button ID="Button5" runat="server" Height="29px" Text="4" Width="105px" OnClick="Button5_Click"/>
&nbsp;<asp:Button ID="Button6" runat="server" Height="29px" Text="5" Width="105px" OnClick="Button6_Click"/>
&nbsp;<asp:Button ID="Button7" runat="server" Height="29px" Text="6" Width="105px" OnClick="Button7_Click"/>
&nbsp;<asp:Button ID="Del" runat="server" Height="29px" Text="/" Width="105px" OnClick="Del_Click"/>
        <br />
        <asp:Button ID="Button9" runat="server" Height="29px" Text="7" Width="105px" OnClick="Button9_Click"/>
&nbsp;<asp:Button ID="Button10" runat="server" Height="29px" Text="8" Width="105px" OnClick="Button10_Click"/>
&nbsp;<asp:Button ID="Button11" runat="server" Height="29px" Text="9" Width="105px" OnClick="Button11_Click"/>
&nbsp;<asp:Button ID="Plus" runat="server" Height="29px" Text="+" Width="105px" OnClick="Plus_Click"/>
        <br />
        <asp:Button ID="Button13" runat="server" Height="29px" Text="0" Width="105px" OnClick="Button13_Click"/>
&nbsp;<asp:Button ID="Button14" runat="server" Height="29px" Text="C" Width="105px" OnClick="Button14_Click"/>
&nbsp;<asp:Button ID="Button15" runat="server" Height="29px" Text="=" Width="105px" OnClick="Button15_Click"/>
&nbsp;<asp:Button ID="Minus" runat="server" Height="29px" Text="-" Width="105px" OnClick="Minus_Click" />
    
    </div>
    </form>
</body>
</html>
