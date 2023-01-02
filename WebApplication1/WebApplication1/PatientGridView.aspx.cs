using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class PatientGridView : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DoctorDBConnectionString"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridBind();
            }
        }

        public void GridBind()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Doctor", conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            gvDoctor.DataSource = dataTable;
            gvDoctor.DataBind();
        }

        protected void gvDoctor_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvDoctor.EditIndex = e.NewEditIndex;
            GridBind();
        }

        protected void gvDoctor_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lid = (Label)gvDoctor.Rows[e.RowIndex].FindControl("lblID");
            int id = int.Parse(lid.Text);
            SqlCommand cmd = new SqlCommand("DELETE FROM Doctor WHERE Id = '"+id+"'",conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                lblText.Text = "Deteletion Successful";
            }
            catch(Exception ex)
            {
                lblText.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            GridBind();
        }

        protected void gvDoctor_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lid = (Label)gvDoctor.Rows[e.RowIndex].FindControl("lblID");
            int id = int.Parse(lid.Text);
            TextBox txtBox1 = (TextBox)gvDoctor.Rows[e.RowIndex].FindControl("txtName");
            string name = txtBox1.Text;
            TextBox txtBox2 = (TextBox)gvDoctor.Rows[e.RowIndex].FindControl("txtHospital");
            string hospitalName = txtBox2.Text;
            SqlCommand cmd = new SqlCommand("UPDATE Doctor SET Name = '"+name+"', \"Hospital Name\" ='"+hospitalName+"'  WHERE Id = '" + id + "'", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                lblUpdateText.Text = "Update Successful";
            }
            catch (Exception ex)
            {
                lblUpdateText.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            gvDoctor.EditIndex = -1;
            GridBind();
        }

        protected void gvDoctor_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvDoctor.EditIndex = -1;
            GridBind();
        }

        protected void gvDoctor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Insert")
            {/*
                Label lid = (Label)gvDoctor.Rows[e.RowIndex].FindControl("lblID");
                int id = int.Parse(lid.Text);*/
                TextBox txtBox1 = (TextBox)gvDoctor.FooterRow.FindControl("txtName");
                string name = txtBox1.Text;
                TextBox txtBox2 = (TextBox)gvDoctor.FooterRow.FindControl("txtHospital");
                string hospitalName = txtBox2.Text;
                SqlCommand cmd = new SqlCommand("INSERT INTO Doctor (\"Name\",\"Hospital Name\") VALUES('"+name+"','"+hospitalName+"')", conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    lblUpdateText.Text = "Insert Successful";
                }
                catch (Exception ex)
                {
                    lblUpdateText.Text = ex.Message;
                }
                finally
                {
                    conn.Close();
                }
                gvDoctor.EditIndex = -1;
                GridBind();
            }
        }
    }

    
}