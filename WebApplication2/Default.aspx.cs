using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default : System.Web.UI.Page
    {
        protected const string key = "number";
        protected const string key2 = "umn";
        protected const string key3 = "number2";
        protected const string key4 = "result";

        protected string CountNumber
        { 

            set
            {
                object objj = ViewState[key2];
                if (objj == null)
                    bl = true;

                if ((bool)ViewState[key2])
                {
                    object obj = ViewState[key];
                    ViewState[key2]=true;
                    if (obj != null)
                    {
                        ViewState[key] = string.Concat((string)obj, value);
                    }
                    else ViewState[key] = value;
                }
                else
                {
                    object obj3 = ViewState[key3];
                    if (obj3!= null)
                    {
                        ViewState[key3] = string.Concat((string)obj3, value);
                    }
                    else ViewState[key3] = value;
                }
            }
            get
            {
                if ((bool)ViewState[key2])
                {
                    object obj = ViewState[key];
                    if (obj != null)
                    {
                        return obj.ToString();
                    }
                    else return 0.ToString();
                }
                else
                {
                    object obj3 = ViewState[key3];
                    if (obj3!= null)
                    {
                        return obj3.ToString();
                    }
                    else return 0.ToString();

                }

            }
        }
        protected bool bl
        {
            set
            {
                object obj2 = ViewState[key2];
                if (obj2 != null)
                {
                    ViewState[key2] = value;
                }
                ViewState[key2] = value;
            }
            get
            {

                object obj2 = ViewState[key2];
                if (obj2 != null)
                {
                    return (bool)obj2;
                }
                return false;

            }
        }

        protected int Result
        {
            set
            {
                object obj = ViewState[key4];
                if (obj != null)
                {
                    ViewState[key4] = value;
                }
                else ViewState[key4] = value;

            }
            get
            {
                object obj = ViewState[key4];

                if (obj != null)
                { return (int)ViewState[key4]; }
                else return 0;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            CountNumber = 1.ToString();
            TextBox1.Text = CountNumber.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CountNumber = 2.ToString();
            TextBox1.Text = CountNumber.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CountNumber = 3.ToString();
            TextBox1.Text = CountNumber.ToString();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            CountNumber = 4.ToString();
            TextBox1.Text = CountNumber.ToString();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            CountNumber = 5.ToString();
            TextBox1.Text = CountNumber.ToString();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            CountNumber = 6.ToString();
            TextBox1.Text = CountNumber.ToString();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            CountNumber = 7.ToString();
            TextBox1.Text = CountNumber.ToString();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            CountNumber = 8.ToString();
            TextBox1.Text = CountNumber.ToString();
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            CountNumber = 9.ToString();
            TextBox1.Text = CountNumber.ToString();
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            CountNumber = 0.ToString();
            TextBox1.Text = CountNumber.ToString();
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            ViewState[key] = null;
            ViewState[key3] = null;
            ViewState[key4] = null;
            ViewState[key2] = null;
            TextBox1.Text = null;
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            object obj = ViewState[key];
            object obj2 = ViewState[key3];
            decimal num,num2;
            if (obj != null && obj2 != null)
            {
               if( decimal.TryParse(obj.ToString(), out  num)&& (decimal.TryParse(obj2.ToString(), out num2)))
                {
                    TextBox1.Text = null;
                    object obj3 = ViewState[key4];
                    if(obj3!=null&&(int)obj3==1)                   
                    TextBox1.Text = (num * num2).ToString();
                    else if (obj3 != null && (int)obj3 == 2)
                        TextBox1.Text = (num/num2).ToString();
                    else if (obj3 != null && (int)obj3 == 3)
                        TextBox1.Text = (num + num2).ToString();
                    else if (obj3 != null && (int)obj3 == 4)
                        TextBox1.Text = (num - num2).ToString();
                }

            }
                
          
        }

        protected void Umn_Click(object sender, EventArgs e)
        {
            bl = false;
            Result = 1;
        }

        protected void Del_Click(object sender, EventArgs e)
        {
            bl = false;
            Result = 2;
        }

        protected void Plus_Click(object sender, EventArgs e)
        {
            bl = false;
            Result = 3;
        }

        protected void Minus_Click(object sender, EventArgs e)
        {
            bl = false;
            Result = 4;
        }
    }
}