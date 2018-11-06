using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutePlanner.identify
{
    class connector
    {
        public string[,] ConnectLocation(string[,] IdentifiedList , string[,] IOLijst)
        {
            string[,] ConnectedLocation = new string[IdentifiedList.GetLength(0), 3];//geheugen plek 1 is voor de locatie, geheugen plek 2 is voor sturen van bakken, geheugen vplek 3 is voor het ontvangen bakken
            for (int i = 0; i < IdentifiedList.GetLength(0); i++)
            {
                if (IdentifiedList[i, 1] == "True") //check voor baanmotor
                {
                    ConnectedLocation[i, 0] = IdentifiedList[i, 0];
                    string letter = ConnectedLocation[i, 0].Substring(0, 1);
                    string nummer = ConnectedLocation[i, 0].Substring(1, 2);
                    int intNumPs = (Convert.ToInt32(nummer)) + 1;
                    int intNumNg = (Convert.ToInt32(nummer)) - 1;
                    Boolean posPosition = false;
                    Boolean negPosition = false;
                    for (int j = 0; j < IOLijst.Length ; j++)
                    {
                        if (intNumPs == Convert.ToInt32(IOLijst[1,j].Substring(1, 2)))
                        {
                            posPosition = true;
                        }
                        if (intNumNg == Convert.ToInt32(IOLijst[1, j].Substring(1, 2)))
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
                        ConnectedLocation[i, 1] = letter + intNumPs + ";" + ConnectedLocation[i, 1];
                        ConnectedLocation[i, 2] = letter + intNumPs + ";" + ConnectedLocation[i, 2];
                    }
                    if (negPosition)
                    {
                        ConnectedLocation[i, 1] = letter + intNumNg + ";" + ConnectedLocation[i, 1];
                        ConnectedLocation[i, 2] = letter + intNumNg + ";" + ConnectedLocation[i, 2];
                    }
                } 
                if (IdentifiedList[i, 2] == "True")
                {
                    ConnectedLocation[i, 0] = IdentifiedList[i, 0];
                    string nummer = ConnectedLocation[i, 0].Substring(1, 2);
                    ConnectedLocation[i, 1] = nummer + ";" + ConnectedLocation[i, 1];
                }
                if (IdentifiedList[i, 3] == "True")
                {
                    ConnectedLocation[i, 0] = IdentifiedList[i, 0];
                    string nummer = ConnectedLocation[i, 0].Substring(1, 2);
                    ConnectedLocation[i, 2] = nummer + ";" + ConnectedLocation[i, 2];
                }
                if (IdentifiedList[i, 4] == "True")
                {
                    ConnectedLocation[i, 0] = IdentifiedList[i, 0];
                    string nummer = ConnectedLocation[i, 0].Substring(1, 2);
                    ConnectedLocation[i, 1] = nummer + ";" + ConnectedLocation[i, 1];
                }
                if (IdentifiedList[i, 5] == "True")
                {
                    ConnectedLocation[i, 0] = IdentifiedList[i, 0];
                    string nummer = ConnectedLocation[i, 0].Substring(1, 2);
                    ConnectedLocation[i, 2] = nummer + ";" + ConnectedLocation[i, 2];
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
            return ConnectedLocation;
        }
    }
}
