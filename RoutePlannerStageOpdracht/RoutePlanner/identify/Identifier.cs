using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutePlanner.identify
{
    class Identifier
    {
        public string[,] identifyPossibilities(string[,] IOlist)
        {
            identifyLocation locationCheck = new identifyLocation();
            string[,] IdentifiedLocation = locationCheck.identifyPosPerLocation(IOlist);
            connector ConnectedLocation = new connector();
            string[,] ConnectedLocations = ConnectedLocation.ConnectLocation(IdentifiedLocation, IOlist);
            return ConnectedLocations;
        }
    }
}
