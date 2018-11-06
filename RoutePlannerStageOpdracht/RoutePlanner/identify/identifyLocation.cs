using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutePlanner.identify
{
    class identifyLocation
    {
        public string[,] identifyPosPerLocation(string[,] IOlist)
        {
            Database.publicFunctions GetIP = new Database.publicFunctions();
            string sqlString = "", Database = "EindOpdracht", iP = GetIP.GetIPv4Address(), gebruikersnaam = "sa", wachtwoord = "wegenbos19";

            Database.UpdateDatabase SetData = new Database.UpdateDatabase();
            OleDbCommand updateStr = new OleDbCommand();
            updateStr.CommandText = "DropWorkingTable";
            SetData.SetData(updateStr, Database, iP, gebruikersnaam, wachtwoord);
            updateStr.CommandText = "CreateWorkingTable";
            SetData.SetData(updateStr, Database, iP, gebruikersnaam, wachtwoord);

            // vult de database met de io lijst
            for (int index = 0; index < IOlist.GetLength(1); index++)
            {
                OleDbCommand fillTable = new OleDbCommand();
                fillTable.CommandText = "FillTable";
                fillTable.Parameters.AddWithValue("@Type_IO", IOlist[0 ,index]);
                fillTable.Parameters.AddWithValue("@Locatie_IO", IOlist[1 ,index]);
                SetData.SetData(fillTable, Database, iP, gebruikersnaam, wachtwoord);
            }
            // gooit alle waardes die het programma niet gebruikt uit de database
            updateStr.CommandText = "DropGarbage";
            SetData.SetData(updateStr, Database, iP, gebruikersnaam, wachtwoord);
            // haalt alle locaties uit de database
            Database.GetDatabaseData GetData = new Database.GetDatabaseData();
            sqlString = "GetLocations";
            DataTable locations = GetData.GetData(sqlString, Database, iP, gebruikersnaam, wachtwoord);
            string[,] ConnectedLocation = new string[locations.Rows.Count, 8]; //is de array die uieindelijk gereturned zal worden
            for (int i = 0; i < locations.Rows.Count; i++)
            {
                ConnectedLocation[i,0] = locations.Rows[i][0].ToString();
            }
            //haalt alle locaties uit de database die een baanmotor hebben
            sqlString = "GetBaanMotor";
            DataTable BaanMotorT = GetData.GetData(sqlString, Database, iP, gebruikersnaam, wachtwoord);
            string[] BaanMotor = new string[BaanMotorT.Rows.Count];
            for (int i = 0; i < BaanMotorT.Rows.Count; i++)
            {
                BaanMotor[i] = BaanMotorT.Rows[i][0].ToString();
            }
            //haalt alle locaties uit de database die een Afduwer hebben
            sqlString = "GetAfduwer";
            DataTable AfduwerT = GetData.GetData(sqlString, Database, iP, gebruikersnaam, wachtwoord);
            string[] Afduwer = new string[AfduwerT.Rows.Count];
            for (int i = 0; i < AfduwerT.Rows.Count; i++)
            {
                Afduwer[i] = AfduwerT.Rows[i][0].ToString();
            }
            //haalt alle locaties uit de database die een Haler hebben
            sqlString = "GetHaalbaan";
            DataTable HalerT = GetData.GetData(sqlString, Database, iP, gebruikersnaam, wachtwoord);
            string[] Haler = new string[HalerT.Rows.Count];
            for (int i = 0; i < HalerT.Rows.Count; i++)
            {
                Haler[i] = HalerT.Rows[i][0].ToString();
            }
            //haalt alle locaties uit de database die een AfduwerBinnenbaan hebben
            sqlString = "GetAfduwerBinnenbaan";
            DataTable AfduwerBinnenbaanT = GetData.GetData(sqlString, Database, iP, gebruikersnaam, wachtwoord);
            string[] AfduwerBinnenbaan = new string[AfduwerBinnenbaanT.Rows.Count];
            for (int i = 0; i < AfduwerBinnenbaanT.Rows.Count; i++)
            {
                AfduwerBinnenbaan[i] = AfduwerBinnenbaanT.Rows[i][0].ToString();
            }
            //haalt alle locaties uit de database die een HalerBinnenbaan hebben
            sqlString = "GetHalerBinnenbaan";
            DataTable HalerBinnenbaanT = GetData.GetData(sqlString, Database, iP, gebruikersnaam, wachtwoord);
            string[] HalerBinnenbaan = new string[HalerBinnenbaanT.Rows.Count];
            for (int i = 0; i < HalerBinnenbaanT.Rows.Count; i++)
            {
                HalerBinnenbaan[i] = HalerBinnenbaanT.Rows[i][0].ToString();
            }
            //haalt alle locaties uit de database die een KettingBaan hebben
            sqlString = "GetKettingBaan";
            DataTable KettingBaanT = GetData.GetData(sqlString, Database, iP, gebruikersnaam, wachtwoord);
            string[] KettingBaan = new string[KettingBaanT.Rows.Count];
            for (int i = 0; i < KettingBaanT.Rows.Count; i++)
            {
                KettingBaan[i] = KettingBaanT.Rows[i][0].ToString();
            }
            //haalt alle locaties uit de database die een AfduwerBinnenbaan2 hebben
            sqlString = "GetAfduwerBinnenbaan2";
            DataTable AfduwerBinnenbaan2T = GetData.GetData(sqlString, Database, iP, gebruikersnaam, wachtwoord);
            string[] AfduwerBinnenbaan2 = new string[AfduwerBinnenbaan2T.Rows.Count];
            for (int i = 0; i < AfduwerBinnenbaan2T.Rows.Count; i++)
            {
                AfduwerBinnenbaan2[i] = AfduwerBinnenbaan2T.Rows[i][0].ToString();
            }

            for (int i = 0; i < ConnectedLocation.GetLength(0); i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    ConnectedLocation[i, j] = "False";
                }
                for (int j = 0; j < BaanMotor.Length; j++)
                {
                    if (String.Equals(ConnectedLocation[i, 0] , BaanMotor[j]))
                    {
                        ConnectedLocation[i, 1] = "True";
                    }
                }
                for (int j = 0; j < Afduwer.Length; j++)
                {
                    if (String.Equals(ConnectedLocation[i, 0], Afduwer[j]))
                    {
                        ConnectedLocation[i, 2] = "True";
                    }
                }
                for (int j = 0; j < Haler.Length; j++)
                {
                    if (String.Equals(ConnectedLocation[i, 0], Haler[j]))
                    {
                        ConnectedLocation[i, 3] = "True";
                    }
                }
                for (int j = 0; j < AfduwerBinnenbaan.Length; j++)
                {
                    if (String.Equals(ConnectedLocation[i, 0], AfduwerBinnenbaan[j]))
                    {
                        ConnectedLocation[i, 4] = "True";
                    }
                }
                for (int j = 0; j < HalerBinnenbaan.Length; j++)
                {
                    if (String.Equals(ConnectedLocation[i, 0], HalerBinnenbaan[j]))
                    {
                        ConnectedLocation[i, 5] = "True";
                    }
                }
                for (int j = 0; j < KettingBaan.Length; j++)
                {
                    if (String.Equals(ConnectedLocation[i, 0], KettingBaan[j]))
                    {
                        ConnectedLocation[i, 6] = "True";
                    }
                }
                for (int j = 0; j < KettingBaan.Length; j++)
                {
                    if (String.Equals(ConnectedLocation[i, 0], AfduwerBinnenbaan2[j]))
                    {
                        ConnectedLocation[i, 7] = "True";
                    }
                }
            }
            int rowLength = ConnectedLocation.GetLength(0);
            int colLength = ConnectedLocation.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    //locatie + BaanMotor + Afduwer + Haler + AfduwerBinnenbaan + AfduwerBinnenbaan + HalerBinnenbaan + KettingBaan + AfduwerBinnenbaan2 +
                    Console.Write(string.Format("{0} ", ConnectedLocation[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            return ConnectedLocation;
        }
    }
}
