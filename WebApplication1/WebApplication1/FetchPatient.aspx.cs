using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class FetchPatient : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ClinicDBConnectionString"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDDl();
                BindGridView();
            }
        }

        public void BindGridView()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Patient", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }

        public void BindDDl()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Name FROM Patient",conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ddlPatient.DataSource = dt;
            ddlPatient.DataTextField = "name";
            ddlPatient.DataValueField = "id";
            ddlPatient.DataBind();
        }

        protected void ddlPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(ddlPatient.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Patient WHERE Id ='" + id + "'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Patient p = new Patient()
            {
                Id = id,
                Name = dt.Rows[0]["name"].ToString(),
                allergies = dt.Rows[0]["Ailment"].ToString()
            };
            lblPatient.Text = p.Id + " | " + p.Name + " | +" + p.allergies;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Patient",conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            BindGridView();
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lid = (Label)GridView2.Rows[e.RowIndex].FindControl("lblID");
            int id = int.Parse(lid.Text);
            SqlCommand cmd = new SqlCommand("DELETE FROM Patient WHERE Id = '" + id + "'", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                lblShow.Text = "The record is deleted successfully";
            }
            catch (Exception ex)
            {
                lblShow.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            BindGridView();
        }
    }
}