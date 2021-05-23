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
        public FormUsercs(string username)
        {
            InitializeComponent();
            this.Text = username;
            // chuyển trạng tháy máy sang đang sử dụng
            BLL_NM.Instance.ChangeComputerStatus(BLL_NM.Instance.Get_idComputer(), true);
            // chuyển trạng thái tài khoản sang đang sử dụng
            BLL_NM.Instance.ChangeAccountStatus(this.Text, true);
            // tạo ComputerLog
            login_time = DateTime.Now;
            BLL_NM.Instance.Login_ComputerLog(login_time, BLL_NM.Instance.Get_idComputer(), this.Text);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
        private void Logout()
        {
            // cập nhật ComputerLog
            BLL_NM.Instance.Logout_ComputerLog(login_time, DateTime.Now, this.Text);
            // chuyển trạng tháy máy sang đang không sử dụng
            BLL_NM.Instance.ChangeComputerStatus(BLL_NM.Instance.Get_idComputer(), false);
            // chuyển trạng thái tài khoản sang đang không sử dụng
            BLL_NM.Instance.ChangeAccountStatus(this.Text, false);

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
        int RT_h, RT_m, RT_s, TU_h, TU_m, TU_s;
        private void FormUsercs_Load(object sender, EventArgs e)
        {
            // gán số cho 3 textbox
            textBoxBalance.Text = BLL_NM.Instance.GetAccountBalance(this.Text).ToString();
            textBoxRemainingTime.Text = "";
            textBoxTimeUsed.Text = "00:00:00";
            // bắt đầu trừ tiền
            BalanceSubtraction = new Timer();
            BalanceSubtraction.Tick += BalanceSubtractionPerTick;
            BalanceSubtraction.Interval = 1000;
            BalanceSubtraction.Enabled = true;
        }
        private void BalanceSubtractionPerTick(object sender, EventArgs e)
        {
            string username = this.Text;
            if (BLL_NM.Instance.GetAccountBalance(username) <= 0) Logout();
            BLL_NM.Instance.BalanceSubtraction(username, BLL_NM.Instance.GetComputerPrice(BLL_NM.Instance.Get_idComputer()) / 3600);
            textBoxBalance.Text = (BLL_NM.Instance.GetAccountBalance(username)).ToString();
        }
    }
}
