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

public partial class ReplyForums : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
    Businesslogic Bal = new Businesslogic();
    string id = "";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        image1.ImageUrl = "~/Images/Forum.jpg";
      lblquestion.Text = Session["Name"].ToString();
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
    protected void btnPost_Click(object sender, EventArgs e)
    {
        //int questionid = AutoQuetstionId();
        Entity entity = new Entity();
        entity.QuestionId = Convert.ToInt32(Session["Id"]);
        entity.Reply = txtanswer.Text;
        entity.LoginId = Convert.ToInt32(id);
        int i=Bal.ReplyForums(entity);
        if (i >= 0)
        {
            lblmsg.Text = "reply posted";
        }
        else
        {
            lblmsg.Text = "not posted";
        }

    }
}