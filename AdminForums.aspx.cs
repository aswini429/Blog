using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public partial class AdminForums : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {

        //img1.ImageUrl = "Forum.jpg";
      
        SqlCommand cmd = new SqlCommand("select R.*,L.UserName,F.Question from ForumsReply R inner join Login L on R.LoginID=L.LoginId inner join Forums F on F.QuestionId=R.QuestionId", conn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "ForumsReplyNew");
       gridforum.DataSource = ds.Tables["ForumsReplyNew"];
       gridforum.DataBind();
    }
    protected void gridforum_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = gridforum.Rows[e.RowIndex];
        Label label = (Label)row.FindControl("lblqid");
        int eno = int.Parse(label.Text);
        SqlCommand cmd = new SqlCommand("delete ForumsReply where ReplyId=@eno", conn);
        cmd.Parameters.AddWithValue("@eno", eno);
        conn.Open();
        int i = cmd.ExecuteNonQuery();
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