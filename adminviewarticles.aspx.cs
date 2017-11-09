using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class adminviewarticles : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
    
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select A.*,L.UserName from Article A inner join Login L on A.LoginId=L.LoginId", conn);
        //cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "ArticleNew");
        gridarticle.DataSource = ds.Tables["Articlenew"];
        gridarticle.DataBind();

    }
    public int DeleteId(int id)
    {
        SqlCommand cmd = new SqlCommand("ARticle_Delete", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ArticleId", id);
        conn.Open();
        int i = cmd.ExecuteNonQuery();
        conn.Close();
        return i;
    }
    protected void linnkdelete_Click(object sender, EventArgs e)
    {
        
        LinkButton Linkdelete = (LinkButton)sender;
        //SqlCommand cmd;
        int i = DeleteId(Convert.ToInt32(Linkdelete.CommandArgument));

        if (i == 1)
        {
            
            lblmsg.Text = "record deleted";
        }
        else
        {
            lblmsg.Text = "not deleted";
        }
    }
}