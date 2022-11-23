using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;

namespace TwoTier
{
    public class Class1
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();


        public Class1()
        {
            con.ConnectionString = "Data Source=.;Initial Catalog=Employee;Integrated Security=True;Pooling=False";
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;

        }
        public void dbclose()
        {
            con.Close();
        }
        public int exenonquery(String Sql)
        {
            Getcon();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = Sql;
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        public DataSet exedataset(String sql)
        {

            cmd.CommandType = CommandType.Text;  //SET COMMAND TYPE TEXT OR STOREPROCEDURE OR XML LIKE WISE
            cmd.CommandText = sql; //PASS SQL COMMAND TO COMMAND TEXT
            SqlDataAdapter da = new SqlDataAdapter(cmd); //CREATE ADAPTER CLASS BECAUSE DISCONNECTED ARCHITECTURE
            DataSet ds = new DataSet(); //CREATE DATASET
            da.Fill(ds); //FILL DATA TO DATASET USING ADAPTER OBJECT
            return ds; //RETURN DATASET
        }
        public DataTable exedatatable(String sql)
        {

            cmd.CommandType = CommandType.Text;  //SET COMMAND TYPE TEXT OR STOREPROCEDURE OR XML LIKE WISE
            cmd.CommandText = sql; //PASS SQL COMMAND TO COMMAND TEXT
            SqlDataAdapter da = new SqlDataAdapter(cmd); //CREATE ADAPTER CLASS BECAUSE DISCONNECTED ARCHITECTURE
            DataTable dt = new DataTable(); //CREATE DATatatble
            da.Fill(dt); //FILL DATA TO DATAtable USING ADAPTER OBJECT
            return dt; //RETURN DATAtable
        }
        public void fillgrid(String sql, GridView dv)
        {
            dv.DataSource = exedataset(sql);
            dv.DataBind();



        }
    }
}