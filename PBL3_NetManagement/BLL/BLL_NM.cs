using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using PBL3_NetManagement.DAL;

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
        public bool AccountCheck(string username, string password)
        {
            return DAL_NM.Instance.AccountCheck(username, password);
        }
        public bool AccountTypeCheck(string username)
        {
            //chỉ sử dụng khi đã chạy AccountCheck và xác nhận Account có tồn tại
            return DAL_NM.Instance.AccountTypeCheck(username);
        }
        public void ChangePassword(string username, string newPassword)
        {
            //chỉ sử dụng khi đã chạy AccountCheck và xác nhận Account có tồn tại 
            DAL_NM.Instance.ChangePassword(username, newPassword);
        }
    }
}