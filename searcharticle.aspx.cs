using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class searcharticle : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
    internal void bind()
    {
        //SqlCommand cmd = new SqlCommand("select F.*,L.UserName from Forums F inner join Login L on F.LoginID=L.LoginId", conn);
        SqlCommand cmd = new SqlCommand("As_ViewArticle", conn);
       
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds,"ArticleNew");
        gridview1.DataSource = ds.Tables["ArticleNew"];
        gridview1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        img1.ImageUrl = "~/Images/searchartcile.jpg";
        if (!IsPostBack)
        {
            bind();
        }

    }
    
    protected void link1_Click(object sender, EventArgs e)
    {
       //int id=gridview1.DataKeys[]
        //string id=(txtarticletype).ToString();
        SqlCommand cmd = new SqlCommand("A_SearchArticle", conn);
       cmd.CommandType = CommandType.StoredProcedure;
       cmd.Parameters.AddWithValue("@ArticleType", txtarticletype.Text);
        DataSet ds=new DataSet();
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        gridview1.DataSource = cmd.ExecuteReader();
        gridview1.DataBind();

        
    }
}