using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebFormWithMasterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            if(DropDownList1.SelectedItem.Text == "Pollens")
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