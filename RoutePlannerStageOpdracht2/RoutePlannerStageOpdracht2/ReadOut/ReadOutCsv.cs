using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutePlanner.ReadOut
{
    class ReadOutCsv
    {
        public string[,] ReadOut(String IoLijstLocatie)
        {
            List<string> listIOnaam = new List<string>();
            List<string> listIOlocatie = new List<string>();
            using (var reader = new StreamReader(IoLijstLocatie))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listIOnaam.Add(values[0]);
                    listIOlocatie.Add(values[1]);
                }
            }
            var IOnaam = listIOnaam.ToArray();
            var IOlocatie = listIOlocatie.ToArray();
            string[,] IOlist = new string[2, IOnaam.Length];
            for (int i = 0; i < IOnaam.Length; i++)
            {
                IOlist[0, i] = IOnaam[i];
                IOlist[1, i] = IOlocatie[i];
            }
            return IOlist;
        }
    }
}
