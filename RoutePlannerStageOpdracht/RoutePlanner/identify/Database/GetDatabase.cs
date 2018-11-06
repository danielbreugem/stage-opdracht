using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RoutePlanner.identify.Database
{
    public class GetDatabaseData
    {
        public DataTable GetData(string sqlString, string Catalog, string iP, string gebruikersnaam, string wachtwoord)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection("Data Source=" + iP + ";Initial Catalog=" + Catalog + ";User ID=" + gebruikersnaam + ";Password=" + wachtwoord + ";");

            try
            {
                // maak verbinding met de database en kopel de de connectie aan de command
                connection.Open();
                SqlCommand sqlCmd = new SqlCommand(sqlString);
                sqlCmd.Connection = connection;
                // checkt of het een procedure of een query is
                if (sqlCmd.CommandText.Contains(" "))
                    sqlCmd.CommandType = CommandType.Text;
                else
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
                sqlDa.Fill(dt);
            }
            catch (SqlException ex)
            {
                string msg = "Fetch Error:";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
    }

}
