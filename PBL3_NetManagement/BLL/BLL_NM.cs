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
        public Account Get_Account_By_Username(string username)
        {
            return DAL_NM.Instance.Get_Account_By_Username(username);
        }
        public List<Account_Show> Get_Clients_Show(string username)
        {
            List<Account_Show> data = new List<Account_Show>();
            foreach (Account i in DAL_NM.Instance.Get_All_Accounts())
            {
                if (!i.Type && i.UserName.Contains(username))
                {
                    data.Add(new Account_Show
                    {
                        Username = i.UserName,
                        AccountStatus = i.AccountStatus,
                        Balance = i.Balance
                    });
                }
            }
            return data;
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
        public List<Good_Show> Get_All_Good_With_Name(string goodname)
        {
            List<Good_Show> listgood = new List<Good_Show>();
            foreach (Good item in DAL_NM.Instance.Get_All_Good())
            {
                if (item.GoodName.Contains(goodname))
                {
                    listgood.Add(new Good_Show
                    {
                        idGood = item.idGood,
                        GoodName = item.GoodName,
                        GoodPrice = item.GoodPrice
                    });
                }
            }
            return listgood;
        }
        public Good Get_Good_With_Name(string goodname)
        {
            foreach (Good item in DAL_NM.Instance.Get_All_Good())
            {
                if (item.GoodName == goodname)
                {
                    return item;
                }
            }
            return null;
        }
        public Good Get_Good_With_Id(int idgood)
        {
            foreach (Good item in DAL_NM.Instance.Get_All_Good())
            {
                if (item.idGood == idgood)
                {
                    return item;
                }
            }
            return null;
        }
        public bool Check_Name_Good(string goodname)
        {
            foreach (Good item in DAL_NM.Instance.Get_All_Good())
            {
                if (item.GoodName == goodname)
                {
                    return true;
                }
            }
            return false;
        }
        public void Add_Good(Good good)
        {
            DAL_NM.Instance.Add_Good(good);
        }
        public void Edit_Good(Good good)
        {
            DAL_NM.Instance.Edit_Good(good);
        }
        public void Delete_Good(int idgood)
        {
            DAL_NM.Instance.Delete_Good(idgood);
        }
        public bool GoodCheck(int idgood, string namegood, int price)
        {
            return DAL_NM.Instance.GoodCheck(idgood, namegood, price);
        }
        public List<Bill> Get_Bill()
        {
            return DAL_NM.Instance.Get_Bill();
        }
        public List<BillInfo> Get_Billinfo_with_idBill(int idbill)
        {
            return DAL_NM.Instance.Get_Billinfo_with_idBill(idbill);
        }
        public string Get_GoodName(int idgood)
        {
            string goodname = "";
            foreach (Good i in Get_All_Good())
            {
                if (i.idGood == idgood)
                {
                    goodname = i.GoodName;
                }
            }
            return goodname;
        }
        public string Text_alignment(string text, int leght)
        {
            string texttxt = text;
            if (texttxt.Length < leght)
            {
                for (int i = 1; i <= (leght - text.Length); i++)
                {
                    texttxt = texttxt + " ";
                }
            }
            return texttxt;
        }
        public void Add_Account(Account account)
        {
            DAL_NM.Instance.Add_Account(account);
        }
        public void Edit_Account(Account account)
        {
            DAL_NM.Instance.Edit_Account(account);
        }
        public void Delete_Account(string username)
        {
            DAL_NM.Instance.Delete_Bills_By_username(username);
            DAL_NM.Instance.Delete_Computer_Log_By_Username(username);
            DAL_NM.Instance.Delete_Account_By_Username(username);
        }
        public Bill Get_Newest_Bill()
        {
            return DAL_NM.Instance.Get_Newest_Bill();
        }
        public Bill Get_next_Bill(Bill currentBill)
        {
            return DAL_NM.Instance.Get_next_Bill(currentBill);
        }
    }
}