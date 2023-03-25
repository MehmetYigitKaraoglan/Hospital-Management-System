using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;
using System.Data.SqlClient;

namespace Hastane
{
    public partial class DocLogin : Form
    {
        public DocLogin()
        {
            InitializeComponent();
        }

        private void clearFieldsTxt_Click(object sender, EventArgs e)
        {
            txtUser.Clear();    // Username girilen textboxtaki metni silmeye yarayan kod
            txtPw.Clear();      // Şifre girilen textboxtaki metni silmeye yarayan kod
            txtUser.Focus();    // Username girilen textboxa odaklanılmasını sağlayan kod
        }

        private void exitTxt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ShowPw_Click(object sender, EventArgs e)
        {

            if (txtPw.PasswordChar == '*')
            {
                btn_HidePw.BringToFront();
                txtPw.PasswordChar = '\0';
            }

        }


        private void btn_HidePw_Click(object sender, EventArgs e)
        {
            if (txtPw.PasswordChar == '\0')
            {
                btn_ShowPw.BringToFront();
                txtPw.PasswordChar = '*';
            }


        }
        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals(@"Kullanıcı Adınız"))
            {
                txtUser.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals(@""))
            {
                txtUser.Text = "Kullanıcı Adınız";
            }
        }

        private void txtPwEnter(object sender, EventArgs e)
        {
            if (txtPw.Text.Equals(@"********"))
            {
                txtPw.Text = "";
            }
        }

        private void txtPwLeave(object sender, EventArgs e)
        {
            if (txtPw.Text.Equals(@""))
            {
                txtPw.Text = "********";
            }
        }

        private void mainmenuTxt_Click(object sender, EventArgs e)
        {
            Opening loginScreen = new Opening();
            loginScreen.Show();
            this.Hide();
        }

        private void DocLogin_Load(object sender, EventArgs e)
        {
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            EntityDoc ent = new EntityDoc();
            ent.Docusername = txtUser.Text;
            ent.Docpassword = txtPw.Text;
            if (txtUser.Text == "Kullanıcı Adınız" || txtPw.Text == "********") //başlangıçtaki metin değiştirilmediği zaman
            {                                                                   //hata ekranının ortaya çıkması için
                MessageBox.Show("Kullanıcı Adı ya da şifre boş bırakılamaz!!"); //gerekli kod bloğu
            }
            else
            {
                if (LogicDoc.LLDoktorGiris(ent) == 1)
                {
                    SqlCommand a = LogicDoc.LLDoktorAdıCek(ent);    //doktor ana sayfasında
                    string ad = (string)a.ExecuteScalar();          //giriş yapan doktorun
                    SqlCommand b = LogicDoc.LLDoktorSoyadıCek(ent); //adının ve soyadının yazmasını
                    string soyad = (string)b.ExecuteScalar();       //sağlayan kod bloğu

                    DocAnaSayfa docAnaSayfa = new DocAnaSayfa();
                    docAnaSayfa.doktorad = ad;
                    docAnaSayfa.doktorsoyad = soyad;
                    docAnaSayfa.Show();
                    this.Hide();
                }
                else if (LogicDoc.LLDoktorGiris(ent) == 2)
                {
                    MessageBox.Show("Kullanıcı adı ya da şifreniz hatalıdır. Lütfen kullanıcı adınızı ya da şifrenizi kontrol ediniz!");
                }
            }
        }
    }
}