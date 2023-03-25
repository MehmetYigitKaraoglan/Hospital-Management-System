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
    public partial class DocAnaSayfa : Form
    {
        public DocAnaSayfa()
        {
            InitializeComponent();
        }

        public string doktorad;
        public string doktorsoyad;

        private void txt_MainMenu_Click(object sender, EventArgs e)
        {
            Opening loginScreen = new Opening();        //Ana menü butonuna basıldığında
            loginScreen.Show();                         //Açılış ekranına yönlendirmeyi
            this.Close();                               //Sağlayan kod bloğu
        }

        private void btn_HstIslem_Click(object sender, EventArgs e)
        {
            HastaRapor hastaislem = new HastaRapor();   //Hasta İşlemleri butonuna basıldığında
            hastaislem.Show();                          //Hasta Rapor ekranına yönlendirmeyi sağlar

            hastaislem.doktorad = this.doktorad;        //Bu iki satırdaki kodlar doktora göre hasta
            hastaislem.doktorsoyad = this.doktorsoyad;  //İsimlerinin gelmesini sağlar
            this.Close();
        }

        private void btn_Grafik1_Click(object sender, EventArgs e)
        {
            Grafik1 grafik1 = new Grafik1();            //Grafik gösterimi formuna
            grafik1.Show();                             //yönlendirmeyi sağlar
            this.Close();
        }

        private void DocAnaSayfa_Load(object sender, EventArgs e)
        {
            label2.Text = doktorad+" "+doktorsoyad;     //Hoş geldiniz Mehmet Yiğit Karaoğlan metninin yazılmasını sağlar
        }
    }
}
