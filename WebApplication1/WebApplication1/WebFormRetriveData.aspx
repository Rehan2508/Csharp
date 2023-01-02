<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormRetriveData.aspx.cs" Inherits="WebApplication1.WebFormRetriveData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <h1>Registration Forms</h1>
        <asp:Button ID="btnPatient" runat="server" Text="Patient" OnClick="btnPatient_Click" />
        <asp:Button ID="btnDoctor" runat="server" Text="Doctor" OnClick="btnDoctor_Click" />
        <asp:MultiView ID="RegistrationView" runat="server">
                <asp:View ID="View1" runat="server">
                    <h1>Patient Registration</h1>
                    <img src="Images/Patient.jpg" width="100" /><br />
                    Name <asp:TextBox ID="txtPatientName" runat="server"></asp:TextBox><br />
                    Temperature <asp:TextBox ID="txtTemp" runat="server"></asp:TextBox><br />
                    Allergies <asp:TextBox ID="txtAllergies" runat="server"></asp:TextBox><br />
                    
                    
                    <asp:DropDownList ID ="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem Selected="true" Text= "Patient Name" Value= "-1"></asp:ListItem>
                    </asp:DropDownList>
                    
                    
                    <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View3" runat="server">
                    </asp:View>
                    <asp:View ID="View4" runat="server">
                    </asp:View>
                    </asp:MultiView>
                    <asp:ImageButton ID="btnPatientSubmit" src="Images/submit.jpg" runat="server" Height="50px" Width="100px" />
                </asp:View>

                <asp:View ID="View2" runat="server">
                    <h1>Doctor Registration</h1>
                    <img src="Images/Doctor.jpg" height="100" /><br />
                     Name <asp:TextBox ID="txtDoctorName" runat="server"></asp:TextBox><br />
                    Hospital <asp:TextBox ID="txtHospital" runat="server"></asp:TextBox><br />
                    <asp:ImageButton ID="btnDoctorSubmit" src="Images/submit.jpg" runat="server" Height="50px" />
                </asp:View>
            
        </asp:MultiView>
        
    </div>
</asp:Content>
