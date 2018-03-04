using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        
        enum my
        {
            admin,
            qwerty
            }
        protected void Page_Load(object sender, EventArgs e)
        {
            labelRespons.Text = "";
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Text1.Text) && (Text1.Text == my.admin.ToString()))
            {
                if (!string.IsNullOrEmpty(Text2.Text) && (Text2.Text == my.qwerty.ToString()))
                { labelRespons.Text = $"Вход осуществлен под ником:{my.admin}"; }
                else labelRespons.Text = "Проверте корректность ввода данных и повторите попытку ввхода";
            }
            else labelRespons.Text = "Проверте корректность ввода данных и повторите попытку ввхода";


        }
    }
}