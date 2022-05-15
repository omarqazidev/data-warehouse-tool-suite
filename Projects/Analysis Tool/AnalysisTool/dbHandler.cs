using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AnalysisTool {
    class dbHandler {


        String connectionString;
        SqlConnection connection;
        SqlCommand command;
        //String textArea = "";


        private void startConnection(string conString) {

            connectionString = conString;
            connection = new SqlConnection(connectionString);

        }

        public int countRecords(String tableName, String conString) {

            startConnection(conString);
            command = connection.CreateCommand();
            command.CommandText = "select * From " + tableName;

            try {
                connection.Open();
                int result = int.Parse(command.ExecuteScalar().ToString());
                return result;

            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {

                connection.Close();
            }

            return 1;
        }


        public DataSet getInDataSet(String tableName, String conString) {

            if (countRecords(tableName, conString) > 0) {
                startConnection(conString);
                using (SqlDataAdapter adapter = new SqlDataAdapter("select * from " + tableName, connection)) {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    return ds;
                }
            } else {
                DataSet ds = new DataSet();
                return ds;
            }
        }

        public DataSet getCustomQueryInDataSet(String conString, string query) {

            connectionString = conString;
            string sqlQueryString = query;

            try {

                using (SqlConnection connectionSQL = new SqlConnection(connectionString)) {
                    connectionSQL.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQueryString, connectionSQL);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    return dataSet;
                }

            } catch (Exception e) {
                DataSet dSet = new DataSet();
                Console.WriteLine(e.Message);
                return dSet;
            }
        
        }

        
        public List<String> getColumNames(string connectionString_, string tableName) {

            List<String> columnNames = new List<String>();
            startConnection(connectionString_);
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + tableName +  "'";
            try {
               
                connection.Open();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }


            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                columnNames.Add(reader.GetString(3));
            }
            return columnNames;
        }


        

        public List<String> getDWColumNames(string connectionString_, string dwJoinsString) {

            List<String> listOfColumNames = new List<String>();
            startConnection(connectionString_);
            command = connection.CreateCommand();
            command.CommandText = dwJoinsString;
            try {
                connection.Open();
                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        listOfColumNames.Add(reader.GetString(0));
                    }
                }
                
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return listOfColumNames;
        }


        public List<String> getTableNames(string connectionString_) {

            List<String> tableNames = new List<String>();
            startConnection(connectionString_);
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM INFORMATION_SCHEMA.TABLES";

            try {
                connection.Open();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }


            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                tableNames.Add(reader.GetString(2));
            }
            return tableNames;
        }







    }
}
