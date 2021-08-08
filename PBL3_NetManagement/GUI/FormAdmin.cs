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
        Bill currentBill;
        public FormAdmin(string username)
        {
            InitializeComponent();
            login_time = DateTime.Now;
            AdminName = username;
            BLL_NM.Instance.Login_init(login_time, AdminName);
            currentBill = BLL_NM.Instance.Get_Newest_Bill();
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
            if (string.Equals(textBoxIDComputer.Text, "")) return;
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
                LoadSystemLogs();
            }
            this.textBoxNameComputer.Text = "";
            this.textBoxStatusComputer.Text = "";
            this.textBoxPriceComputer.Text = "";
            this.textBoxIDComputer.Text = "";
        }

        private void buttonEditComputer_Click(object sender, EventArgs e)
        {
            if (string.Equals(textBoxIDComputer.Text, "")) return;
            FormAddEditComputer faec = new FormAddEditComputer(buttonEditComputer.Tag as Computer);
            faec.Show();
        }

        private void FormAdmin_Shown(object sender, EventArgs e)
        {
            timer_LoadComputer = new Timer();
            timer_LoadComputer.Tick += LoadComputer_Tick;
            timer_LoadComputer.Tick += Check_newBill;
            timer_LoadComputer.Interval = 1000;
            timer_LoadComputer.Enabled = true;
            Load_Table();
            LoadSystemLogs();
            LoadBill();
            LoadAccounts();
            Load_DTGrid_Good();
        }
        // Kiểm tra xem có Bill mới hay không
        private void Check_newBill(object sender, EventArgs e)
        {
            Bill nextBill = BLL_NM.Instance.Get_Newest_Bill();
            if (nextBill.idBill > currentBill.idBill)
            {
                currentBill.idBill += 1;
                MessageBox.Show("idBill: " + nextBill.idBill + "\nUsername: " + nextBill.UserName, "New order!");
            }
            else return;
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
                if (item.ComputerStatus == false) status = "OFF";
                else status = "ON";
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
        private void Load_DTGrid_Good()
        {
            dataGridView_Goods.Controls.Clear();
            dataGridView_Goods.DataSource = BLL_NM.Instance.Get_All_Good_With_Name(textBoxSearch_Goods.Text);
            dataGridView_Goods.Columns["idGood"].Visible = false;
        }
        private void buttonRefreshSystemLog_Click(object sender, EventArgs e)
        {
            LoadSystemLogs();
        }

        private void textBox_SystemLogSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSystemLogs();
        }
        private void LoadBill()
        {
            textBoxBill.Text = "";
            foreach (Bill lbill in BLL_NM.Instance.Get_Bill().OrderByDescending(o => o.idBill))
            {
                if (!lbill.UserName.Contains(texboxSearch_Bills.Text)) continue;
                textBoxBill.Text += "Bill ID: " + lbill.idBill + "\r\n";
                textBoxBill.Text += "Username: " + lbill.UserName + "\r\n";
                textBoxBill.Text += "Time: " + lbill.Date + "\r\n";
                foreach (BillInfo lbillinfo in BLL_NM.Instance.Get_Billinfo_with_idBill(lbill.idBill))
                {
                    textBoxBill.Text += "ID BillIfo: " + lbillinfo.idBillInfo + "    ";
                    textBoxBill.Text += "ID Good: " + lbillinfo.idGood + "    ";
                    textBoxBill.Text += "Good Name: " + BLL_NM.Instance.Text_alignment(BLL_NM.Instance.Get_GoodName(Convert.ToInt32(lbillinfo.idGood.ToString())),20);
                    textBoxBill.Text += "Count: " + lbillinfo.Count + "\r\n";
                }
                textBoxBill.Text += "-----------------------------------------------------\r\n";
            }
        }

        private void textboxBill_Textchanged(object sender, EventArgs e)
        {
            LoadBill();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadBill();
        }
        private void LoadAccounts()
        {
            dataGridView_Account.DataSource = BLL_NM.Instance.Get_Clients_Show(textBoxSearch_Account.Text);
        }

        private void textBoxSearch_Account_TextChanged(object sender, EventArgs e)
        {
            LoadAccounts();
        }

        private void buttonDep_Account_Click(object sender, EventArgs e)
        {
            if (dataGridView_Account.CurrentRow == null) return;
            FormDep fd = new FormDep(dataGridView_Account.CurrentRow.Cells["Username"].Value.ToString());
            fd.Reload_Accounts = LoadAccounts;
            fd.Show();
        }

        private void buttonAdd_Account_Click(object sender, EventArgs e)
        {
            FormAddEditAccount ftemp = new FormAddEditAccount();
            ftemp.Reload_Accounts = LoadAccounts;
            ftemp.Show();
        }

        private void buttonEdit_Account_Click(object sender, EventArgs e)
        {
            if (dataGridView_Account.CurrentRow == null) return;
            FormAddEditAccount ftemp = new FormAddEditAccount(dataGridView_Account.CurrentRow.Cells["Username"].Value.ToString());
            ftemp.Reload_Accounts = LoadAccounts;
            ftemp.Show();
        }

        private void buttonDel_Account_Click(object sender, EventArgs e)
        {
            if (dataGridView_Account.CurrentRow == null) return;
            if (BLL_NM.Instance.GetAccountStatus(dataGridView_Account.CurrentRow.Cells["Username"].Value.ToString()))
            {
                MessageBox.Show("This user is using a computer, can't delete!");
            }
            DialogResult result = MessageBox.Show("Do you really want to delete this account", "Warning", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                BLL_NM.Instance.Delete_Account(dataGridView_Account.CurrentRow.Cells["Username"].Value.ToString());
                LoadAccounts();
                LoadBill();
                LoadSystemLogs();
            }
        }

        private void textBoxSearch_Goods_TextChanged(object sender, EventArgs e)
        {
            Load_DTGrid_Good();
        }

        private void buttonAdd_Goods_Click(object sender, EventArgs e)
        {
            FormAddEditGood fgood = new FormAddEditGood();
            fgood.Reload_Goods = Load_DTGrid_Good;
            fgood.Text = "Add good";
            fgood.Show();
        }

        private void buttonEdit_Goods_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView_Goods.CurrentRow;
            if (dr == null) return;
            FormAddEditGood fgood = new FormAddEditGood(Convert.ToInt32(dr.Cells["idGood"].Value.ToString()));
            fgood.Reload_Goods = Load_DTGrid_Good;
            fgood.Text = "Edit good";
            fgood.Show();
        }

        private void buttonDel_Goods_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView_Goods.CurrentRow;
            if (dr == null) return;
            DialogResult result = MessageBox.Show("Do you really want to delete this Good", "Warning", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                BLL_NM.Instance.Delete_Good(Convert.ToInt32(dr.Cells["idGood"].Value.ToString()));
                Load_DTGrid_Good();
                LoadBill();
            }
        }

        private void buttonAddBill_Click(object sender, EventArgs e)
        {
            FormOrder od = new FormOrder(dataGridView_Account.CurrentRow.Cells["Username"].Value.ToString());
            od.Show();
        }
    }
}