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
using ClosedXML.Excel;
public partial class Viewprojects : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
    Businesslogic bal = new Businesslogic();
    Entity entity = new Entity();
    internal void Binde()
    {
        SqlCommand cmd = new SqlCommand("GetProjects", conn);
        //cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "Projectnew");
        gridprojects.DataSource = ds.Tables["ProjectNew"];
        gridprojects.DataBind();
        // ViewState["List"] = ds.Tables["ProjectNew"];
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Binde();
        }

    }
    protected void linksearch_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("AS_ProjectSearch", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ProjectType", txtserach.Text);

        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter();
        gridprojects.DataSource = cmd.ExecuteReader();
        gridprojects.DataBind();
        conn.Close();
    }
    internal int getprojectid(string file)
    {
        SqlCommand cmd=new SqlCommand("select ProjectId from Projects where filename='"+file+"'and LoginId='"+Convert.ToString(Session["UserName"])+"'",conn );
        conn.Open();
        int id = (int)cmd.ExecuteScalar();
        conn.Close();
        return id;
    }

    protected void linkdownload_Click(object sender, EventArgs e)
    {
       
        //string filename = gridprojects.DataKeys[row.RowIndex].Value.ToString();
        //Label pid = (Label)row.FindControl("lblpid");
        //int id = getprojectid(filename);
        //SqlCommand cmd = new SqlCommand("select FileType,FileName from Project where ProjectType=@Projectype", conn);
        //cmd.Parameters.AddWithValue("@Projecttype", pid.Text);
        //conn.Open();
        //SqlDataReader dr = cmd.ExecuteReader();
        //if (dr.Read())
        //{
        //    Response.ContentType = dr["FileType"].ToString();
        //    Response.AddHeader("content-Disposition", "attchment;filename=\""+dr["FileName"]);
        //    Response.BinaryWrite((byte[])dr["FileData"]);
        //    Response.End();

            //Response.TransmitFile(Server.MapPath("~/DownLoadedData/"));
        }
    protected void gridprojects_SelectedIndexChanged(object sender, EventArgs e)
{
        SqlCommand cmd=new SqlCommand("Select FileName,FileType from Project where ProjectType=@pid",conn);
        cmd.Parameters.AddWithValue("@pid", gridprojects.SelectedRow.Cells[1].Text);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            //Response.Buffer = true;
            Response.ContentType = dr["FileType"].ToString();
            Response.AddHeader("content-Disposition", "attachment;filename=" + dr["FileName"].ToString());
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.BinaryWrite((byte[])dr["FileData"]);
            Response.End();
        }

       
}

    protected void btnDownload_Click(object sender, EventArgs e)
    {
        List<Entity> list = new List<Entity>();

        try
        {
            SqlCommand cmd = new SqlCommand("GetProjects", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            using (SqlDataReader sr = cmd.ExecuteReader())
            {
                while (sr.Read())
                {
                    Entity et = new Entity
                    {
                        LoginId = Convert.ToInt32(sr["LoginId"]),
                        ProjectType = sr["ProjectType"].ToString(),
                        FileType = sr["FileType"].ToString(),
                        FileName = sr["FileName"].ToString(),
                        UserName=sr["UserName"].ToString()
                    };
                    list.Add(et);
                }
                conn.Close();
            }
            if (list.Count > 0)
            {

                DataTable dt = new DataTable();

                dt.Columns.Add("ProjectType");

                dt.Columns.Add("FileName");

                dt.Columns.Add("FileType");

                dt.Columns.Add("PostedBy");



                for (int i = 0; i < list.Count; i++)
                {

                    dt.Rows.Add(list[i].ProjectType != "" ? list[i].ProjectType : "NA", list[i].FileType != "" ? list[i].FileType : "NA", list[i].FileName != "" ? list[i].FileName : "NA", list[i].UserName != "" ? list[i].UserName : "NA");

                }



                ExporttoExcel(dt, "ProjectsList");

            }

        }


        catch (Exception ex)
        {

            throw ex;

        }

    }

    private void ExporttoExcel(DataTable table, string sheetName)
    {

        try
        {

            using (XLWorkbook wb = new XLWorkbook())
            {

                wb.Worksheets.Add(table, sheetName);



                Response.Clear();

                Response.Buffer = true;

                Response.Charset = "";

                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

                Response.AddHeader("content-disposition", "attachment;filename=" + sheetName + ".xlsx");

                using (MemoryStream MyMemoryStream = new MemoryStream())
                {

                    wb.SaveAs(MyMemoryStream);

                    MyMemoryStream.WriteTo(Response.OutputStream);

                    Response.Flush();

                    Response.End();

                }

            }

        }

        catch (Exception ex)
        {

            throw ex;

        }



    }
}