<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TierTwo.aspx.cs" Inherits="TwoTier.TierTwo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Employee Details"></asp:Label>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            </p>
            <p>
           <asp:Label ID="Lbl2" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
                
            </p>

            <p>
            <asp:Label ID="Lbl3" runat="server" Text="Phone"></asp:Label>
               <asp:TextBox ID="txt3" runat="server"></asp:TextBox>
              
            </p>

            <p>
                <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </p>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </center>
    </form>
</body>
</html>
