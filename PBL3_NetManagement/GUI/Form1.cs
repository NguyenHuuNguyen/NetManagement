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
            textBox1.Text = BLL_NM.Instance.Get_idComputer();
            NetManagementEntities db = new NetManagementEntities();
            dataGridView1.DataSource = db.Accounts.ToList();
        }
    }
}
