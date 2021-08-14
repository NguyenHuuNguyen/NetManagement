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

namespace PBL3_NetManagement.GUI
{
    public partial class FormAddEditAccount : Form
    {
        public delegate void del1();
        public del1 Reload_Accounts;
        public del1 ReEnable;
        public FormAddEditAccount()
        {
            InitializeComponent();
        }
        public FormAddEditAccount(string username)
        {
            InitializeComponent();
            textBoxUsername.Text = username;
            textBoxUsername.Enabled = false;
            Account temp = BLL_NM.Instance.Get_Account_By_Username(textBoxUsername.Text);
            textBoxBalance.Text = temp.Balance.ToString();
            textBoxPassword.Text = temp.PassWord;
            textBoxConfirm.Text = temp.PassWord;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Password can not be blank!");
                return;
            }
            if (!string.Equals(textBoxPassword.Text, textBoxConfirm.Text))
            {
                MessageBox.Show("Please reconfirm account's password");
                return;
            }
            if (textBoxBalance.Text == "")
            {
                MessageBox.Show("Balance is invalid!");
                return;
            }
            string temp = textBoxBalance.Text;
            if (temp[0] == '.')
            {
                MessageBox.Show("Balance is invalid!");
                return;
            }
            for (int i = 0; i < temp.Length; i++)
            {
                if (!((temp[i] <= '9' && temp[i] >= '0') || temp[i] == '.'))
                {
                    MessageBox.Show("Balance is invalid!");
                    return;
                }
            }
            if (textBoxUsername.Text.Length > 50)
            {
                MessageBox.Show("Username is too long!");
                return;
            }
            if (textBoxPassword.Text.Length > 50)
            {
                MessageBox.Show("Password is too long!");
                return;
            }
            if(textBoxBalance.Text.Length > 20)
            {
                MessageBox.Show("Balance is invalid!");
                return;
            }
            Account account = new Account
            {
                UserName = textBoxUsername.Text,
                PassWord = textBoxPassword.Text,
                Balance = Convert.ToDouble(textBoxBalance.Text),
                Type = false,
                AccountStatus = false
            };
            if (textBoxUsername.Enabled)
            {
                if (BLL_NM.Instance.CheckIfAccountExist(textBoxUsername.Text))
                {
                    MessageBox.Show("Username already exists!");
                    return;
                }
                if (textBoxUsername.Text == "")
                {
                    MessageBox.Show("Username can not be blank!");
                    return;
                }
                BLL_NM.Instance.Add_Account(account);
            }
            else BLL_NM.Instance.Edit_Account(account);
            ReEnable();
            Reload_Accounts();
            this.Dispose();
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

        private void FormAddEditAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cancel();
        }
    }
}
