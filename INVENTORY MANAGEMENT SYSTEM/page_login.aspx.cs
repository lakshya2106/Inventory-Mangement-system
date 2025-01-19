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
    public partial class page_login : System.Web.UI.Page
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
            
            if (TextBox1.Text == "Inventory" && TextBox2.Text == "1234")
                Response.Redirect("page_home.aspx");
            else
            {
                Label1.Text = "Invalid Id Password";
                TextBox1.Text = TextBox2.Text = "";
            }
                
        }
    }
}