using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DBConnect
    {//xong rồi đúng ko :") ko :)) sao ko vô dc database kìa
        string connect = "Data Source= DESKTOP-BOPPJ92;" +
             "Initial Catalog=QUANLIPHUOT;" +
             "Integrated Security = True";
        //   string connect = "Data Source=DESKTOP-BOPPJ92;Initial Catalog=QUANLIDOPHUOT;Integrated Security=True";


        public SqlDataAdapter myAdapter;
        public  static SqlConnection conn;

        public DBConnect()
        {
            conn = new SqlConnection(connect);
        }

        public SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public SqlConnection closeConnection()
        {
            if (conn.State == ConnectionState.Open )
            {
                conn.Close();
            }
            return conn;
        }

        public DataTable executeSelectQuery(string _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            myAdapter = new SqlDataAdapter();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException )
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        public int ExScarlar(string sQuery, SqlParameter[] sqlParameter)//dùng để làm gì
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = sQuery;
                myCommand.Parameters.AddRange(sqlParameter);

                int a = (int)myCommand.ExecuteScalar();
                conn.Close();
                return a;


            }
            catch (Exception x)
            {

                return -1;
            }
        }

        public bool executeInsertQuery(string _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            myAdapter = new SqlDataAdapter();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (Exception X)
            {
                Console.WriteLine(X.Message);
                return false;
            }
            finally
            {
            }
            return true;
        }

        public bool executeUpdateQuery(string _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException )
            {
                return false;
            }
            finally
            {
            }
            return true;
        }

        public bool executeDeleteQuery(string _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.DeleteCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
            }
            return true;
        }
    }
}
