using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutePlanner
{
    public class DrawGreenhouse
    {
        public string[,] DrawingMain()
        {
            ReadOut.IOlistReadOut Reader = new ReadOut.IOlistReadOut();
            string[,] IOlist = Reader.ReadOut();
            identify.Identifier checklist = new identify.Identifier();
            string[,] connectedCoordinates = checklist.identifyPossibilities(IOlist);
            return connectedCoordinates;
        }
    }
}
