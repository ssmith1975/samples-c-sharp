using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Simple_SQL
{
    class Program
    {

        // Retrieves a connection string by name. 
        // Returns null if the name is not found. 
        static string GetConnectionStringByName(string name)
        {
            // Assume failure. 
            string returnValue = null;
            
            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string. 
            if (settings != null)
                returnValue = settings.ConnectionString;
           
            return returnValue;
        }

        static void Main(string[] args)
        {

            string conStr =  GetConnectionStringByName("Default");               
            string strSQL = "SELECT id, lastname, firstname, address, city, state, zip, phone, active AS isActive FROM [dbo].[authors]";                

            // SQL Connectioin
            using (SqlConnection conn = new SqlConnection(conStr ))
            {
                // create data reader object
                SqlDataReader dr = null;

                try
                {
                    // Open connection
                    conn.Open();
                   
                   // cmd.CommandType = CommandType.Text;
                    // Create command object
                    SqlCommand cmd = new SqlCommand(strSQL, conn);


                    // Get query results
                    dr = cmd.ExecuteReader();
                 

                    // Print results
                    while (dr.Read())
                    {
                        Console.WriteLine("{0}, {1}", dr["lastname"].ToString(), dr["firstname"].ToString());

                    }


                    Console.WriteLine();

                    // Create Table Schema object
                    TableSchema ts = new TableSchema( dr.GetSchemaTable() );

                    // Number of rows (table fields) in schema
                    Console.WriteLine("Row Count: {0}", ts.List.Count);
                    Console.WriteLine();

                   // Display schema data for result set
                   ts.ShowSchemaList();


                    Console.Read();

                } // end try
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.Source);
                    Console.Read();
                } // end catch
                finally
                {
                    // close the reader
                    if (dr != null)
                    {
                        dr.Close();
                    }

                    // 5. Close the connection
                    if (conn != null)
                    {
                        conn.Close();
                    }
                } // end finally



            } // end connection
        } // end Main
    } // end class
}
