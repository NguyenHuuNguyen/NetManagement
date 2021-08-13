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
    public partial class FormPassword : Form
    {
        public delegate void del1();
        public del1 ReEnable;
        private string Username;
        public FormPassword(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        private void Cancel()
        {
            ReEnable();
            this.Dispose();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!BLL_NM.Instance.AccountCheck(Username, textBoxPassword.Text)){
                MessageBox.Show("Incorrect old password!");
                return;
            }
            if (!string.Equals(textBoxNewpassword.Text, textBoxConfirm.Text))
            {
                MessageBox.Show("Error, please reconfirm your new password!");
                return;
            }
            if (textBoxNewpassword.Text == "")
            {
                MessageBox.Show("New password cannot be blank!");
                return;
            }
            BLL_NM.Instance.ChangePassword(Username, textBoxConfirm.Text);
            ReEnable();
            this.Dispose();
        }

        private void FormPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cancel();
        }
    }
}
