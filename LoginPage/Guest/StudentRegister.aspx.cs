using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage.Guest
{
    public partial class StudentRegister : System.Web.UI.Page
    {
      Class1 db = new Class1();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                
                for (int i = 1; i <= 31; i++)
                {
                    ddlday.Items.Add(i.ToString());

                }
                for (int i = 1; i <= 12; i++)
                {
                    ddlmonth.Items.Add(i.ToString());

                }
                for (int i = 1980; i <= DateTime.Now.Year; i++)
                {
                    ddlyear.Items.Add(i.ToString());

                }

            }   
            

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            
            
            object ob = db.exescalar("insert into Login values('" + user.Text + "','" + pwd.Text + "','" + Textbox1.Text + "','Student','Not Confirmed');select @@IDENTITY");
            db.dbclose();
            if (ob.ToString() != null)
            {
                string DOB = ddlday.SelectedValue + "/" + ddlmonth.SelectedValue + "/" + ddlyear.SelectedValue ;
                int i = db.exenonquery("insert into Student_Table values('" + name.Text + "','" + email.Text + "','" + mobile.Text + "','" + RadioButtonList1.Text + "','" + ddlCourse.SelectedValue + "','" + DOB + "',"+ob+")");
                db.dbclose();
                if (i == 1)
                {
                    Response.Write("Success...");

                }
                else
                {
                    Response.Write("Failed....");
                }
            }
            name.Text = "";
            email.Text = "";
            mobile.Text = "";
            RadioButtonList1.ClearSelection();
            ddlCourse.ClearSelection();
            ddlday.ClearSelection();
            ddlmonth.ClearSelection();
            ddlyear.ClearSelection();
            ddlCourse.ClearSelection();
            user.Text = "";
            pwd.Text = "";
            Textbox1.Text = "";


        }



        
        
    }
}

