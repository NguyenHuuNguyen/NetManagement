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
        private string Username;
        public FormPassword(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
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
            //chưa xong
        }
    }
}
