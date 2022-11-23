using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace LoginPage
{
    public class Class1
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();


        public Class1()
        {
            con.ConnectionString = "Data Source=.;Initial Catalog=LoginDetails;Integrated Security=True;Pooling=False";
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;

        }
        public void dbclose()
        {
            con.Close();
        }
        public object exescalar(String Sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            object ob = cmd.ExecuteScalar();
            return ob;

        }
        public int exenonquery(String Sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        public DataSet exedataset(String sql)
        {

            cmd.CommandType = CommandType.Text;  
            cmd.CommandText = sql; 
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds); 
            return ds; 
        }
        public DataTable exedatatable(String sql)
        {

            cmd.CommandType = CommandType.Text; 
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable(); 
            da.Fill(dt); 
            return dt; 
        }
        public void fillddl(string sql, DropDownList ddl,String text,String val)
        {
            ddl.DataTextField = text;
            ddl.DataValueField = val;
            ddl.DataSource = exedataset(sql);
            ddl.DataBind();

            ddl.Items.Insert(0,new ListItem("..select", "0"));
                
        }
        public void fillgrid(String sql,GridView dv)
        {
            dv.DataSource = exedataset(sql);
            dv.DataBind();

        }
        public SqlDataReader exereader(String sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        




    }
}