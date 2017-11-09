using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Security;
using System.Web.SessionState;

public partial class ViewAllQuestions : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        image1.ImageUrl = "~/Images/Forum.jpg";

        SqlCommand cmd = new SqlCommand("As_ViewQuestions", conn);
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        da.Fill(ds,"ForumsNew");
        GridForums.DataSource = ds.Tables["ForumsNew"];
        GridForums.DataBind();
      }



    
    protected void gridforums_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

        
        GridViewRow row = GridForums.Rows[e.NewSelectedIndex];
        Label label1 = (Label)row.FindControl("lblQuestionId");
        Session["Id"] = label1.Text;
        Label label = (Label)row.FindControl("lblQuestion");
       //string  name = GridForums.SelectedRow.Cells[1].Text;
         Session["Name"] = label.Text;
        Response.Redirect("ReplyForums.aspx");

    }
}
