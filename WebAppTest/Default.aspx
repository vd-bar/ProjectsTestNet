<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppTest.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <title></title>

    <script src="Script/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="Script/jquery.dynDateTime.min.js" type="text/javascript"></script>
    <script src="Script/calendar-en.min.js" type="text/javascript"></script>
    <link href="Styles/calendar-blue.css" rel="stylesheet" type="text/css" />
    <script src="Script/script.js"></script>
    <script type = "text/javascript">
     $(document).ready(function () {
            $("#<%=TextBox4.ClientID%>,#<%=TextBox5.ClientID%>").dynDateTime({
                showsTime: true,
                ifFormat: "%Y/%m/%d %H:%M",
                daFormat: "%l;%M %p, %e %m, %Y",
                align: "BR",
                electric: false,
                singleClick: false,
                displayArea: ".siblings('.dtcDisplayArea')",
                button: ".next()"
            });
        });
    
    </script>
   

    <style type="text/css">
        
         .auto-style1 {            width: 709px;
         }
        .auto-style2 {
            width: 146px;
        }
        .auto-style3 {
            width: 204px;
        }
        .auto-style5 {
            width: 146px;
            height: 20px;
        }
        .auto-style6 {
            width: 204px;
            height: 20px;
        }
        .auto-style8 {
            height: 569px;
        }
        .auto-style10 {
            width: 293px;
            height: 20px;
        }
        .auto-style11 {
            width: 293px;
        }
        .auto-style12 {
            width: 146px;
            height: 30px;
        }
        .auto-style13 {
            width: 204px;
            height: 30px;
        }
        .auto-style14 {
            width: 293px;
            height: 30px;
        }
        .auto-style15 {
            width: 52%;
        }
        .auto-style17 {
            width: 218px;
        }
        .auto-style18 {
            width: 374px;
        }
        .auto-style19 {
            width: 149px;
        }
    </style>
</head>
<body style="height: 566px">
    <form id="form1" runat="server" class="auto-style8">
    
        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="NameIdCode" HeaderText="Наменклатурный код"/>
                <asp:BoundField DataField="NameDetails" HeaderText="Наименование"/>
                <asp:BoundField DataField="Quantity" HeaderText="Количество"/>
                <asp:BoundField DataField="NameStoreKeeper" HeaderText="Кладовщик"/>
                <asp:BoundField DataField="DateAdd" HeaderText="Дата создания"/>
                <asp:BoundField DataField="DateDelete" HeaderText="Дата удаления"/>
            </Columns>

        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
    <asp:Label runat="server" Text="Добавление Детали"></asp:Label>
         
    <table class="auto-style1">
        <tr>
            <td class="auto-style5">Номенклатурный код</td>
            <td class="auto-style6">
                <asp:TextBox ID="TextBox1" runat="server" Width="209px" Height="20px"></asp:TextBox>
            </td>
            <td class="auto-style10">
                <asp:RequiredFieldValidator  runat="server"
                                             ID="RequiredFieldValidator1"
                                             ControlToValidate="TextBox1"
                                             ErrorMessage="Поле должно быть заполнено"
                                             ForeColor="red"
                                             ></asp:RequiredFieldValidator>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style12">Наименование</td>
            <td class="auto-style13">
                <asp:TextBox ID="TextBox2" runat="server" Width="209px" Height="20px"></asp:TextBox>
            </td>
            <td class="auto-style14">
                <asp:RequiredFieldValidator  runat="server"
                                             ID="RequiredFieldValidator2"
                                             ControlToValidate="TextBox2"
                                             ErrorMessage="Поле должно быть заполнено"
                                             ForeColor="red"
                ></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Количество</td>
            <td class="auto-style6">
                <asp:TextBox ID="TextBox3" runat="server" Width="209px" Height="20px"></asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:RegularExpressionValidator  runat="server"
                                                 ID="RegularExpressValidator"
                                                 ControlToValidate="TextBox3"
                                                 ErrorMessage="Допускается ввод только чисел"
                                                ValidationExpression="[0-9 ]+$" 
                                                ForeColor="red"
                    ></asp:RegularExpressionValidator>
               
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Кладовщик</td>
            <td class="auto-style6">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="217px" >
                </asp:DropDownList>
            </td>
            <td class="auto-style10">
         
                <asp:Label ID="Label1" Text=""  runat="server"  ForeColor="red"></asp:Label>
         
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Дата создания</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox4" runat="server" Width="209px" ReadOnly = "true" Height="20px" ValidateRequestMode="Enabled" ></asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:Label ID="Label2" Text=" "  runat="server"  ForeColor="red"></asp:Label>
            </td>
        </tr>
        </table>
        

        <p>
            <asp:Button  ID="Button1" runat="server" Text="Добавить деталь"  OnClick="Button1_Click"/>
            
        </p>
        <table class="auto-style15">
            <tr>
                <td class="auto-style19">Дата удаления</td>
                <td class="auto-style17">
                <asp:TextBox ID="TextBox5" runat="server" Width="209px" ReadOnly = "true"></asp:TextBox>
                </td>
                <td class="auto-style18">
                    <asp:Label ID="Label3" runat="server" ForeColor="red" Text=""></asp:Label>
                </td>
            </tr>
        </table>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Удалить" Width="87px" OnClick="Button2_Click1" ></asp:Button>
            <a href="Default2.aspx">Переход к кладовщикам</a>
        </p>
        

    </form>
    </body>
</html>
