using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;
using System.Web.Services;
using DataacessLayer;
using BusinessLogicLayer;

public partial class Login : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //SqlCommand cmd = new SqlCommand("ST_Login", conn);
        string UserName = txtuname.Text;
        string Password = txtpwd.Text;
        Businesslogic BAL = new Businesslogic();
        //SqlCommand cmd = new SqlCommand("select count (*) from Login where UserName=@UserName and Password=@Password", conn);
        int i = BAL.Login(UserName, Password);

        if (i >= 0)
        {
            //    FormsAuthentication.RedirectFromLoginPage(UserName, checkremeberme.Checked);
            //    Response.Redirect("UserHome.aspx");
            HttpCookie cookie = new HttpCookie("Users");
            cookie["id"] = i.ToString();           
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("UserHome.aspx");

        }
        else
        {
            lblmsg.Text = "invalid user";
        }
    }

}