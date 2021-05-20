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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            if (BLL_NM.Instance.AccountCheck(textBoxUsername.Text, textBoxPassword.Text))
            {
                //địa chỉ ip của computer phải có trong hệ thống
                if (!BLL_NM.Instance.ComputerCheck(BLL_NM.Instance.Get_idComputer()))
                {
                    MessageBox.Show("This computer is not registed!");
                    return;
                }
                //nếu máy đã đang sử dụng (đã đăng nhập rồi) thì huỷ k cho đăng nhập nữa
                if (BLL_NM.Instance.GetComputerStatus(BLL_NM.Instance.Get_idComputer()))
                {
                    MessageBox.Show("This computer is already in use!");
                    return;
                }
                //tài khoản đang không sử dụng
                if (BLL_NM.Instance.GetAccountStatus(textBoxUsername.Text))
                {
                    MessageBox.Show("This account is already in use!");
                    return;
                }
                //xác thực tài khoản và mật khẩu
                if (!BLL_NM.Instance.AccountTypeCheck(textBoxUsername.Text))
                {
                    //tk phải có tiền vì đây là User
                    if (BLL_NM.Instance.GetAccountBalance(textBoxUsername.Text) == 0)
                    {
                        MessageBox.Show("Your balance is 0!");
                        return;
                    }
                    FormUsercs fu = new FormUsercs(textBoxUsername.Text);
                    fu.Show();
                    fu.SetVisible_Login = SetVisible;
                    this.Visible = false;
                }
                else
                {
                    //code cho form admin ở đây
                }
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect!");
            }
        }
        public void SetVisible()
        {
            this.Visible = true;
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) Login();
        }

    }
}
