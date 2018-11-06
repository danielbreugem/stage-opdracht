using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace RoutePlanner.identify.Database
{
    public class UpdateDatabase
    {
        public void SetData(OleDbCommand updateStr, string Catalog, string iP, string gebruikersnaam, string wachtwoord)
        {
            OleDbConnection connection = new OleDbConnection("Data Source=" + iP + ";Initial Catalog=" + Catalog + ";User ID=" + gebruikersnaam + ";Password=" + wachtwoord + ";Provider=SQLOLEDB;");
            try
            {
                // maak verbinding met de database en kopel de connectie aan de command
                connection.Open();
                updateStr.Connection = connection;
                // checkt of het een procedure of een query is
                if (updateStr.CommandText.Contains(" "))
                    updateStr.CommandType = CommandType.Text;
                else
                    updateStr.CommandType = CommandType.StoredProcedure;
                updateStr.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Fetch Error:";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
