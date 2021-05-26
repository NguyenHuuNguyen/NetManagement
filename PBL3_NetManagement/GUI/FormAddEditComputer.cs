using PBL3_NetManagement.BLL;
using PBL3_NetManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_NetManagement.GUI
{
    public partial class FormAddEditComputer : Form
    {
        Computer computertemp;
        public FormAddEditComputer()
        {
            InitializeComponent();
        }
        public FormAddEditComputer(Computer computer)
        {
            this.Text = "Edit Computer";
            InitializeComponent();
            computertemp = computer;
            textBoxIP.Text = computertemp.idComputer;
            textBoxName.Text = computertemp.ComputerName;
            textBoxPrice.Text = computertemp.ComputerPrice.ToString();
            textBoxIP.Enabled = false;
        }
        private void Add_Computer()
        {
            if (BLL_NM.Instance.ComputerCheck(textBoxIP.Text)){
                MessageBox.Show("This IP is already existed!");
                return;
            }
            Computer cpt = new Computer();
            cpt.idComputer = textBoxIP.Text;
            cpt.ComputerName = textBoxName.Text;
            cpt.ComputerPrice = Convert.ToDouble(textBoxPrice.Text);
            BLL_NM.Instance.Add_Computer(cpt);
        }
        private void Edit_Computer()
        {
            Computer cpt = new Computer();
            cpt.idComputer = textBoxIP.Text;
            cpt.ComputerName = textBoxName.Text;
            cpt.ComputerPrice = Convert.ToDouble(textBoxPrice.Text);
            BLL_NM.Instance.Edit_Computer(cpt);
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {

            if (textBoxIP.Text == "")
            {
                MessageBox.Show("IP can not be blank!");
                return;
            }
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Computer's name can not be blank!");
                return;
            }
            if (textBoxPrice.Text == "")
            {
                MessageBox.Show("Computer price can not be blank!");
                return;
            }
            string temp = textBoxPrice.Text;
            for (int i = 0; i < textBoxPrice.Text.Length; i++)
            {
                if (!((temp[i] <= '9' && temp[i] >= '0') || temp[i] == '.'))
                {
                    MessageBox.Show("Invalid price!");
                    return;
                }

            }
            if (textBoxIP.Enabled==true)
            {
                Add_Computer();
            }
            else
            {
                Edit_Computer();
            }
           
            Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
