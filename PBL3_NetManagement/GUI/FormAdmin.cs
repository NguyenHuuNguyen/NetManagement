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
using PBL3_NetManagement.GUI;

namespace PBL3_NetManagement
{
    public partial class FormAdmin : Form
    {
        string AdminName;
        public delegate void del1();
        public del1 SetVisible_Login;
        DateTime login_time;
        Timer timer_LoadComputer;
        public FormAdmin(string username)
        {
            InitializeComponent();
            login_time = DateTime.Now;
            AdminName = username;
            BLL_NM.Instance.Login_init(login_time, AdminName);
        }
        private void Logout()
        {
            BLL_NM.Instance.Logout_init(login_time, AdminName);
            this.Dispose();
            SetVisible_Login();
        }
        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logout();
        }

        private void buttonAddComputer_Click(object sender, EventArgs e)
        {
            FormAddEditComputer faec = new FormAddEditComputer();
            faec.Show();
        }

        private void buttonDeleteComputer_Click(object sender, EventArgs e)
        {
            if ((buttonDeleteComputer.Tag as Computer).ComputerStatus == true)
            {
                MessageBox.Show("This computer is currently in use!");
                return;
            }
            BLL_NM.Instance.Delete_Computer((buttonDeleteComputer.Tag as Computer).idComputer);
            this.textBoxNameComputer.Text = "";
            this.textBoxStatusComputer.Text = "";
            this.textBoxPriceComputer.Text = "";
            this.textBoxIDComputer.Text = "";
        }

        private void buttonEditComputer_Click(object sender, EventArgs e)
        {
            FormAddEditComputer faec = new FormAddEditComputer(buttonEditComputer.Tag as Computer);
            faec.Show();
        }

        private void FormAdmin_Shown(object sender, EventArgs e)
        {
            timer_LoadComputer = new Timer();
            timer_LoadComputer.Tick += LoadComputer_Tick;
            timer_LoadComputer.Interval = 1000;
            timer_LoadComputer.Enabled = true;
            Load_Table();
        }
        private void LoadComputer_Tick(object sender, EventArgs e)
        {
            Load_Table();
        }
        // load thông tin cac Computer lên Flowl
        private void Load_Table()
        {
            flowLayoutComputer.Controls.Clear();
            List<Computer> lcomputer = BLL_NM.Instance.Get_All_Computer();
            foreach (Computer item in lcomputer)
            {
                Button bt = new Button() { Width = 75, Height = 75 };
                string status;
                if (item.ComputerStatus == false) status = "Trống";
                else status = "Bận";
                bt.Text = item.ComputerName + Environment.NewLine + status;
                bt.Click += Bt_Click;
                bt.Tag = item;
                if (item.ComputerStatus == true)
                {
                    bt.BackColor = Color.Red;
                }
                else
                {
                    bt.BackColor = Color.Blue;
                }
                flowLayoutComputer.Controls.Add(bt);
            }
        }
        // load thông tin Computer lên các textbox
        private void Load_Info_Computer(string idcomputer)
        {
            Computer computer = BLL_NM.Instance.Get_Computer(idcomputer);
            textBoxIDComputer.Text = computer.idComputer.ToString();
            textBoxNameComputer.Text = computer.ComputerName.ToString();
            textBoxPriceComputer.Text = computer.ComputerPrice.ToString();
            textBoxStatusComputer.Text = computer.ComputerStatus.ToString();
        }
        // khi nhấn vào các Computer trên Flowl
        private void Bt_Click(object sender, EventArgs e)
        {
            string idcomputer = ((sender as Button).Tag as Computer).idComputer;
            buttonDeleteComputer.Tag = ((sender as Button).Tag as Computer);
            buttonEditComputer.Tag = ((sender as Button).Tag as Computer);
            Load_Info_Computer(idcomputer);
        }
    }
}
