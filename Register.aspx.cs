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

public partial class Register : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        Entity entity=new Entity();
        entity.LoginId =Convert.ToInt32(lblid.Text);
        entity.Name=txtname.Text;
        entity.UserName=txtuname.Text;
        entity.Password=txtpwd.Text;
        entity.SecQuestion=dropdownsecurity.SelectedValue;
        entity.Answer=txtanswer.Text;
        entity.Status = "approved";

        Businesslogic BAL = new Businesslogic();
        

        int i = BAL.Register(entity);
        if (i==1)
        {
            lblmsg.Text = "details added";
            Response.Redirect("Login.aspx");

        }
        else
        {
            lblmsg.Text = "invalid details";
        }
    }
}