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
    public partial class page_all_customer : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=KANISHK\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            string s = "select * from customer";
            da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
}