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
    public partial class WebFormRetriveData : System.Web.UI.Page
    {
        SqlConnection conn= new SqlConnection(ConfigurationManager.ConnectionStrings["ClinicDBConnectionString"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Name FROM Patient", conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DropDownList1.DataSource = dataTable;
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();
            }
        }

        //user created event
        protected void btnPatient_Click(object sender, EventArgs e)
        {
            RegistrationView.Visible = true;
            RegistrationView.SetActiveView(View1);
        }

        //user created events
        protected void btnDoctor_Click(object sender, EventArgs e)
        {
            RegistrationView.Visible = true;
            RegistrationView.SetActiveView(View2);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MultiView1.Visible = true;  
            if (DropDownList1.SelectedItem.Text == "Pollens")
            {
                MultiView1.SetActiveView(View3);
            }
            else
            {
                MultiView1.SetActiveView(View4);
            }
        }
    }
}
