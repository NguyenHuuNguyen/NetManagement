using System;
using System.Collections;
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
    public partial class FormOrder : Form
    {
        public delegate void del1();
        public del1 ReEnable;
        public FormOrder(string username)
        {
            this.Text = username;
            InitializeComponent();
            Load_Good();
        }
        public void Load_Good()
        {
            //Add 4 column Id Good, Good Name, Price and Unit
            List<Good> lGood = BLL_NM.Instance.Get_All_Good();
            foreach (Good i in lGood)
            {
                DataGridViewRow dr = new DataGridViewRow();
                DataGridViewCell drcell;

                drcell = new DataGridViewTextBoxCell();
                drcell.Value = i.idGood;
                dr.Cells.Add(drcell);

                drcell = new DataGridViewTextBoxCell();
                drcell.Value = i.GoodName;
                dr.Cells.Add(drcell);

                drcell = new DataGridViewTextBoxCell();
                drcell.Value = i.GoodPrice;
                dr.Cells.Add(drcell);

                drcell = new DataGridViewTextBoxCell();
                drcell.Value = 1;
                dr.Cells.Add(drcell);

                dataGridViewOrder.Rows.Add(dr);
            } 
            //add combobox column
            var ccb = new DataGridViewComboBoxColumn();
            ccb.HeaderText = "Quantity";
            ccb.Name = "combo";
            ccb.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            ccb.ReadOnly = false;
            ArrayList row = new ArrayList();
            for (int i = 0; i <= 10; i++)
            {
                row.Add(i + "");
            }
            ccb.Items.AddRange(row.ToArray());
            dataGridViewOrder.Columns.Add(ccb);
            //
            DataGridViewTextBoxColumn tbc = new DataGridViewTextBoxColumn();
            tbc.HeaderText = "Sub Total";
            tbc.Name = "subTotal";
            tbc.ReadOnly = true;
            
            dataGridViewOrder.Columns.Add(tbc);

            for (int i = 0; i <= (lGood.Count - 1); i++)
            {
                dataGridViewOrder.Rows[i].Cells[5].Value = 0;
            }
            textBoxOrder.Text = "0";
        }
        private void datagridviewOrder_EditingControlShowing(object sender,DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridViewOrder.CurrentCell.ColumnIndex == 4)
            {
                // Check box column
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
            }
        }

        void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Count 1
            int quantity = ((ComboBox)sender).SelectedIndex;
            double price = Convert.ToDouble(dataGridViewOrder.CurrentRow.Cells["Price"].Value.ToString());
            dataGridViewOrder.CurrentRow.Cells["subTotal"].Value = (price * quantity).ToString();
            // Count all
            double total = 0;
            for (int i = 0; i <= (dataGridViewOrder.Rows.Count - 1); i++)
            {
                string data = dataGridViewOrder.Rows[i].Cells[5].Value.ToString();
                total += Convert.ToDouble(data);
            }
            textBoxOrder.Text = total.ToString();
        }

        private void buttonCancel_Order_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        private void Cancel()
        {
            ReEnable();
            this.Dispose();
        }

        private void buttonOrder_Order_Click(object sender, EventArgs e)
        {
            // kiểm tra nếu dữ liệu thay đổi thì huỷ
            for (int i = 0; i <= (dataGridViewOrder.Rows.Count - 1); i++)
            {
                int idGood = Convert.ToInt32(dataGridViewOrder.Rows[i].Cells[0].Value.ToString());
                string namegood = dataGridViewOrder.Rows[i].Cells[1].Value.ToString();
                double price = Convert.ToDouble(dataGridViewOrder.Rows[i].Cells[2].Value.ToString());
                if (BLL_NM.Instance.GoodCheck(idGood, namegood, price) == false)
                {
                    MessageBox.Show("There was some changes in the data, aborting!");
                    ReEnable();
                    this.Dispose();
                    return;
                }
            }

            if (textBoxOrder.Text == "0")
            {
                MessageBox.Show("You haven't order anything yet!");
            }
            else
            {
                //
                DateTime date = DateTime.Now;
                //Add Bill to SQL
                BLL_NM.Instance.Add_Bill(date, this.Text);
                //Add BillInfo to SQL
                int idBill = BLL_NM.Instance.Get_idBill(date, this.Text);
                for (int i = 0; i <= (dataGridViewOrder.Rows.Count - 1); i++)
                {
                    double subtotal = Convert.ToDouble(dataGridViewOrder.Rows[i].Cells[5].Value.ToString());
                    if (subtotal != 0)
                    {
                        int count = Convert.ToInt32(dataGridViewOrder.Rows[i].Cells[4].Value.ToString());
                        int idgood = Convert.ToInt32(dataGridViewOrder.Rows[i].Cells[0].Value.ToString());
                        BLL_NM.Instance.Add_BillInfo(idBill, idgood, count);
                    }
                }
                ReEnable();
                this.Dispose();
            }
        }

        private void FormOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cancel();
        }
    }
}
