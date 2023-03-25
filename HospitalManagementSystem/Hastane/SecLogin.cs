using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class SecLogin : Form
    {
        public SecLogin()
        {
            InitializeComponent();
        }

        private void clearFieldsTxt2_Click(object sender, EventArgs e)
        {
            txtUser2.Clear();
            txtPw2.Clear();
            txtUser2.Focus();
        }

        private void exitTxt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SecLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUserEnter2(object sender, EventArgs e)
        {
            if (txtUser2.Text.Equals(@"Kullanıcı Adınız"))
            {
                txtUser2.Text = "";
            }
        }

        private void txtUserLeave2(object sender, EventArgs e)
        {
            if (txtUser2.Text.Equals(@""))
            {
                txtUser2.Text = "Kullanıcı Adınız";
            }
        }
        private void txtPwLeave2(object sender, EventArgs e)
        {
            if (txtPw2.Text.Equals(@""))
            {
                txtPw2.Text = "********";
            }
        }

        private void txtPwEnter2(object sender, EventArgs e)
        {
            if (txtPw2.Text.Equals(@"********"))
            {
                txtPw2.Text = "";
            }
        }
        private void btn_ShowPw_Click(object sender, EventArgs e)
        {
            if (txtPw2.PasswordChar == '*')
            {
                btn_HidePw.BringToFront();
                txtPw2.PasswordChar = '\0';
            }
        }

        private void btn_HidePw_Click(object sender, EventArgs e)
        {
            if (txtPw2.PasswordChar == '\0')
            {
                btn_ShowPw.BringToFront();
                txtPw2.PasswordChar = '*';
            }
        }

        private void mainmenuTxt_Click(object sender, EventArgs e)
        {
            Opening loginScreen = new Opening();
            loginScreen.Show();
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            EntitySec ent = new EntitySec();
            ent.Secusername = txtUser2.Text;
            ent.Secpassword = txtPw2.Text;
            if (txtUser2.Text == "Kullanıcı Adınız" || txtPw2.Text == "********")
            {
                MessageBox.Show("Kullanıcı Adı ya da şifre boş bırakılamaz!!");
            }
            else
            {
                if (LogicSec.LLSecGiris(ent) == 1)
                {
                    SecAnaSayfa secAnaSayfa = new SecAnaSayfa();
                    secAnaSayfa.Show();
                    this.Close();
                }
                else if (LogicSec.LLSecGiris(ent) == 2)
                {
                    MessageBox.Show("Kullanıcı adı ya da şifreniz hatalıdır. Lütfen kullanıcı adınızı ya da şifrenizi kontrol ediniz!");
                }
            }
        }
    }
}