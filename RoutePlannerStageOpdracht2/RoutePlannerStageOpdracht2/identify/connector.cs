using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutePlanner.identify
{
    class connector
    {
        public string[,] ConnectLocation(string[,] IdentifiedList)
        {
            //setup the database connection
            Database.publicFunctions GetIP = new Database.publicFunctions();
            string sqlString = "", Database = "EindOpdracht", iP = GetIP.GetIPv4Address(), gebruikersnaam = "sa", wachtwoord = "wegenbos19";
            Database.GetDatabaseData GetData = new Database.GetDatabaseData();
            //get the IOlist
            sqlString = "GetIolist";
            DataTable GetIolistT = GetData.GetData(sqlString, Database, iP, gebruikersnaam, wachtwoord);
            string[] GetIolist = new string[GetIolistT.Rows.Count];
            for (int i = 0; i < GetIolistT.Rows.Count; i++)
            {
                GetIolist[i] = GetIolistT.Rows[i][0].ToString();
            }
            //translate the possibilities per node to the connections per node
            string[,] ConnectedLocation = new string[IdentifiedList.GetLength(0), 3];//geheugen plek 1 is voor de locatie, geheugen plek 2 is voor sturen van bakken, geheugen plek 3 is voor het ontvangen bakken
            for (int i = 0; i < IdentifiedList.GetLength(0); i++)
            {
                //add the location to the new array
                ConnectedLocation[i, 0] = IdentifiedList[i, 0];
                ConnectedLocation[i, 1] = "";
                ConnectedLocation[i, 2] = "";
                //check voor baanmotor
                if (IdentifiedList[i, 1] == "True") 
                {
                    ConnectedLocation[i, 0] = IdentifiedList[i, 0];
                    string letter;
                    string nummer;

                    if (char.IsDigit(Convert.ToChar(ConnectedLocation[i, 0].Substring(1, 1))))
                    {
                         letter = ConnectedLocation[i, 0].Substring(0, 1);
                         nummer = ConnectedLocation[i, 0].Substring(1);
                    } else
                    {
                        letter = ConnectedLocation[i, 0].Substring(0, 2);
                        nummer = ConnectedLocation[i, 0].Substring(2);
                    }
                    int intNumPs = (Convert.ToInt32(nummer)) + 1;
                    int intNumNg = (Convert.ToInt32(nummer)) - 1;
                    Boolean posPosition = false;
                    Boolean negPosition = false;
                    for (int j = 0; j < GetIolist.Length; j++)
                    {
                        if (letter + intNumPs == GetIolist[j])
                        {
                            posPosition = true;
                        }
                        if (letter + intNumNg == GetIolist[j])
                        {
                            negPosition = true;
                        }
                        if (posPosition && negPosition)
                        {
                            break;
                        }
                    }
                    if (posPosition)
                    {
                        ConnectedLocation[i, 1] = letter + intNumPs + "," + ConnectedLocation[i, 1];
                        ConnectedLocation[i, 2] = letter + intNumPs + "," + ConnectedLocation[i, 2];
                    }
                    if (negPosition)
                    {
                        ConnectedLocation[i, 1] = letter + intNumNg + "," + ConnectedLocation[i, 1];
                        ConnectedLocation[i, 2] = letter + intNumNg + "," + ConnectedLocation[i, 2];
                    }
                }
                if (IdentifiedList[i, 2] == "True") //Afduwer
                {
                    string nummer = ConnectedLocation[i, 0].Substring(1);
                    ConnectedLocation[i, 1] = nummer + "," + ConnectedLocation[i, 1];
                }
                if (IdentifiedList[i, 3] == "True") //Haler
                {
                    string nummer = ConnectedLocation[i, 0].Substring(1);
                    ConnectedLocation[i, 2] = nummer + "," + ConnectedLocation[i, 2];
                }
                if (IdentifiedList[i, 4] == "True") //AfduwerBinnenbaan
                {
                    string nummer = ConnectedLocation[i, 0].Substring(1);
                    ConnectedLocation[i, 1] = nummer + "," + ConnectedLocation[i, 1];
                }
                if (IdentifiedList[i, 5] == "True") //HalerBinnenbaan
                {
                    string nummer = ConnectedLocation[i, 0].Substring(1);
                    ConnectedLocation[i, 2] = nummer + "," + ConnectedLocation[i, 2];
                }
                /*
                if (IdentifiedList[i, 6] == "True")
                {
                    ConnectedLocation[i, 0] = IdentifiedList[i, 0];
                    string letter = ConnectedLocation[i, 0].Substring(0, 1);
                    string nummer = ConnectedLocation[i, 0].Substring(1, 2);
                    int intNumPs = (Convert.ToInt32(nummer)) + 1;
                    int intNumNg = (Convert.ToInt32(nummer)) - 1;
                    Boolean posPosition = true;
                    Boolean negPosition = true;
                    for (int j = 0; j < IOLijst.Length; j++)
                    {
                        if (intNumPs == Convert.ToInt32(IOLijst[1, j].Substring(1, 2)))
                        {
                            posPosition = false;
                        }
                        if (intNumNg == Convert.ToInt32(IOLijst[1, j].Substring(1, 2)))
                        {
                            negPosition = false;
                        }
                    }
                    if (posPosition)
                    {
                        for (int j = 0; j < IOLijst.Length; j++)//als de kettingbaan op de hoogste plaats zit voor zijn letter kijk dan wat de hogere letters zijn 
                        {
                            char myCharP = IOLijst[1, j].Substring(0, 1)[0];
                            myCharP++;
                            string myString = new string(myCharP, 1);
                            myString = myString + (IOLijst[1, j].Substring(1, 2));








                        }
                    }
                    if (negPosition)
                    {
                        for (int j = 0; j < IOLijst.Length; j++)
                        {





                        }
                    }





                    if (posPosition)
                    {
                        ConnectedLocation[i, 1] = letter + intNumPs + ";" + ConnectedLocation[i, 1];
                        ConnectedLocation[i, 2] = letter + intNumPs + ";" + ConnectedLocation[i, 2];
                    }
                    if (negPosition)
                    {
                        ConnectedLocation[i, 1] = letter + intNumNg + ";" + ConnectedLocation[i, 1];
                        ConnectedLocation[i, 2] = letter + intNumNg + ";" + ConnectedLocation[i, 2];
                    }
                }
                */
            }
            int rowLength = ConnectedLocation.GetLength(0);
            int colLength = ConnectedLocation.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    
                    Console.Write(string.Format("{0} ", ConnectedLocation[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            //geheugen plek 0 is voor de locatie, geheugen plek 1 is voor sturen van bakken, geheugen plek 2 is voor het ontvangen bakken
            return ConnectedLocation;
        }
    }
}
