<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Продукты&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Корзина<br />
        <asp:ListBox ID="ListBox1" runat="server" Width="120px" SelectionMode="Multiple">
            <asp:ListItem Text="Молоко"></asp:ListItem>
            <asp:ListItem Text="Кефир"></asp:ListItem>
            <asp:ListItem Text="Хлеб"></asp:ListItem>
            <asp:ListItem Text="Колбаса"></asp:ListItem>
            <asp:ListItem Text="Шоколад"></asp:ListItem>
            <asp:ListItem Text="Напиток"></asp:ListItem>
        </asp:ListBox>
&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="ListBox2" runat="server" Width="120px" style="margin-left:50px" SelectionMode="Multiple">

        </asp:ListBox>
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="В корзину" OnClick="Button1_Click" />
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Удалить с корзины" OnClick="Button2_Click" />&nbsp;
&nbsp;<asp:Button ID="Button3" runat="server" Text="Перенести все в карзину" OnClick="Button3_Click" />&nbsp;
&nbsp;<asp:Button ID="Button4" runat="server" Text="Убрать все с карзины" />
        <br />
    
    </div>
    </form>
</body>
</html>
