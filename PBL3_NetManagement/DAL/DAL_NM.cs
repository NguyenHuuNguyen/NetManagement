using System;
using System.Collections.Generic;
using System.Data;
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
        private NetManagementEntities db = new NetManagementEntities();

        public bool AccountCheck(string username, string password)
        {
            var temp = from p in db.Accounts where ((p.UserName == username) && (p.PassWord == password)) select p;
            return temp.ToList().Count > 0;
        }
        public bool AccountTypeCheck(string username)
        {
            //chỉ sử dụng khi đã chạy AccountCheck và xác nhận Account có tồn tại
            var account = db.Accounts.Where(p => p.UserName == username).FirstOrDefault();
            if (account == null) throw (new Exception("Account not exist"));
            return account.Type;
        }
        public void ChangePassword(string username, string newPassword)
        {
            //chỉ sử dụng khi đã chạy AccountCheck và xác nhận Account có tồn tại 
            var account = db.Accounts.Where(p => p.UserName == username).FirstOrDefault();
            if (account == null) return;
            account.PassWord = newPassword;
            db.SaveChanges();
        }

    }
}


