using RoutePlanner;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace RoutePlannerStageOpdracht2
{

    public partial class RouteTableForm : Form
    {
        private string[,] Coordinaten;

        protected void NodeClick(object sender, EventArgs e)
        {
            //get the tag to get the location
            Button btn = (Button)sender;
            string str = JsonConvert.SerializeObject(btn.Tag);
            string[] tokens = str.Split(';');
            string Location = tokens[1] + "" + tokens[2];
            //clear the textboxes and fill with the nodes information
            Tb_CurrentNode.Text = "" + Location;
            Tb_OutCon.Text = "";
            Tb_InCon.Text = "";
            for (int j = 0; j < Coordinaten.GetLength(0); j++)
            {
                if (Location == Coordinaten[j, 0])
                {
                    Tb_OutCon.Text = Coordinaten[j, 1];
                    Tb_InCon.Text = Coordinaten[j, 2];
                }
            }
        }
        public RouteTableForm()
        {
            //Main
            InitializeComponent();
            //get the connected greenhouse from the selected green house 
            DrawGreenhouse kas = new DrawGreenhouse();
            Coordinaten = kas.DrawingMain(textBox2.Text);
            //draw the grid 
            drawGreenhouseMap(Coordinaten);
        }

        private void SetGreenhouse_Click(object sender, EventArgs e)
        {
            //choose greenhouse file
            openFileDialog1.InitialDirectory = @"C:\Users\Daniel\Desktop";
            openFileDialog1.Filter = "csv files (*.csv) | *.csv";
            openFileDialog1.ShowDialog();
            //checks if there is a file
            if (File.Exists(openFileDialog1.FileName))
            {
                //get the greenhouse data
                DrawGreenhouse kas = new DrawGreenhouse();
                Coordinaten = kas.DrawingMain(openFileDialog1.FileName);
                //draw the grid with the new greenhouse data
                drawGreenhouseMap(Coordinaten);
            }
        }
        private void drawGreenhouseMap(string[,] Coordinaten)
        {
            //setup array for grid construction
            P_GridGreenHouse.Controls.Clear();
            //initiate variables for axis generating
            int rowLength = Coordinaten.GetLength(0);
            int colLength = Coordinaten.GetLength(1);
            List<string> LetterList = new List<string>();
            List<string> StringNList = new List<string>();
            //split the array into the letters and numbers to create the axis
            for (int i = 0; i < rowLength; i++)
            {
                string letter;
                string number;
                if (char.IsDigit(Convert.ToChar(Coordinaten[i, 0].Substring(1, 1))))
                {
                    letter = Coordinaten[i, 0].Substring(0, 1);
                    number = Coordinaten[i, 0].Substring(1);
                }
                else
                {
                    letter = Coordinaten[i, 0].Substring(0, 2);
                    number = Coordinaten[i, 0].Substring(2);
                }
                if (!LetterList.Contains(letter))
                {
                    LetterList.Add(letter);
                }
                if (!StringNList.Contains(number))
                {
                    StringNList.Add(number);
                }
            }
            //sort the number list
            List<int> NumberList = new List<int>();
            for (int i = 0; i < StringNList.Count; i++)
            {
                int val = 0;
                if (Int32.TryParse(StringNList[i], out val))
                {
                    NumberList.Add(val);
                }
            }
            NumberList.Sort();
            //hardcoded sizes
            int BeginCoordinaatX = 30;
            int BeginCoordinaatY = 30;
            int SizeXaxis = 30;
            int SizeYaxis = 30;
            int SizeX = 60;
            int SizeY = 60;
            int Margin = 10;
            int fontSizeNodes = 7;
            //gets the paths for the images to use later
            string CorrectPath = Path.Combine(Directory.GetCurrentDirectory(), "correctNode.jpg");//green circel
            string WrongPath = Path.Combine(Directory.GetCurrentDirectory(), "wrongNode.jpg");//orange circel
            string LogoPath = Path.Combine(Directory.GetCurrentDirectory(), "Logo.jpg");
            //end hardcoded sizes
            //determine how high and wide the grid must be
            int XaxisGridSize = NumberList.Count;
            int YaxisGridSize = LetterList.Count;
            //determines how big the panels must be drawn
            P_GridGreenHouse.Size = new Size(SizeXaxis + (SizeX * XaxisGridSize), SizeYaxis + (SizeY * YaxisGridSize));
            P_GridGreenHouse.Location = new Point(Margin, Margin);
            //sidepanel with options 
            P_CheckLegacy.Size = new Size(210, P_GridGreenHouse.Size.Height);
            P_CheckLegacy.Location = new Point(Margin + P_GridGreenHouse.Size.Width + Margin, Margin);

            //extra panel between logo and explenation for editing nodes
            P_NodeEdit.Size = new Size(P_CheckLegacy.Size.Width, P_CheckLegacy.Size.Width);
            P_NodeEdit.Location = new Point((Margin + P_GridGreenHouse.Size.Width + Margin) - (P_CheckLegacy.Size.Width + Margin), Margin + P_GridGreenHouse.Size.Height + Margin);
            //corner logo
            P_Logo.Size = new Size(P_CheckLegacy.Size.Width, P_CheckLegacy.Size.Width);
            P_Logo.Location = new Point(Margin + P_GridGreenHouse.Size.Width + Margin, Margin + P_GridGreenHouse.Size.Height + Margin);
            //bar with explanation about the program
            P_Explanation.Size = new Size(P_GridGreenHouse.Size.Width - (P_CheckLegacy.Size.Width + Margin), P_CheckLegacy.Size.Width);
            P_Explanation.Location = new Point(Margin, Margin + P_GridGreenHouse.Size.Height + Margin);
            //textbox displaying which node you can edit
            //panels for the edit panel 
            Size EditPanel = new Size(P_NodeEdit.Width, (P_NodeEdit.Height / 7) * 1);
            P_NodeCurrent.Location = new Point(0, 0);
            P_NodeCurrent.Size = EditPanel;
            P_NodeCurrentW.Location = new Point(0, (P_NodeEdit.Height / 7) * 1);
            P_NodeCurrentW.Size = EditPanel;
            P_NodeOutCon.Location = new Point(0, (P_NodeEdit.Height / 7) * 2);
            P_NodeOutCon.Size = EditPanel;
            P_NodeOutConW.Location = new Point(0, (P_NodeEdit.Height / 7) * 3);
            P_NodeOutConW.Size = EditPanel;
            P_NodeInCon.Location = new Point(0, (P_NodeEdit.Height / 7) * 4);
            P_NodeInCon.Size = EditPanel;
            P_NodeInConW.Location = new Point(0, (P_NodeEdit.Height / 7) * 5);
            P_NodeInConW.Size = EditPanel;
            P_UpdateNode.Location = new Point(0, (P_NodeEdit.Height / 7) * 6);
            P_UpdateNode.Size = EditPanel;
            //textboxes displaying which node you can edit
            Tb_CurrentNode.Size = new Size(P_NodeCurrentW.Width - Margin, 20);
            Tb_CurrentNode.Location = new Point((P_NodeCurrentW.Width - Tb_CurrentNode.Width) / 2, (P_NodeCurrentW.Height - Tb_CurrentNode.Height) / 2);
            Tb_OutCon.Size = new Size(P_NodeOutConW.Width - Margin, 20);
            Tb_OutCon.Location = new Point((P_NodeOutConW.Width - Tb_OutCon.Width) / 2, (P_NodeOutConW.Height - Tb_OutCon.Height) / 2);
            Tb_InCon.Size = new Size(P_NodeOutConW.Width - Margin, 20);
            Tb_InCon.Location = new Point((P_NodeOutConW.Width - Tb_InCon.Width) / 2, (P_NodeOutConW.Height - Tb_InCon.Height) / 2);
            //button to update nodes
            Btn_UpdateNode.Size = new Size((P_UpdateNode.Width - Margin * 3) / 2, P_UpdateNode.Height - Margin);
            Btn_DeleteNode.Size = new Size((P_UpdateNode.Width - Margin * 3) / 2, P_UpdateNode.Height - Margin);
            Btn_UpdateNode.Location = new Point(Margin, (P_UpdateNode.Height - Btn_UpdateNode.Height) / 2);
            Btn_DeleteNode.Location = new Point(Margin + Btn_UpdateNode.Width + Margin, (P_UpdateNode.Height - Btn_UpdateNode.Height) / 2);
            //basic label placing in the edit panel
            Size PanelElements = new Size(P_NodeCurrent.Width - Margin * 5, P_NodeCurrent.Height - Margin);
            Lbl_CurrentNode.Size = PanelElements;
            Lbl_CurrentNode.Location = new Point((P_NodeCurrent.Width - Lbl_CurrentNode.Width) / 2, (P_NodeCurrent.Height - Lbl_CurrentNode.Height) / 2);
            Lbl_OutCon.Size = PanelElements;
            Lbl_OutCon.Location = new Point((P_NodeOutCon.Width - Lbl_OutCon.Width) / 2, (P_NodeOutCon.Height - Lbl_OutCon.Height) / 2);
            Lbl_InCon.Size = PanelElements;
            Lbl_InCon.Location = new Point((P_NodeInCon.Width - Lbl_InCon.Width) / 2, (P_NodeInCon.Height - Lbl_InCon.Height) / 2);
            //actual form size
            this.Height = (Margin + P_GridGreenHouse.Size.Height + Margin + P_CheckLegacy.Size.Width + Margin + 40);//40 and 15 are correction values for the control of the window 
            this.Width = (Margin + P_GridGreenHouse.Size.Width + Margin + P_CheckLegacy.Size.Width + Margin + 15);
            //class that draws the lines between nodes
            //instantiates the logo 
            var logo = new PictureBox
            {
                Name = "pictureBox(logo)",
                Size = new Size(P_Logo.Width - Margin * 2, P_Logo.Height - Margin * 2),
                Location = new Point(Margin, Margin),
                Image = Image.FromFile(LogoPath),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            P_Logo.Controls.Add(logo);
            P_GridGreenHouse.Controls.Add(PB_GreyBox1);
            //prints the nodes on the panel
            for (int i = 0; i < NumberList.Count; i++)
            {
                for (int j = 0; j < LetterList.Count; j++)
                {
                    string locatie = (LetterList[j]) + (NumberList[i]);
                    for (int k = 0; k < Coordinaten.GetLength(0); k++)
                    {
                        //looks if there is a node for that location
                        if (locatie == Coordinaten[k, 0])
                        {
                            //looks if the node has any connections
                            if (Coordinaten[k, 1] == "" && Coordinaten[k, 2] == "")
                            {
                                var picture = new Button
                                {
                                    Name = "pictureBox(" + NumberList[i] + ";" + (LetterList[j]) + ")",
                                    Text = "" + LetterList[j] + "" + (NumberList[i]) + "",
                                    Size = new Size(SizeX - 20, SizeY - 20),
                                    Location = new Point(BeginCoordinaatX + (SizeX * i) + 10, BeginCoordinaatY + (SizeY * j) + 10),
                                    BackgroundImage = Image.FromFile(WrongPath),
                                    BackgroundImageLayout = ImageLayout.Stretch,
                                    FlatStyle = FlatStyle.Flat,
                                };
                                picture.Font = new Font(picture.Font.FontFamily, fontSizeNodes);
                                string coordinaten = ";" + LetterList[j] + ";" + (NumberList[i]) + ";";
                                picture.Tag = coordinaten;
                                picture.Click += new EventHandler(NodeClick);
                                picture.FlatAppearance.BorderSize = 0;
                                P_GridGreenHouse.Controls.Add(picture);
                            }
                            else
                            {
                                var picture = new Button
                                {
                                    Name = "pictureBox(" + NumberList[i] + ";" + (LetterList[j]) + ")",
                                    Text = "" + LetterList[j] + "" + (NumberList[i]) + "",
                                    Size = new Size(SizeX - 20, SizeY - 20),
                                    Location = new Point(BeginCoordinaatX + (SizeX * i) + 10, BeginCoordinaatY + (SizeY * j) + 10),
                                    BackgroundImage = Image.FromFile(CorrectPath),
                                    BackgroundImageLayout = ImageLayout.Stretch,
                                    FlatStyle = FlatStyle.Flat,
                                };
                                picture.Font = new Font(picture.Font.FontFamily, fontSizeNodes);
                                string coordinaten = ";" + LetterList[j] + ";" + (NumberList[i]) + ";";
                                picture.Tag = coordinaten;
                                picture.Click += new EventHandler(NodeClick);
                                picture.FlatAppearance.BorderSize = 0;
                                P_GridGreenHouse.Controls.Add(picture);
                            }

                        }
                    }

                }
            }
            //prints the x axis
            for (int j = 0; j < NumberList.Count; j++)
            {
                var picture = new PictureBox
                {
                    Name = "PB_Xaxis(" + j + ")",
                    Size = new Size(SizeX, SizeXaxis),
                    Location = new Point(SizeXaxis + (SizeX * j), 0),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = BorderStyle.FixedSingle,
                };
                P_GridGreenHouse.Controls.Add(picture);
                var label = new Label
                {
                    Text = NumberList[j].ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(SizeX / 3, SizeY / 3),
                    Location = new Point(SizeXaxis + (SizeX * j) + SizeX / 3, (SizeYaxis - (SizeY / 3)) / 2),
                };
                P_GridGreenHouse.Controls.Add(label);
                label.BringToFront();
            }
            //prints the y axis
            for (int j = 0; j < LetterList.Count; j++)
            {
                var picture = new PictureBox
                {
                    Name = "PB_Yaxis(" + j + ")",
                    Size = new Size(SizeYaxis, SizeY),
                    Location = new Point(0, SizeXaxis + (SizeY * j)),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = BorderStyle.FixedSingle,
                };
                P_GridGreenHouse.Controls.Add(picture);
                var label = new Label
                {
                    Text = LetterList[j],
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(SizeX / 3, SizeY / 3),
                    Location = new Point((SizeXaxis - (SizeX / 3)) / 2, SizeYaxis + (SizeY * j) + SizeY / 3),
                };
                P_GridGreenHouse.Controls.Add(label);
                label.BringToFront();
            }
            DrawConnections(Coordinaten, NumberList, LetterList, BeginCoordinaatX, BeginCoordinaatY, SizeX, SizeY);
        }

        private void Btn_UpdateNode_Click(object sender, EventArgs e)
        {
            string location = Tb_CurrentNode.Text;
            Boolean CorrectLocation = false;
            //check if it is an existing location
            for (int j = 0; j < Coordinaten.GetLength(0); j++)
            {
                if (location == Coordinaten[j, 0])
                {
                    Coordinaten[j, 1] = Tb_OutCon.Text;
                    Coordinaten[j, 2] = Tb_InCon.Text;
                    CorrectLocation = true;
                }

            }
            if (CorrectLocation == false)
            {
                string[,] newArray = new string[Coordinaten.GetLength(0) + 1, 3];
                //copy the contents of the old array to the new one
                Array.Copy(Coordinaten, newArray, Coordinaten.Length);
                //set the original to the new array
                Coordinaten = newArray;
                int length = Coordinaten.GetLength(0) - 1;
                Coordinaten[length, 0] = Tb_CurrentNode.Text;
                Coordinaten[length, 1] = Tb_OutCon.Text;
                Coordinaten[length, 2] = Tb_InCon.Text;
                drawGreenhouseMap(Coordinaten);
            }
        }

        private void Btn_DeleteNode_Click(object sender, EventArgs e)
        {
            string location = Tb_CurrentNode.Text;
            Boolean CorrectLocation = false;
            int RowNr = 0;
            //check if it is an existing location
            for (int j = 0; j < Coordinaten.GetLength(0); j++)
            {
                if (location == Coordinaten[j, 0])
                {
                    Coordinaten[j, 1] = Tb_OutCon.Text;
                    Coordinaten[j, 2] = Tb_InCon.Text;
                    CorrectLocation = true;
                    RowNr = j;
                }

            }
            if (CorrectLocation == true)
            {
                Coordinaten = TrimArray(RowNr, 0, Coordinaten);
                drawGreenhouseMap(Coordinaten);
            }
        }
        public static string[,] TrimArray(int rowToRemove, int columnToRemove, string[,] originalArray)
        {
            string[,] result = new string[originalArray.GetLength(0) - 1, originalArray.GetLength(1)];
            int EmptyRow = 0;
            for (int i = 0; i < originalArray.GetLength(0); i++)
            {
                if (i != rowToRemove)
                {
                    for (int j = 0; j < originalArray.GetLength(1); j++)
                    {
                        result[EmptyRow, j] = originalArray[i, j];
                    }
                    EmptyRow++;
                }
            }
            return result;
        }

        private void DrawConnections(string[,] Coordinaten, List<int> NumberList, List<string> LetterList, int BeginCoordinaatX, int BeginCoordinaatY, int SizeX, int SizeY)
        {
            for (int i = 0; i < Coordinaten.GetLength(0); i++)
            {
                string letter;
                string number;
                if (char.IsDigit(Convert.ToChar(Coordinaten[i, 0].Substring(1, 1))))
                {
                    letter = Coordinaten[i, 0].Substring(0, 1);
                    number = Coordinaten[i, 0].Substring(1);
                }
                else
                {
                    letter = Coordinaten[i, 0].Substring(0, 2);
                    number = Coordinaten[i, 0].Substring(2);
                }
                int[] NumberArray = NumberList.ToArray();
                string[] LetterArray = LetterList.ToArray();
                string ConToDraw = "";
                int Number = Int32.Parse(number);
                int posNmbr = Array.IndexOf(NumberArray, Number);
                int posLttr = Array.IndexOf(LetterArray, letter);
                if (posNmbr > -1 && posLttr > -1)
                {
                    ConToDraw = check2Darray(Coordinaten[i, 0], Coordinaten[i, 1], Coordinaten[i, 2]);
                    if (true)
                    {
                        Pen p = new Pen(Color.Black);
                        p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                        Graphics.DrawLine(p, 10, 10, 100, 100);
                        new Point(BeginCoordinaatX + (SizeX * posLttr) + 25, BeginCoordinaatY + (SizeY * posNmbr) + 25);

                    }
                    P_GridGreenHouse_Paint();
                }
            }
        }
        private string check2Darray(string coordinate,string outgoing, string ingoing)
        {
            string returnValue = "";
            string letter;
            string number;
            if (char.IsDigit(Convert.ToChar(coordinate.Substring(1, 1))))
            {
                letter = coordinate.Substring(0, 1);
                number = coordinate.Substring(1);
            }
            else
            {
                letter = coordinate.Substring(0, 2);
                number = coordinate.Substring(2);
            }
            String[] OutCon = outgoing.Split(',');
            String[] InCon = ingoing.Split(',');
            for (int i = 0; i < OutCon.Length; i++)
            {
                if (OutCon[i] != "")
                {
                    Boolean ToLeft = false;
                    Boolean ToRight = false; 
                    int IntNumber = Int32.Parse(number);
                    if (OutCon[i] == letter + (IntNumber + 1))
                    {
                        ToRight = true;
                    }
                    if (OutCon[i] == letter + (IntNumber - 1))
                    {
                        ToLeft = true;
                    }
                    if (ToRight && ToLeft)
                    {
                        returnValue = "3";
                    }
                    else if (ToRight)
                    {
                        returnValue = "2";
                    }
                    else if (ToLeft)
                    {
                        returnValue = "1";
                    }
                    else
                    {
                        returnValue = "0";
                    }
                }
            }
            for (int i = 0; i < InCon.Length; i++)
            {
                if (InCon[i] != "")
                {
                    Boolean ToLeft = false;
                    Boolean ToRight = false;
                    int IntNumber = Int32.Parse(number);
                    if (InCon[i] == letter + (IntNumber + 1))
                    {
                        ToRight = true;
                    }
                    if (InCon[i] == letter + (IntNumber - 1))
                    {
                        ToLeft = true;
                    }
                    if (ToRight && ToLeft)
                    {
                        returnValue += ",3";
                    }
                    else if (ToRight)
                    {
                        returnValue += ",2";
                    }
                    else if (ToLeft)
                    {
                        returnValue += ",1";
                    }
                    else
                    {
                        returnValue += ",0";
                    }
                }
            }
            return returnValue;
        }

        private void BtnCoordinaten_Click(object sender, EventArgs e)
        {
            //try to find the directory, if failed create directory
            try
            {
                FileAttributes attr = File.GetAttributes(@"c:\Test");
            }
            catch
            {
                DirectoryInfo Test = Directory.CreateDirectory(@"c:\Test");
            }
            //create file and file object for code
            using (StreamWriter file = new StreamWriter("C:/Test/data.csv"))
            {
                var iLength = Coordinaten.GetLength(0);
                var jLength = Coordinaten.GetLength(1);
                //loop through entire array and write it down in .csv style
                for (int i = 0; i < iLength; i++)
                {
                    for (int j = 0; j < jLength; j++)
                    {
                        string TempStorage = Coordinaten[i, j];
                        if (j > 0)
                        {
                            TempStorage = TempStorage.Remove(TempStorage.Length - 1);
                        }
                        file.Write(TempStorage);
                        if (j < jLength-1)
                        {
                            file.Write(";");
                        }
                    }
                    file.WriteLine();
                }
            }
        }

        private void btnReadCoordinaten_Click(object sender, EventArgs e)
        {
            //warn user that the grid thats open will be overwritten
            DialogResult dialogResult = MessageBox.Show("this option will delete your current grid, continue?", "Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
            if (dialogResult == DialogResult.OK)
            {
                //read out the .csv file
                String line = String.Empty;
                var lineCount = File.ReadLines(@"C:/Test/data.csv").Count();
                System.IO.StreamReader file = new System.IO.StreamReader("C:/Test/data.csv");
                string[,] tusenCoordinaten = new string[lineCount,3];
                int currentline = 0;
                while ((line = file.ReadLine()) != null)
                {
                    String[] parts_of_line = line.Split(';');
                    for(int i = 0; i < parts_of_line.Length; i++)
                    {
                        parts_of_line[i] = parts_of_line[i].Trim();
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        tusenCoordinaten[currentline, i] = parts_of_line[i];
                    }
                    currentline++;
                }
                //write the gotten values to the static array and draw the grid again
                Coordinaten = tusenCoordinaten;
                drawGreenhouseMap(Coordinaten);
            }
        }

        private void BtnDrawConnections_Click(object sender, EventArgs e)
        {

        }

        private void P_GridGreenHouse_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
