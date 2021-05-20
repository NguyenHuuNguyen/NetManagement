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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NetManagementEntities db = new NetManagementEntities();

            if (BLL_NM.Instance.AccountCheck(textBox1.Text, textBox2.Text))
            {
                textBox3.Text = "true, type: " + BLL_NM.Instance.AccountTypeCheck(textBox1.Text).ToString();
            }
            else
            {
                textBox3.Text = "false";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLL_NM.Instance.ChangePassword(textBox1.Text, textBox4.Text);
        }
    }
}
