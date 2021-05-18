using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_NetManagement.BLL
{
    class BLL_NM
    {
        private static BLL_NM _Instance;
        public static BLL_NM Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_NM();
                return _Instance;
            }
            private set { }
        }
        public string Get_idComputer()
        {
            string username = Dns.GetHostName();
            IPHostEntry Ip = new IPHostEntry();
            Ip = Dns.GetHostEntry(username);
            return Ip.AddressList[Ip.AddressList.Length - 1].ToString();
        }
    }
}