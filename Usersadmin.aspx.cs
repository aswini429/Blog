using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Usersadmin : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
    internal void changestatus()
    {
        foreach (GridViewRow row in gridusers.Rows)
        {
            LinkButton link = (LinkButton)row.FindControl("linkstatus");
            if (link.Text == "pending")
            {
                link.Text = "approve";
            }
            else if (link.Text == "Enable")
            {
                link.Text = "Block";
            }
            else
            {
                link.Text = "Blocked";
            }
        }
    }
    internal void bind()
    {
        SqlCommand cmd = new SqlCommand("GetLoginDetails", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "LoginNew");
        gridusers.DataSource = ds.Tables["LoginNew"];
        gridusers.DataBind();
    
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            bind();
            changestatus();
        }
        }
    protected void gridusers_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "mystatus")
        {
            string status = null;
            int id = 0;
            string udate = null;
            id = Convert.ToInt32(e.CommandArgument);
            SqlCommand cmd = new SqlCommand("select Status from Login where LoginId='"+id+"'", conn);
            conn.Open();
            status = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            if (status == "pending")
            {
                udate = "enable";
            }
            else
                if (status == "enable")
                {
                    udate = "disable";

                }
                else
                {
                    udate = "block";
                }
            cmd = new SqlCommand("Update Login set Status=udate where LoginId=id", conn);
            conn.Open();
            int i=cmd.ExecuteNonQuery();
            conn.Close();
            bind();
            changestatus();

        }
    }
}