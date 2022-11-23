using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwoTier
{
    public partial class TierTwo : System.Web.UI.Page
    {
        Class1 db = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Employee Values('" + TextBox1.Text + "','" + txt2.Text + "','" + txt3.Text + "','" + TextBox3.Text + "')";
            int i = db.exenonquery(sql);
            if(i==1)
            {
                Response.Write("Successfully Inserted");
            }
            else
            {
                Response.Write("Insertion Failed");
            }
        }
    }
}