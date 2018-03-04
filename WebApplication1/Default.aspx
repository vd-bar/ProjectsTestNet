<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
     <p><label for="Text1">Логин&nbsp;&nbsp;  <em>* </em></label><asp:TextBox ID="Text1" runat="server"></asp:TextBox></p>
     <p><label for="Text2">Пароль <em>*&nbsp; </em></label><asp:TextBox ID="Text2" runat="server"></asp:TextBox></p>
    </div>
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="Button" BackColor="Yellow" runat="server" Text="Enter" Width="65px" OnClick="Button_Click"/>
        </div>
        <p><asp:Label ID="labelRespons" runat="server" Width="150px"></asp:Label></p>
    </form>
</body>
</html>
