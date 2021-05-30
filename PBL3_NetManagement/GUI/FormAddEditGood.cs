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
        public FormAddEditGood()
        {
            InitializeComponent();
        }
        public FormAddEditGood(string goodname)
        {
            InitializeComponent();
            Good good = BLL_NM.Instance.Get_Good_With_Name(goodname);
            textBoxNameGood.Text = BLL_NM.Instance.Get_Good_With_Id(good.idGood).GoodName;
            textBoxPriceGood.Text =BLL_NM.Instance.Get_Good_With_Id(good.idGood).GoodPrice.ToString();
            label1.Tag = BLL_NM.Instance.Get_Good_With_Id(good.idGood).idGood;
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
            good.GoodPrice = Convert.ToInt32(textBoxPriceGood.Text);
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
            string temp = textBoxPriceGood.Text;
            for (int i = 0; i < textBoxPriceGood.Text.Length; i++)
            {
                if (!((temp[i] <= '9' && temp[i] >= '0'&& temp[i] <= 57 && temp[i] >= 48) || temp[i] == '.'))
                {
                    MessageBox.Show("Invalid price!");
                    return;
                }
            }
            if (label1.Tag == null)
            {
                Add_Good();
            }
            else
            {
                Edit_Good();
            }
            Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
