using PBL3_NetManagement.BLL;
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
    public partial class FormAddEditGood : Form
    {
        public delegate void del1();
        public del1 Reload_Goods;
        public del1 ReEnable;
        public FormAddEditGood()
        {
            InitializeComponent();
        }
        public FormAddEditGood(int idgood)
        {
            InitializeComponent();
            textBoxNameGood.Text = BLL_NM.Instance.Get_Good_With_Id(idgood).GoodName;
            textBoxPriceGood.Text =BLL_NM.Instance.Get_Good_With_Id(idgood).GoodPrice.ToString();
            label1.Tag = BLL_NM.Instance.Get_Good_With_Id(idgood).idGood;
        }
        private void Add_Good()
        {
            if (BLL_NM.Instance.Check_Name_Good(textBoxNameGood.Text) == true)
            {
                MessageBox.Show("This Name is already existed!");
                return;
            }
            Good good = new Good();
            good.GoodName = textBoxNameGood.Text;
            good.GoodPrice = Convert.ToDouble(textBoxPriceGood.Text);
            BLL_NM.Instance.Add_Good(good);
        }
        private void Edit_Good()
        {
            Good good = new Good();
            good.idGood = Convert.ToInt32(label1.Tag.ToString());
            good.GoodName = textBoxNameGood.Text;
            good.GoodPrice = Convert.ToDouble(textBoxPriceGood.Text);
            BLL_NM.Instance.Edit_Good(good);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
         
            if (textBoxNameGood.Text == "")
            {
                MessageBox.Show("Good's name can not be blank!");
                return;
            }
            if (textBoxPriceGood.Text == "")
            {
                MessageBox.Show("Good's price can not be blank!");
                return;
            }
            if (Convert.ToDouble(textBoxPriceGood.Text) == 0)
            {
                MessageBox.Show("Good's price can not be zero!");
                return;
            }
            string temp = textBoxPriceGood.Text;
            if (temp[0] == '.')
            {
                MessageBox.Show("Invalid price!");
                return;
            }
            for (int i = 0; i < textBoxPriceGood.Text.Length; i++)
            {
                if (!((temp[i] <= '9' && temp[i] >= '0') || temp[i] == '.'))
                {
                    MessageBox.Show("Invalid price!");
                    return;
                }

            }
            if (textBoxNameGood.Text.Length > 50)
            {
                MessageBox.Show("Good's name is too long!");
                return;
            }
            if (textBoxPriceGood.Text.Length > 20)
            {
                MessageBox.Show("Invalid price!");
                return;
            }
            if (label1.Tag == null)
            {
                Add_Good();
            }
            else
            {
                Edit_Good();
            }
            ReEnable();
            Reload_Goods();
            Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        private void Cancel()
        {
            ReEnable();
            Dispose();
        }
        private void FormAddEditGood_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cancel();
        }

    }
}
