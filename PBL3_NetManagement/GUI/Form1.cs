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
using PBL3_NetManagement.DAL;

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
            textBox1.Text = DAL_NM.Instance.ComputerCheck(textBox2.Text).ToString();
            NetManagementEntity db = new NetManagementEntity();
            var computer = db.Computers.Where(p => string.Equals(p.idComputer, textBox2.Text)).Select(p => p);
            //var computer = from p in db.Computers where p.idComputer == textBox2.Text select p;
            dataGridView1.DataSource = computer.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLL_NM.Instance.ChangePassword(textBox1.Text, textBox4.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
