using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.Emit;

namespace INVENTORY_MANAGEMENT_SYSTEM
{
    public partial class page_new_customer : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=KANISHK\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            string s = "select cid from customer order by cid desc";
            da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
                TextBox1.Text = "501";
            else
                TextBox1.Text = (Convert.ToInt32(ds.Tables[0].Rows[0][0]) + 1).ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "insert into customer values(" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "'," + TextBox4.Text + ")";
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            TextBox2.Text = TextBox3.Text = TextBox4.Text = " ";
            TextBox1.Focus();

            Label1.Text = "RECORD INSERTED";
            TextBox1.Text = (Convert.ToInt32(TextBox1.Text) + 1).ToString();


        }
    }
}