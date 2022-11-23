using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwoTier
{
    public partial class test : System.Web.UI.Page
    {
        Class1 db = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //string _Id = Request.QueryString["Id"].ToString();
                //DataTable dt = db.exedatatable("Select * from Employee where Employee_Id='" + _Id + "'");
                //Label1.Text = dt.Rows[0]["Employee Name"].ToString();
                //Label2.Text = dt.Rows[1]["Designation"].ToString();
                //Label1.Text = dt.Rows[2]["Salary"].ToString();

                Label1.Text= Request.QueryString["Name"];


            }

        }
    }
}