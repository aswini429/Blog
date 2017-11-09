using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class ViewAnswers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        img1.ImageUrl = "~/Images/Forum.jpg";
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
        SqlCommand cmd = new SqlCommand("As_ViewForums", conn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "ForumsReplyNew");
      gridanswers.DataSource = ds.Tables["ForumsReplyNew"];
      gridanswers.DataBind();
    }
   
}