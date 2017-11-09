using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using BusinessLogicLayer;
using DataacessLayer;
public partial class PostQuery : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
    Businesslogic Bal = new Businesslogic();
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        image1.ImageUrl = "~/Images/Postquery.jpg";
        HttpCookie cookie = Request.Cookies["Users"];
        if (cookie != null)
        {
            id = cookie["id"].ToString();
        }
        else
        {
            Response.Redirect("Login.aspx", false);
        }
    }
    

   
    protected void btnpost_Click(object sender, EventArgs e)
    {

       // dataacess da = new dataacess();
        Entity entity = new Entity();
        Businesslogic bal=new Businesslogic();
        string Question = txtquestion.Text;
        entity.LoginId = Convert.ToInt32(id);
       
       entity.Question = Question;
       int i=Bal.SaveForums(entity);
        if (i == 1)
        {
            lblmsg.Text = "question posted";
        }
        else
        {
            lblmsg.Text = "not posted";
        }
        
    }
}