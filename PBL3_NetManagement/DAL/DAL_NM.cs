using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
        private NetManagementEntity db = new NetManagementEntity();

        public bool AccountCheck(string username, string password)
        {
            var account = from p in db.Accounts.AsNoTracking() where ((p.UserName == username) && (p.PassWord == password)) select p;
            //db.Entry(account).GetDatabaseValues();
            //db.Entry(account).State = EntityState.Detached;
            //db.Entry(account).Reload();
            return account.ToList().Count > 0;
        }
        public bool CheckIfAccountExist(string username)
        {
            var account = from p in db.Accounts.AsNoTracking() where (p.UserName == username) select p;
            return account.ToList().Count > 0;
        }
        public bool AccountTypeCheck(string username)
        {
            //chỉ sử dụng khi đã chạy AccountCheck và xác nhận Account có tồn tại
            var account = db.Accounts.AsNoTracking().Where(p => p.UserName == username).FirstOrDefault();
            if (account == null) throw (new Exception("Account not exist"));
            return account.Type;
        }
        public void ChangePassword(string username, string newPassword)
        {
            //chỉ sử dụng khi đã chạy AccountCheck và xác nhận Account có tồn tại 
            var account = db.Accounts.Where(p => string.Equals(p.UserName, username)).FirstOrDefault();
            if (account == null) return;
            account.PassWord = newPassword;
            db.SaveChanges();
        }
        public bool ComputerCheck(string idcomputer)
        {
            //hàm để kiểm tra computer sử dụng để đăng nhập có trong hệ thống hay không
            var computer = db.Computers.AsNoTracking().Where(p => string.Equals(p.idComputer, idcomputer)).Select(p => p);
            return computer.ToList().Count > 0;
        }
        public void ChangeComputerStatus(string idcomputer, bool status)
        {
            //hàm để đổi status của computer
            var computer = db.Computers.Where(p => string.Equals(p.idComputer, idcomputer)).FirstOrDefault();
            computer.ComputerStatus = status;
            db.SaveChanges();
        }

        public bool GetComputerStatus(string idcomputer)
        {
            //chỉ dùng khi đã xác nhận Computer có trong hệ thống
            var computer = db.Computers.AsNoTracking().Where(p => string.Equals(p.idComputer, idcomputer)).FirstOrDefault();
            if (computer == null) throw (new Exception("Computer not registed"));
            return computer.ComputerStatus;
        }
        public bool GetAccountStatus(string username)
        {
            //chỉ dùng khi đã xác nhận username có trong hệ thống
            var account = db.Accounts.AsNoTracking().Where(p => string.Equals(p.UserName, username)).FirstOrDefault();
            return account.AccountStatus;
        }
        public void ChangeAccountStatus(string username, bool status)
        {
            //chỉ dùng khi đã xác nhận username có trong hệ thống
            var account = db.Accounts.Where(p => string.Equals(p.UserName, username)).FirstOrDefault();
            if (account == null) throw new Exception("Account not exist");
            account.AccountStatus = status;
            db.SaveChanges();
        }
        public double GetAccountBalance(string username)
        {
            //chỉ dùng khi đã xác nhận username có trong hệ thống
            var account = db.Accounts.AsNoTracking().Where(p => string.Equals(p.UserName, username)).FirstOrDefault();
            return account.Balance;
        }
        public void Login_ComputerLog(DateTime login_time, string idcomputer, string username)
        {
            ComputerLog cl = new ComputerLog
            {
                DateLogin = login_time,
                DateLogout = login_time,
                idComputer = idcomputer,
                UserName = username
            };
            db.ComputerLogs.Add(cl);
            db.SaveChanges();
        }
        public void Logout_ComputerLog(DateTime login_time, DateTime logout_time, string username)
        {
            var cl = db.ComputerLogs.Where(p => (string.Equals(p.UserName, username) && (p.DateLogin == p.DateLogout))).FirstOrDefault();
            if (cl == null)
            {
                return;
            }
            cl.DateLogout = logout_time;
            db.SaveChanges();
        }
    }
}


