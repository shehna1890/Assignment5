<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="FacultyRegistration.aspx.cs" Inherits="LoginPage.Guest.FacultyRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>            
                
                <tr>
                    <td>Name:</td><td> <asp:textbox id="txt2" runat="server" ></asp:textbox></td>
                    <td><asp:RequiredFieldValidator ID="validlname" runat="server" ControlToValidate="txt2" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
               
                <tr>
                    <td>Email:</td><td><asp:TextBox ID="email" runat="server" TextMode="Email" ></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="validemail" runat="server" ControlToValidate="email" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                     <td> <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Email ID" ControlToValidate="email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
                </tr>
                <tr>
                    <td>Mobile:</td><td><asp:TextBox ID="mobile" runat="server" TextMode ="Phone"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="mobile" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    <td><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="mobile" ErrorMessage="Enter a 10 digit phone number" ValidationExpression="[0-9]{10}" ForeColor="Red" ></asp:RegularExpressionValidator>
                </tr>
                <tr>                    
                    <td>Gender:</td><td><asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem Text="Male"> </asp:ListItem>
                        <asp:ListItem Text="Female" ></asp:ListItem>
                                             </asp:RadioButtonList></td>
                </tr>
                <tr>
                    <td>DOB: </td>
                    <td>D

                    <asp:DropDownList ID="ddlday" runat="server"></asp:DropDownList>
                    &nbsp;M<asp:DropDownList ID="ddlmonth" runat="server"></asp:DropDownList>
                     &nbsp;Y<asp:DropDownList ID="ddlyear" runat="server"></asp:DropDownList>
                   
                    </td>

                </tr>                
              
                 <tr>
                    <td>User Name:</td><td> <asp:textbox id="user" runat="server"></asp:textbox></td>
                    <td><asp:RequiredFieldValidator ID="validuser" runat="server" ControlToValidate="user" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Password:</td><td><asp:textbox ID="pwd" runat="server" TextMode="Password"></asp:textbox></td>
                    <td><asp:RequiredFieldValidator ID="validpwd" runat="server" ControlToValidate="pwd" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Confirm Password:</td><td><asp:textbox ID="Textbox1" runat="server" TextMode="Password"></asp:textbox></td>
                </tr>
               <tr>
                    <td><asp:Button ID="btn1" runat="server" Text="Submit" OnClick="btn1_Click"></asp:Button></td>
                  
                </tr>                
            </table>
</asp:Content>
