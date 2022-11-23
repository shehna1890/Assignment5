<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewaspx.aspx.cs" Inherits="TwoTier.GridViewaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center"class="auto-style">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
    
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Employee_ID" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting"  >
                            <Columns>
                                 <asp:TemplateField>
                                     <ItemTemplate>
                                         <input type="checkbox" runat="server" name="ch" id="ch" value='<%#Eval("Employee_Id") %>' />
                                     </ItemTemplate>
                                 </asp:TemplateField>
                               
                                <asp:BoundField DataField="Name" HeaderText="Employee Name" />
                                <asp:BoundField DataField="Email" HeaderText="Email" />
                                <asp:BoundField DataField="Phone" HeaderText="Phone" />
                                 <asp:BoundField DataField="Age" HeaderText="Age" />
                                <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                                <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                                
                                 <asp:HyperLinkField DataNavigateUrlFields="Name" DataNavigateUrlFormatString="test.aspx?Name={0}" HeaderText="View More" Text="Go" />
                                
                            </Columns>
                            </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp</td>
                    <td>&nbsp</td>
    
    
                </tr>

            </table>
            <center>
                <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />

            </center>
            

        </div>
    </form>
</body>
</html>
