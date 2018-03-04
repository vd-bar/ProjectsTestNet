<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="WebAppTest.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<style type="text/css">
    .Grid {
        float: left
    }
    .auto-style1 {
        width: 404px;
        height: 73px;
       padding-left: 30px;
    }
    .auto-style2 {
        width: 40%;
    }
    .auto-style3 {
        width: 257px;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" CssClass="Grid" runat="server" AutoGenerateColumns="true"></asp:GridView>
      
    </div>
        <div  class="auto-style1">

            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="171px">
                        </asp:DropDownList>
                       
                    </td>
                    <td> <asp:Button ID="Button1" runat="server" Text="Удалить" Width="90px" OnClick="Button1_Click" /></td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox1" runat="server" Width="159px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Добавить" Width="93px" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>

        </div>
        <a href="Default.aspx">Перейти к деталям</a>
    </form>
</body>
</html>
