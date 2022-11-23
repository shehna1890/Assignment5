using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage.Admin
{
    public partial class ConfirmFaculty : System.Web.UI.Page
    {
        Class1 db = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                db.fillgrid("select s.*,l.* from Faculty s inner join Login l on s.lid=l.lid where l.status='Not Confirmed'", GridView1);
            }


        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string s = GridView1.DataKeys[e.RowIndex].Value.ToString();
            db.exenonquery("update Login set status='Confirmed' where lid =" + s + "");
            db.fillgrid("select s.*,l.* from Faculty s inner join Login l on s.lid=l.lid where l.status='Not Confirmed'", GridView1);
            
            
        }
    }
}