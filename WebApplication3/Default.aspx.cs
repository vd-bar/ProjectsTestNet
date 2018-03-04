using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            for (int i = ListBox1.Items.Count - 1; i >= 0; i--)
            {
                ListItem current = ListBox1.Items[i];
                if (current.Selected)
                {
                    ListItem newlist = new ListItem();
                    newlist.Text = current.Text;
                    newlist.Value = current.Value;
                    ListBox2.Items.Add(newlist);
                    ListBox1.Items.Remove(ListBox1.Items[i]);
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            for (int i = ListBox2.Items.Count - 1; i >= 0; i--)
            {
                ListItem current = ListBox2.Items[i];
                if (current.Selected)
                {
                    ListItem newlist = new ListItem();
                    newlist.Text = current.Text;
                    newlist.Value = current.Value;
                    ListBox1.Items.Add(newlist);
                    ListBox2.Items.Remove(ListBox2.Items[i]);
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            List<ListItem> listlist = new List<ListItem>();
            for (int i = ListBox1.Items.Count - 1; i >= 0; i--)
            {
                ListItem current = ListBox1.Items[i];
                if (! current.Selected)
                {
                    ListItem newlist = new ListItem();
                    newlist.Text = current.Text;
                    newlist.Value = current.Value;
                    listlist.Add(newlist);
                    //ListBox2.Items.Add(newlist);
                    ListBox1.Items.Remove(ListBox1.Items[i]);
                }
            }
            if (listlist != null)
            {
                foreach (var item in listlist)
                {
                    ListBox2.Items.Add(item);
                }
            }
        }
    }
}