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
        public bool CheckIfAccountExist(string username)
        {
            return DAL_NM.Instance.CheckIfAccountExist(username);
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
        public bool ComputerCheck(string idcomputer)
        {
            return DAL_NM.Instance.ComputerCheck(idcomputer);
        }
        public void ChangeComputerStatus(string idcomputer, bool status)
        {
            DAL_NM.Instance.ChangeComputerStatus(idcomputer, status);
        }
        public bool GetComputerStatus(string idcomputer)
        {
            return DAL_NM.Instance.GetComputerStatus(idcomputer);
        }
        public bool GetAccountStatus(string username)
        {
            return DAL_NM.Instance.GetAccountStatus(username);
        }
        public void ChangeAccountStatus(string username, bool status)
        {
            DAL_NM.Instance.ChangeAccountStatus(username, status);
        }
        public double GetAccountBalance(string username)
        {
            return DAL_NM.Instance.GetAccountBalance(username);
        }
        // chạy hàm khi login
        public void Login_init(DateTime login_time, string username)
        {
            // chuyển trạng tháy máy sang đang sử dụng
            BLL_NM.Instance.ChangeComputerStatus(BLL_NM.Instance.Get_idComputer(), true);
            // chuyển trạng thái tài khoản sang đang sử dụng
            BLL_NM.Instance.ChangeAccountStatus(username, true);
            // tạo ComputerLog
            BLL_NM.Instance.Login_ComputerLog(login_time, BLL_NM.Instance.Get_idComputer(), username);
        }
        // chạy hàm khi logout
        public void Logout_init(DateTime login_time, string username)
        {
            // cập nhật ComputerLog
            BLL_NM.Instance.Logout_ComputerLog(login_time, DateTime.Now, username);
            // chuyển trạng tháy máy sang đang không sử dụng
            BLL_NM.Instance.ChangeComputerStatus(BLL_NM.Instance.Get_idComputer(), false);
            // chuyển trạng thái tài khoản sang đang không sử dụng
            BLL_NM.Instance.ChangeAccountStatus(username, false);
        }
        public void Login_ComputerLog(DateTime login_time, string idcomputer, string username)
        {
            DAL_NM.Instance.Login_ComputerLog(login_time, idcomputer, username);
        }
        public void Logout_ComputerLog(DateTime login_time, DateTime logout_time, string username)
        {
            DAL_NM.Instance.Logout_ComputerLog(login_time, logout_time, username);
        }
        public double GetComputerPrice(string idcomputer)
        {
            return DAL_NM.Instance.GetComputerPrice(idcomputer);
        }
        public void BalanceSubtraction(string username, double amount)
        {
            DAL_NM.Instance.BalanceSubtraction(username, amount);
        }
        public List<Computer> Get_All_Computer()
        {
            return DAL_NM.Instance.Get_All_Computer();
        }
        public Computer Get_Computer(string idcomputer)
        {
            return DAL_NM.Instance.Get_Computer(idcomputer);
        }
        public void Add_Computer(Computer cpt)
        {
            DAL_NM.Instance.Add_Computer(cpt);
        }
        public void Delete_Computer(string idcomputer)
        {
            DAL_NM.Instance.Delete_Computer(idcomputer);
        }
        public void Edit_Computer(Computer computer)
        {
            DAL_NM.Instance.Edit_Computer(computer);
        }
        //
        public List<Good> Get_All_Good()
        {
            return DAL_NM.Instance.Get_All_Good();
        }
        public void Add_Bill(DateTime date, string username)
        {
            DAL_NM.Instance.Add_Bill(date, username);
        }
        public int Get_idBill(DateTime date, string username)
        {
            return DAL_NM.Instance.Get_idBill(date, username);
        }
        public void Add_BillInfo(int idbill, int idgood, int count)
        {
            DAL_NM.Instance.Add_BillInfo(idbill, idgood, count);
        }
        public List<ComputerLog> GetComputerLogs()
        {
           return DAL_NM.Instance.Get_All_ComputerLog();
        }
        public void Delete_Computer_Log(string idcomputer)
        {
            DAL_NM.Instance.Delete_Computer_Log(idcomputer);
        }
    }
}