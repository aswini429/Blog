using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class AdminProjects : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select P.*,L.UserName from Project P inner join Login L on P.LoginID=L.LoginId", conn);
        //cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "Projectnew");
        gridprojects.DataSource = ds.Tables["ProjectNew"];
        gridprojects.DataBind();
    }

    protected void gridprojects_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = gridprojects.Rows[e.RowIndex];
        Label label = (Label)row.FindControl("lblid");
        int eno=int.Parse(label.Text);
        SqlCommand cmd = new SqlCommand("delete Project where ProjectId=@eno",conn);
        cmd.Parameters.AddWithValue("@eno", eno);
        conn.Open();
        int i=cmd.ExecuteNonQuery();
        conn.Close();
        if (i == 1)
        {
            lblmsg.Text = "record deleted";
        }
        else
        {
            lblmsg.Text = "record not deleted";
        }

    }
}