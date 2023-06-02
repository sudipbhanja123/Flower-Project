using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Flower_Project
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }
        }
        DataTable dt = new DataTable();
        private void GetData()
        {
            //string Id = Request.QueryString["Id"];

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spGetAllProductDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();


        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.GetData();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string id = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text;
            string Name = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text;
            int Count = GridView1.Rows[e.RowIndex].Cells.Count;
            Response.Write(Count + "    " + id + "  " + Name);
        }
        protected void GridView1_RowCancelingEdit(object sender, EventArgs e)
        {
            GridView1.EditIndex = -1;
            this.GetData();
        }
        //protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != GridView1.EditIndex)
        //    {
        //        (e.Row.Cells[0].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";
        //    }
        //}
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.Rows[e.RowIndex].Cells[1].Text;
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spDeleteDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i > 0)
            {
                Response.Write("<script LANGUAGE='JavaScript'>alert('Delete Successful')</script>");
                GetData();
            }
            else
                Response.Write("<script LANGUAGE='JavaScript'>alert('Delete Unsuccessful')</script>");
        }
    }
}