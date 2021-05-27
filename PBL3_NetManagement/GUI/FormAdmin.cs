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
           DialogResult result = MessageBox.Show("Do you really want to delete this computer", "Warning", MessageBoxButtons.YesNo);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                BLL_NM.Instance.Delete_Computer_Log((buttonDeleteComputer.Tag as Computer).idComputer);
                BLL_NM.Instance.Delete_Computer((buttonDeleteComputer.Tag as Computer).idComputer);
            }else if(result == System.Windows.Forms.DialogResult.No)
            {
                
            }
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
            LoadSystemLogs();
        }
        // Khi timer load lại flowl thì đồng thời load lại các textbox chứa thông tin của máy
        private void LoadComputer_Tick(object sender, EventArgs e)
        {
            Load_Table();
            if (buttonEditComputer.Tag == null)
            return;
            Load_Info_Computer((buttonEditComputer.Tag as Computer).idComputer);
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
            if (!BLL_NM.Instance.ComputerCheck(idcomputer)) return;
            Computer computer = BLL_NM.Instance.Get_Computer(idcomputer);
            textBoxIDComputer.Text = computer.idComputer.ToString();
            textBoxNameComputer.Text = computer.ComputerName.ToString();
            textBoxPriceComputer.Text = computer.ComputerPrice.ToString();
            textBoxStatusComputer.Text = computer.ComputerStatus.ToString();
            foreach(ComputerLog item in BLL_NM.Instance.GetComputerLogs())
            if(computer.ComputerStatus == true && item.idComputer==computer.idComputer && item.DateLogout == item.DateLogin )
            {
                    textBoxUser.Text = item.UserName;
            }
            if (computer.ComputerStatus == false)
                textBoxUser.Clear();
         }
        // khi nhấn vào các Computer trên Flowl
        private void Bt_Click(object sender, EventArgs e)
        {
            string idcomputer = ((sender as Button).Tag as Computer).idComputer;
            buttonDeleteComputer.Tag = ((sender as Button).Tag as Computer);
            buttonEditComputer.Tag = ((sender as Button).Tag as Computer);
            Load_Info_Computer(idcomputer);
        }
        private void LoadSystemLogs()
        {
            textBoxSystemLog_All.Text = "";
            foreach(ComputerLog i in BLL_NM.Instance.GetComputerLogs().OrderByDescending(o => o.idLog))
            {
                if (!i.UserName.Contains(textBox_SystemLogSearch.Text)) continue;
                textBoxSystemLog_All.Text += "Log Id:     " + i.idLog + "\r\n";
                textBoxSystemLog_All.Text += "Username:     " + i.UserName + "\r\n";
                textBoxSystemLog_All.Text += "Computer Id:  " + i.idComputer + "\r\n";
                textBoxSystemLog_All.Text += "Login time:     " + i.DateLogin + "\r\n";
                textBoxSystemLog_All.Text += "Logout time:  ";
                if (i.DateLogin == i.DateLogout) textBoxSystemLog_All.Text += "Currently in use \r\n";
                else textBoxSystemLog_All.Text += i.DateLogout + "\r\n";
                textBoxSystemLog_All.Text += "-----------------------------------------------------\r\n";
            }
        }

        private void buttonRefreshSystemLog_Click(object sender, EventArgs e)
        {
            LoadSystemLogs();
        }

        private void textBox_SystemLogSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSystemLogs();
        }
    }
}
