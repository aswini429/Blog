using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BusinessLogicLayer;
using DataacessLayer;
public partial class PostSrticle : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
    Businesslogic Bal = new Businesslogic();
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        img1.ImageUrl = "~/Images/articlepost.jpg";
        int articleid = Bal.ArticleId();
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
        Entity entity = new Entity();
        entity.ArticleType = txttype.Text;
        entity.ArticleDesc = txtdesc.Text;
        entity.LoginId = Convert.ToInt32(id);
        int i = Bal.SaveArticles(entity);
        
        if (i >=0)
        {
            lblmsg.Text = "article inserted";
        }
        else
        {
            lblmsg.Text = "no article";
        }
    }
}