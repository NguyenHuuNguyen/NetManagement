using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Account Get_Account_By_Username(string username)
        {
            var account = db.Accounts.AsNoTracking().Where(p => string.Equals(p.UserName, username)).Select(p => p).FirstOrDefault();
            return account as Account;
        }
        public List<Account> Get_All_Accounts()
        {
            var account = db.Accounts.AsNoTracking().Select(p => p);
            return account.ToList();
        }
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
            if (account == null)
            {
                return;
            }
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
        public double GetComputerPrice(string idcomputer)
        {
            var c = db.Computers.AsNoTracking().Where(p => string.Equals(p.idComputer, idcomputer)).FirstOrDefault();
            return c.ComputerPrice; 
        }
        public void BalanceSubtraction(string username, double amount)
        {
            var account = db.Accounts.Where(p => string.Equals(p.UserName, username)).FirstOrDefault();
            if (account == null)
            {
                return;
            }
            double temp = GetAccountBalance(username) - amount;
            if (temp < 0) account.Balance = 0;
            else account.Balance = temp;
            db.SaveChanges();
        }
        public List<Computer> Get_All_Computer()
        {
            var computer = from p in db.Computers.AsNoTracking() select p;
            return computer.ToList();
        }
        public Computer Get_Computer(string idcomputer)
        {
            var computer = db.Computers.AsNoTracking().Where(p => (string.Equals(p.idComputer, idcomputer))).FirstOrDefault();
            return computer as Computer;
        }
        public void Add_Computer(Computer cpt)
        {
            db.Computers.Add(cpt);
            db.SaveChanges();
        }
        public void Delete_Computer(string idcomputer)
        {
            var computer = db.Computers.Where(p => string.Equals(p.idComputer, idcomputer)).FirstOrDefault();
            db.Computers.Remove(computer);
            db.SaveChanges();
        }
        public void Edit_Computer(Computer computer)
        {
            var computer_var = db.Computers.Where(p => string.Equals(p.idComputer, computer.idComputer)).FirstOrDefault();
            computer_var.ComputerPrice = computer.ComputerPrice;
            computer_var.ComputerName = computer.ComputerName;
            db.SaveChanges();
        }
        //
        public List<Good> Get_All_Good()
        {
            var good = from p in db.Goods.AsNoTracking() select p;
            return good.ToList();
        }
        public void Add_Bill(DateTime date, string username)
        {
            Bill lbill = new Bill();
            lbill.Date = date;
            lbill.UserName = username;
            db.Bills.Add(lbill);
            db.SaveChanges();
        }
        public int Get_idBill (DateTime date, string username)
        {
            var bill = db.Bills.AsNoTracking().Where(p => (p.UserName == username)).Select(p => p);
            int idb = 0;
            List<Bill> lbill = bill.ToList();
            foreach(Bill i in lbill)
            {
                if (i.idBill > idb) idb = i.idBill;
            }
            return idb;
        }
        public void Add_BillInfo (int idbill, int idgood, int count)
        {
            BillInfo billInfo = new BillInfo();
            billInfo.idBill = idbill;
            billInfo.idGood = idgood;
            billInfo.Count = count;
            db.BillInfoes.Add(billInfo);
            db.SaveChanges();
        }
        public List<ComputerLog> Get_All_ComputerLog()
        {
            var computerlog = from p in db.ComputerLogs.AsNoTracking() select p;
            return computerlog.ToList();
        }
        public bool Check_If_IdComputer_Log_Exist(string idcomputer)
        {
            var computerlog = db.ComputerLogs.AsNoTracking().Where(p => string.Equals(p.idComputer, idcomputer)).Select(p => p);
            return computerlog.ToList().Count > 0;
        }
        public void Delete_Computer_Log(string idcomputer)
        {
            if (Check_If_IdComputer_Log_Exist(idcomputer))
            {
                var computerlog = db.ComputerLogs.Where(p => string.Equals(p.idComputer, idcomputer)).Select(p => p);
                db.ComputerLogs.RemoveRange(computerlog);
                db.SaveChanges();
            }    
        }
        public void Add_Account(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
        }
        public void Edit_Account(Account account)
        {
            var data = db.Accounts.Where(p => string.Equals(account.UserName, p.UserName)).FirstOrDefault();
            db.Accounts.Attach(data);
            data.PassWord = account.PassWord;
            data.Balance = account.Balance;
            db.SaveChanges();
            Console.WriteLine(data.PassWord + " " + account.PassWord + " " + data.UserName);
        }
        public void Delete_Computer_Log_By_Username(string username)
        {
            var computerlog = db.ComputerLogs.Where(p => string.Equals(p.UserName, username)).Select(p => p);
            if (computerlog == null) return;
            db.ComputerLogs.RemoveRange(computerlog);
            db.SaveChanges();
        }
        public void Delete_Bills_By_username(string  username)
        {
            var bill = db.Bills.Where(p => string.Equals(p.UserName, username)).Select(p => p);
            if (bill == null) return;
            foreach(Bill i in bill.ToList())
            {
                var billinfor = db.BillInfoes.Where(p => p.idBill == i.idBill).Select(p => p);
                if (billinfor == null) continue;
                db.BillInfoes.RemoveRange(billinfor);
                db.SaveChanges();
            }
            db.Bills.RemoveRange(bill);
            db.SaveChanges();
        }
        public void Delete_Account_By_Username(string username)
        {
            var account = db.Accounts.Where(p => string.Equals(username, p.UserName)).Select(p => p).FirstOrDefault();
            db.Accounts.Remove(account);
            db.SaveChanges();
        }
        public bool GoodCheck(int idgood, string namegood, int price)
        {
            var idGood = from p in db.Goods.AsNoTracking() where ((p.idGood == idgood) && (p.GoodName == namegood) && (p.GoodPrice == price)) select p;
            return idGood.ToList().Count > 0;
        }
        public List<Bill> Get_Bill()
        {
            var bill = from p in db.Bills.AsNoTracking() select p;
            return bill.ToList();
        }
        public List<BillInfo> Get_Billinfo_with_idBill(int idbill)
        {
            var billinfo_wid = from p in db.BillInfoes.AsNoTracking() where (p.idBill == idbill) select p;
            return billinfo_wid.ToList();
        }
        public void Add_Good(Good good)
        {
            db.Goods.Add(good);
            db.SaveChanges();
        }
        public void Edit_Good(Good good)
        {
            var goodvar = (from p in db.Goods where p.idGood == good.idGood select p).FirstOrDefault();
            goodvar.GoodName = good.GoodName;
            goodvar.GoodPrice = good.GoodPrice;
            db.SaveChanges();
        }
        //
        // xài tạm bợ, đợi đổi thành idbill
        //
        public int Get_idGood_By_NameFood(string namegood)
        {
            var good = db.Goods.Where(p => string.Equals(namegood, p.GoodName)).FirstOrDefault();
            return good.idGood;
        }
        public void Delete_Good(int idgood)
        {
            var billinfo = db.BillInfoes.Where(p => p.idGood == idgood).Select(p => p);
            db.BillInfoes.RemoveRange(billinfo);
            db.SaveChanges();
            var goodvar = db.Goods.Where(p => p.idGood == idgood).FirstOrDefault();
            db.Goods.Remove(goodvar);
            db.SaveChanges();
        }
        public Bill Get_Newest_Bill()
        {
            var bill = db.Bills.AsNoTracking().OrderByDescending(p => p.idBill).FirstOrDefault();
            return bill;
        }
        public Bill Get_next_Bill(Bill currentBill)
        {
            var nextbill = db.Bills.AsNoTracking().Where(p => p.idBill == currentBill.idBill + 1).FirstOrDefault();
            if (nextbill == null) return currentBill;
            else return nextbill;

        }
    }
}


