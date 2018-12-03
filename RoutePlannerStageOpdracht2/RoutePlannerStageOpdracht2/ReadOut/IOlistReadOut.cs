using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutePlanner.ReadOut
{
    class IOlistReadOut
    {
        public string[,] ReadOut(String IoLijstLocatie)
        {
            ReadOutCsv Reader = new ReadOutCsv();
            string[,] IOlist = Reader.ReadOut(IoLijstLocatie);
            return IOlist;
        }
    }
}
