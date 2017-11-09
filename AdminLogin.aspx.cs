using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class AdminLogin : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
       // string UserName;
        //string Password;
        SqlCommand cmd = new SqlCommand("As_Admin ", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            txtuname.Text = dr["UserId"].ToString();
            txtpwd.Text = (dr["Password"]).ToString();
            Response.Redirect("AdminHome.aspx");
        }
        conn.Close();
       

    }
}