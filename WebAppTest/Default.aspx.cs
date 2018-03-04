using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.String;

namespace WebAppTest
{
    public partial class Default : System.Web.UI.Page
    {
        ContextModelEntity context;
        DataTable _table;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
                {
                    Path = "~/script/jquery-1.7.2.min.js",

                });
                context = new ContextModelEntity();
                if (context.DitailsSet != null)
                {
                    var details = context.DitailsSet;
                    _table = new DataTable();
                    _table.Columns.Add("NameIdCode", typeof(string));
                    _table.Columns.Add(("NameDetails"), typeof(string));
                    _table.Columns.Add(("Quantity"), typeof(int));
                    _table.Columns.Add(("NameStoreKeeper"), typeof(string));
                    _table.Columns.Add(("DateAdd"), typeof(string));
                    _table.Columns.Add(("DateDelete"), typeof(string));
                    foreach (var valueDetail in details)
                    {
                        DataRow myrow = _table.NewRow();
                        myrow["NameIdCode"] = valueDetail.NameIdCode;
                        myrow["NameDetails"] = valueDetail.NameDetails;
                        myrow["Quantity"] = valueDetail.Quantity;
                        myrow["DateAdd"] = valueDetail.DateAdd;
                        myrow["DateDelete"] = valueDetail.DateDelete;

                        context.StoreKeeperSet.Load();
                        if (context.StoreKeeperSet != null)
                        {
                            var deteils = context.StoreKeeperSet;


                            foreach (var itemDetails in deteils)
                            {
                                if (valueDetail.StoreKeeper == itemDetails.Id)
                                    myrow["NameStoreKeeper"] = itemDetails.LastFierstName;
                            }

                            _table.Rows.Add(myrow);
                        }
                    }

                    DropDownList1.Items.Clear();
                    DropDownList1.Items.Add("Выберите кладовщика");
                    DropDownList1.SelectedIndex = 0;
                    if (context.StoreKeeperSet != null)
                    {
                        foreach (var itemKeeper in context.StoreKeeperSet)
                        {
                            DropDownList1.Items.Add(itemKeeper.LastFierstName);
                        }
                    }



                    GridView1.DataSource = _table;
                    GridView1.DataBind();
                }
            }
            else
            {
                Label1.Text = DropDownList1.SelectedValue.ToString() == "Выберите кладовщика"
                    ? "Выберните кладовщика"
                    : "";


                Label2.Text = Request.Form[TextBox4.UniqueID] == "" ? "Выберите дату" : "";

               // Label3.Text = Request.Form[TextBox5.UniqueID] != "" ? "Выберите дату" : "";
            }



        }

        protected void Page_Close(object sender, EventArgs e)
        {
            context.Dispose();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue.ToString() != "Выберите кладовщика")
            {
                if (!IsNullOrEmpty(TextBox3.Text))
                {
                    if (!IsNullOrEmpty((Request.Form[TextBox4.UniqueID])))
                    {


                        if (Page.IsValid)
                        {
                            Ditails details = new Ditails();
                            DateTime dob = DateTime.Parse(Request.Form[TextBox4.UniqueID]);
                            details.DateAdd = dob;
                            details.NameIdCode = TextBox1.Text;
                            details.NameDetails = TextBox2.Text;
                            int quantity;
                            if (int.TryParse(TextBox3.Text, out quantity))
                            {
                                details.Quantity = quantity;
                            }

                            context = new ContextModelEntity();
                            if (context.StoreKeeperSet != null)
                            {
                                foreach (var storKeeper in context.StoreKeeperSet)
                                {
                                    if (storKeeper.LastFierstName == DropDownList1.SelectedValue.ToString())
                                    {
                                        details.StoreKeeper = storKeeper.Id;
                                    }
                                }

                                context.DitailsSet.Add(details);
                                context.SaveChanges();
                            }

                            Response.Redirect("Default.aspx");

                        }


                    }
                }
            }



             


        }
     

        protected void Button2_Click1(object sender, EventArgs e)
        {
            if ((!IsNullOrEmpty((Request.Form[TextBox5.UniqueID]))))
            {
                Label3.Text = "";
                context = new ContextModelEntity();
                var dstoreKepper = context.StoreKeeperSet
                    .Where(c=>c.LastFierstName== DropDownList1.SelectedValue.ToString()).FirstOrDefault();
               if (context.DitailsSet!=null)
               {
                   int num;
                   if (TextBox3 != null)
                   {
                       num = Convert.ToInt32(TextBox3.Text);


                       var details = context.DitailsSet
                           .Where(c => c.NameIdCode == TextBox1.Text)
                           .Where(c => c.NameDetails == TextBox2.Text)
                           .Where(c => c.Quantity == num)
                           .Where(c=>c.StoreKeeper==dstoreKepper.Id).FirstOrDefault();
                       DateTime dob = DateTime.Parse(Request.Form[TextBox5.UniqueID]);

                       details.DateDelete = dob;
                   }

                   context.SaveChanges();
                   Response.Redirect("Default.aspx");
                }                                                                          
            }
            else
            {
                Label3.Text = "Выберите дату";
            }
        }

     
    }

}