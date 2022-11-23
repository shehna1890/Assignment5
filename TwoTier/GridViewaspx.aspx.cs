using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace TwoTier
{
    public partial class GridViewaspx : System.Web.UI.Page
    {
        Class1 db = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                // GridView1.DataSource = db.exedatatable("SELECT * FROM  Employee");
                // GridView1.DataBind();
                
                GridView1.DataSource =db.exedataset("SELECT * FROM  Employee");
                GridView1.DataBind();



            }


        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = db.exedataset("Select * from Employee");
            GridView1.DataBind();

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string Employee_Id = GridView1.DataKeys[e.RowIndex].Value.ToString();
           
            TextBox txtName = new TextBox();
            txtName = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0] ;

            TextBox txtEmail = new TextBox();
            txtEmail= (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0] ;

            TextBox txtPhone = new TextBox();
            txtPhone = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0] ;

            TextBox txtAge = new TextBox();
            txtAge = (TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0];

            db.exenonquery("update Employee set Name='" + txtName.Text + "', Email='" + txtEmail.Text + "',Phone='" + txtPhone.Text + "',Age='"+txtAge.Text+"' where Employee_Id='" + Employee_Id + "'");

            GridView1.EditIndex = -1;
            GridView1.DataSource = db.exedataset("Select * from Employee");
            GridView1.DataBind();




        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = db.exedataset("Select * from Employee");
            GridView1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            db.exenonquery("delete from employee where Employee_Id='" + id + "'");
            GridView1.DataSource = db.exedataset("Select * from Employee");
            GridView1.DataBind();


        }
        //MULTIPLE delete
        protected void Button1_Click(object sender, EventArgs e)
        {
            HtmlInputCheckBox chk;
            foreach (GridView dr in GridView1.Rows)
            {
                chk = (HtmlInputCheckBox)dr.FindControl("ch");
                if(chk.Checked)
                {
                    db.exenonquery("delete from Employee where empid =" + chk.Value+ "");

                }
            }
            db.fillgrid("Select * from Employee" ,GridView1);

        }
    }
}