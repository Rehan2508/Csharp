<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormWithMasterPage.aspx.cs" Inherits="WebApplication1.WebFormWithMasterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">

        <h1>Registration Forms</h1>
        <asp:Button ID="btnPatient" runat="server" Text="Patient" OnClick="btnPatient_Click" />
        <asp:Button ID="btnDoctor" runat="server" Text="Doctor" OnClick="btnDoctor_Click" />
        <asp:MultiView ID="RegistrationView" runat="server">
                <asp:View ID="View1" runat="server">
                    <h1>Patient Registration</h1>
                    <img src="Images/Patient.jpg" />
                    Name <asp:TextBox ID="txtPatientName" runat="server"></asp:TextBox>
                    Temperature <asp:TextBox ID="txtTemp" runat="server"></asp:TextBox>
                    <!--<asp:DropDownList ID="ddlAllergies" runat="server"></asp:DropDownList>-->
                    Allergies <asp:TextBox ID="txtAllergies" runat="server"></asp:TextBox>
                    
                    
                    <asp:DropDownList ID ="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id">
                        <asp:ListItem Selected="true" Text= "Select Allergies" Value= "-1"></asp:ListItem>
                        <asp:ListItem Text= "Pollens" Value="1"></asp:ListItem>
                        <asp:ListItem Text= "Peanuts" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                    
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ClinicDBConnectionString %>" SelectCommand="SELECT [Id], [Name] FROM [Patient]"></asp:SqlDataSource>
                    
                    <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View3" runat="server">
                        <img src="Images/Pollen.jpg" />
                    </asp:View>
                    <asp:View ID="View4" runat="server">
                        <img src="Images/Peanut.jpg" />
                    </asp:View>
                    </asp:MultiView>
                    <asp:ImageButton ID="btnPatientSubmit" src="Images/submit.jpg" runat="server" />
                </asp:View>

                <asp:View ID="View2" runat="server">
                    <h1>Doctor Registration</h1>
                    <img src="Images/Doctor.jpg" />
                     Name <asp:TextBox ID="txtDoctorName" runat="server"></asp:TextBox>
                    Hospital <asp:TextBox ID="txtHospital" runat="server"></asp:TextBox>
                    <asp:ImageButton ID="btnDoctorSubmit" src="Images/submit.jpg" runat="server" />
                </asp:View>
            
        </asp:MultiView>
        
    </div>
</asp:Content>
