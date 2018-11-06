using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutePlanner.identify.Database
{
    public class publicFunctions
    {
        public string GetIPv4Address()
        {
            string IPaddress = "";
            string strHostName = System.Net.Dns.GetHostName();
            System.Net.IPHostEntry iphe = System.Net.Dns.GetHostEntry(strHostName);

            foreach (System.Net.IPAddress ipheal in iphe.AddressList)
            {
                if (ipheal.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    IPaddress = ipheal.ToString();
            }
            return IPaddress;
        }
    }
}
