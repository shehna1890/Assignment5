using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        Class1 db = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "Admin" & TextBox2.Text == "Admin")
            {
                Response.Redirect("/Admin/AdminPage.aspx"); 
            }
            else checked
            {
                TextBox1.Text = "Select * from Login where  Username ='"  + "'and status ='Confirmed'";
                TextBox2.Text = "Select * from Login where password = '" + "' and status ='Confirmed'";
                Response.Redirect("/Student/StudentHome.aspx");








            }
        }
    }
}


            
            
            

            
            
            
    


