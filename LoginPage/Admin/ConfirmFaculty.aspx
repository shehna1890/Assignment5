<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ConfirmFaculty.aspx.cs" Inherits="LoginPage.Admin.ConfirmFaculty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table  align="center"class="auto-style">
       
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
    
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="lid" OnRowDeleting="GridView1_RowDeleting">
                            <Columns>
                                <asp:BoundField DataField="Name" HeaderText="Name" />
                                <asp:BoundField DataField="Email" HeaderText="Email" />
                                <asp:BoundField DataField="Gender" HeaderText="Gender" />
                                <asp:CommandField DeleteText="Confirm" HeaderText="Status" ShowDeleteButton="True" />
                            </Columns>
                        </asp:GridView>
                        

    </table>

</asp:Content>
