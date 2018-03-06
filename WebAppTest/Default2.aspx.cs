using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebAppTest
{
    public partial class Default2 : System.Web.UI.Page
    {
        ContextModelEntity context;
        DataTable _table;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                context = new ContextModelEntity();
                if (context.StoreKeeperSet != null)
                {
                    var kepper = context.StoreKeeperSet;
                    _table = new DataTable();
                    _table.Columns.Add("Name", typeof(string));
                    _table.Columns.Add(("Quantity"), typeof(int));
                    foreach (var itemKeeper in kepper)
                    {
                        context.DitailsSet.Load();
                        if (context.DitailsSet != null)
                        {
                            var deteils = context.DitailsSet;

                            int sumDetails = 0;
                            foreach (var itemDetails in deteils)
                            {
                                if (itemDetails.StoreKeeper == itemKeeper.Id && itemDetails.DateDelete == null)
                                    sumDetails += Convert.ToInt32(itemDetails.Quantity);
                            }
                            DropDownList1.Items.Add(itemKeeper.LastFierstName);
                            DataRow myrow = _table.NewRow();
                            myrow["Name"] = itemKeeper.LastFierstName;
                            myrow["Quantity"] = sumDetails;
                            _table.Rows.Add(myrow);
                        }
                    }

                    GridView1.DataSource = _table;
                    GridView1.DataBind();
                }
            }
        }

        protected void Page_Close(object sender, EventArgs e)
        {
            context.Dispose();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {    context=new ContextModelEntity();
                if (context.StoreKeeperSet != null)
                {
                    List<string> listKeeper = new List<string>();
                    var kepper = context.StoreKeeperSet;
                    foreach (var itemKeeper in kepper)
                    {
                        listKeeper.Add(itemKeeper.LastFierstName);

                    }

                    if (!listKeeper.Contains(TextBox1.Text))
                    {
                        StoreKeeper storeKeeper = new StoreKeeper();
                        storeKeeper.LastFierstName = TextBox1.Text;
                        context.StoreKeeperSet.Add(storeKeeper);
                        context.SaveChanges();
                        Response.Redirect("Default2.aspx");
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DropDownList1.SelectedValue))
            {
                context = new ContextModelEntity();

                bool coutBool = false;
                var storeKepper = context.StoreKeeperSet
                    .Where(c => c.LastFierstName == DropDownList1.SelectedValue.ToString()).FirstOrDefault();
                var dateils = context.DitailsSet
                    .Where(c => c.StoreKeeper == storeKepper.Id).ToList();
                      
                foreach (Ditails iteDitails in storeKepper.Ditails.ToArray())
                {
                    if (iteDitails.DateDelete != null)
                    {
                        context.DitailsSet.Remove(iteDitails);
                        coutBool = true;
                    }
                }

                if (coutBool)
                {
                    context.StoreKeeperSet.Remove(storeKepper);
                    context.SaveChanges();
                  
                    Response.Redirect("Default2.aspx");
                }
                List<int> numberDetails = new List<int>();
                int count = 0;
                int count2 = 0;
                foreach (var itemDitailse in context.DitailsSet)
                {
                    if (itemDitailse.StoreKeeper == storeKepper.Id)
                    {
                        count++;
                        if (itemDitailse.DateDelete != null)
                            count2++;
                    }
                }

                if (count == count2)
                {
                    context.StoreKeeperSet.Remove(storeKepper);
                    context.SaveChanges();
                    Response.Redirect("Default2.aspx");
                }
                
            }
        }
    }
}
