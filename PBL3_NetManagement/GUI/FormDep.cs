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
    public partial class FormDep : Form
    {
        public delegate void del1();
        public del1 Reload_Accounts;
        public del1 ReEnable;
        public FormDep(string username)
        {
            InitializeComponent();
            this.Text = username;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string temp = textBoxAmount.Text;
            if (string.Equals(temp, ""))
            {
                MessageBox.Show("Amount cannot be empty!");
                return;
            }
            if (temp[0] == '.')
            {
                MessageBox.Show("Invalid amount!");
                return;
            }
            for (int i = 0; i < temp.Length; i++)
            {
                if (i == 0 && (temp[0] == '-' || temp[0] == '+')) continue;
                if (!((temp[i] <= '9' && temp[i] >= '0') || temp[i] == '.'))
                {
                    MessageBox.Show("Invalid amount!");
                    return;
                }

            }
            double amount = Convert.ToDouble(temp);
            BLL_NM.Instance.BalanceSubtraction(this.Text, amount * (-1.0));
            Reload_Accounts();
            ReEnable();
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

        private void FormDep_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cancel();
        }
    }
}
