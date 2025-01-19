using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace INVENTORY_MANAGEMENT_SYSTEM
{
    public partial class page_serch_customer : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=KANISHK\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select * from customer where cid=" + TextBox1.Text + "";
            da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                Label5.Text = "record not found";
                Label1.Text = Label2.Text = Label3.Text = Label4.Text = " ";
            }
            else
            {
                Label1.Text = ds.Tables[0].Rows[0][0].ToString();
                Label2.Text = ds.Tables[0].Rows[0][1].ToString();
                Label3.Text = ds.Tables[0].Rows[0][2].ToString();
                Label4.Text = ds.Tables[0].Rows[0][3].ToString();
            }
        }
    }
}