using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_NetManagement.BLL;

namespace PBL3_NetManagement
{
    public partial class FormUsercs : Form
    {
        public delegate void del1();
        public del1 SetVisible_Login;
        DateTime login_time;
        Timer BalanceSubtraction;
        TimeSpan timeUsed;
        public FormUsercs(string username)
        {
            InitializeComponent();
            this.Text = username;
            login_time = DateTime.Now;
            BLL_NM.Instance.Login_init(login_time, this.Text);
            
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
        private void Logout()
        {
            BLL_NM.Instance.Logout_init(login_time, this.Text);
            BalanceSubtraction.Enabled = false;
            this.Dispose();
            SetVisible_Login();
        }

        private void FormUsercs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logout();
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            FormPassword fp = new FormPassword(this.Text);
            fp.Show();
        }
        private void FormUsercs_Load(object sender, EventArgs e)
        {
            // gán số cho 3 textbox
            textBoxBalance.Text = BLL_NM.Instance.GetAccountBalance(this.Text).ToString();
            textBoxRemainingTime.Text = "00:00:00";
            textBoxTimeUsed.Text = "00:00:00";
            // cài đặt cho timer để trừ tiền theo thời gian
            BalanceSubtraction = new Timer();
            BalanceSubtraction.Tick += BalanceSubtractionPerTick;
            BalanceSubtraction.Interval = 1000;
            BalanceSubtraction.Enabled = true;
        } 
        private string ConvertTimeToString(int h, int m, int s)
        {
            //chuyển giờ phút giây thành chuỗi string để gán cho textbox
            string temp = "";
            if (h < 10) temp = "0" + h;
            else temp = "" + h;
            if (m < 10) temp += ":0" + m;
            else temp += ":" + m;
            if (s < 10) temp += ":0" + s;
            else temp += ":" + s;
            return temp;
        }
        private void BalanceSubtractionPerTick(object sender, EventArgs e)
        {
            string username = this.Text;
            // tiền = 0 thì logout
            if (BLL_NM.Instance.GetAccountBalance(username) <= 0) Logout();
            // trừ tiền
            BLL_NM.Instance.BalanceSubtraction(username, BLL_NM.Instance.GetComputerPrice(BLL_NM.Instance.Get_idComputer()) / 3600);
            // gán dữ liệu cho textbox
            double temp = BLL_NM.Instance.GetAccountBalance(username);
            textBoxBalance.Text = Convert.ToInt32(temp).ToString();
            temp = (temp / BLL_NM.Instance.GetComputerPrice(BLL_NM.Instance.Get_idComputer())) * 3600;
            int RT_h = Convert.ToInt32(temp) / 3600;
            int RT_m = (Convert.ToInt32(temp) % 3600) / 60;
            int RT_s = (Convert.ToInt32(temp) % 3600) % 60;
            textBoxRemainingTime.Text = ConvertTimeToString(RT_h, RT_m, RT_s);
            timeUsed = DateTime.Now - login_time;
            textBoxTimeUsed.Text = ConvertTimeToString(timeUsed.Hours, timeUsed.Minutes, timeUsed.Seconds);
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            FormOrder od = new FormOrder(this.Text);
            od.Show();
        }
    }
}
