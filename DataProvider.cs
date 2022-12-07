using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuexe
{
    public class DataProvider
    {
        public string connectionSTR = @"Data Source=DUNK\SQLEXPRESS;Initial Catalog=Quanlythuexe;Integrated Security=True";
        public DataProvider()
        {
        }
        public void ExecuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);            
            connection.Open();
            SqlCommand command = new SqlCommand(query,connection);

            command.ExecuteNonQuery();
            connection.Close();
                      
        }
        public DataTable ExecuteQuery_loaddata(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatb = new DataTable();
            SqlConnection connection = new SqlConnection(connectionSTR);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            datatb.Clear();
            adapter.Fill(datatb);
            connection.Close();
            return datatb;
        }
        public DataTable ExecuteQuery_CBox(string query,string needAdd)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable datatb = new DataTable();
            datatb.Columns.Add(needAdd, typeof(string));
            datatb.Load(reader);
            connection.Close();
            return datatb;
        }
        public DataTable ExecuteQuery_TBox(string query)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();           
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable datatb = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datatb);
            connection.Close();
            return datatb;
        }
    }
}