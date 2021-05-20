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
        public FormUsercs(string username)
        {
            InitializeComponent();
            this.Text = username;
            // chuyển trạng tháy máy sang đang sử dụng
            BLL_NM.Instance.ChangeComputerStatus(BLL_NM.Instance.Get_idComputer(), true);
            // chuyển trạng thái tài khoản sang đang sử dụng
            BLL_NM.Instance.ChangeAccountStatus(this.Text, true);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
        private void Logout()
        {
            // chuyển trạng tháy máy sang đang không sử dụng
            BLL_NM.Instance.ChangeComputerStatus(BLL_NM.Instance.Get_idComputer(), false);
            // chuyển trạng thái tài khoản sang đang không sử dụng
            BLL_NM.Instance.ChangeAccountStatus(this.Text, false);
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
    }
}
