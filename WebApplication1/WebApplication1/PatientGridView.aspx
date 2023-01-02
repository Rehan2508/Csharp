<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientGridView.aspx.cs" Inherits="WebApplication1.PatientGridView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:Label ID="lblText" runat="server"></asp:Label>
        <asp:Label ID="lblUpdateText" runat="server" Text="Label"></asp:Label>
    </p>
    <asp:GridView ID="gvDoctor" runat="server" AutoGenerateColumns="False" OnRowDeleting="gvDoctor_RowDeleting" OnRowEditing="gvDoctor_RowEditing" OnRowUpdating="gvDoctor_RowUpdating" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="gvDoctor_RowCancelingEdit" OnRowCommand="gvDoctor_RowCommand" ShowFooter="True">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:TemplateField HeaderText="Id">
                <EditItemTemplate>
                    <asp:Label ID="lblID" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblID" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <EditItemTemplate>
                    <asp:TextBox ID="txtName" runat="server" Text='<%# Eval("Name") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Hospital Name">
                <EditItemTemplate>
                    <asp:TextBox ID="txtHospital" runat="server" Text='<%# Eval("Hospital Name") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtHospital" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblHospital" runat="server" Text='<%# Eval("Hospital Name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Action">
                <EditItemTemplate>
                    <asp:ImageButton ID="ImageButton3" runat="server" CommandName="Update" ImageUrl="~/Images/Updating.jpg" Width="25px" />
                    <asp:ImageButton ID="ImageButton4" runat="server" CommandName="Cancel" ImageUrl="~/Images/Cancel.png" Width="25px" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:ImageButton ID="ImageButton5" runat="server" CommandName="Insert" ImageUrl="~/Images/Insert.png" Width="25px" />
                </FooterTemplate>
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton1" runat="server" CommandName="Edit" ImageUrl="~/Images/Edit.jpg" Width="25px" />
                    <asp:ImageButton ID="ImageButton2" runat="server" CommandName="Delete" ImageUrl="~/Images/Delete.jpg" Width="25px" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
</asp:Content>
