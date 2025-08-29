using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient ;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // SQL Server connection string
            string cs = "Data Source=DESKTOP-NQE4C5H;Initial Catalog=userinfo;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "insert into userinfo values('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"')";

            SqlCommand cmd = new SqlCommand(query, con); 
           int i = cmd.ExecuteNonQuery();

            if (i > 0) 
            {
                Label1.Text = "Data inserted successfully";
                Label1.ForeColor = System.Drawing.Color.Green;
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
            }
            else
            {
                Label1.Text = "Data not inserted";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            con.Close();

        }
    }
}