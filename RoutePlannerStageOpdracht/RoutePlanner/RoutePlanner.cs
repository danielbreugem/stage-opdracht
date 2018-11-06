using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutePlanner
{
    class RoutePlanner
    {
        static void Main(string[] args)
        {
            DrawGreenhouse kas = new DrawGreenhouse();
            string[,] Coordinaten;
            Coordinaten = kas.DrawingMain();
        }
    }
}
