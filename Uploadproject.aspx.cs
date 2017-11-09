using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;
using BusinessLogicLayer;
using DataacessLayer;

public partial class Uploadproject : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());

    Businesslogic Bal = new Businesslogic();
    Entity entity = new Entity();
    int id = 0;


    protected void Page_Load(object sender, EventArgs e)
    {



        entity.ProjectId = Bal.AutoProjectId(); 
        HttpCookie cookie = Request.Cookies["Users"];
        if (cookie != null)
        {
            id = Convert.ToInt32(cookie["id"].ToString());

        }
        else
        {
            Response.Redirect("Login.aspx", false);
        }

        
    }

    protected void btnupload_Click(object sender, EventArgs e)
    {
        //var a = txtprojecttype.Text;



        string filename = "";
        if (Flupload.HasFile)
        {
            filename = Path.GetFileName(Flupload.FileName);
            Flupload.SaveAs(Server.MapPath("~/Data/") +Flupload.FileName);

        }


      
        entity.LoginId = Convert.ToInt32(id);
           

        entity.ProjectType = txtprojecttype.Text;
        entity.FileType = System.IO.Path.GetExtension(this.Flupload.PostedFile.FileName); ;
        entity.FileName = filename;
        
       

        int res = Bal.SaveProject(entity);
        if (res >= 0)
        {
            lblmsg.Text = "file uploaded";
        }

        else
        {
            lblmsg.Text = "not uploaded";
        }

    }
}