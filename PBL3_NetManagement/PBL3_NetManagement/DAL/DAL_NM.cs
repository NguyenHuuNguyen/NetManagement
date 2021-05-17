using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_NetManagement.DAL
{
    class DAL_NM
    {
        private static DAL_NM _Instance;
        public static DAL_NM Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_NM();
                return _Instance;
            }
            private set { }

        }
    }
}


