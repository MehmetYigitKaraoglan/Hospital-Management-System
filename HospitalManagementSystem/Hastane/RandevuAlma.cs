using DataAccessLayer;
using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class RandevuAlma : Form
    {
        public RandevuAlma()
        {
            InitializeComponent();
        }

        private void RandevuAlma_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_HastaAdi.Text == "" || txt_HastaSoyadi.Text == "" || txt_TCKN.Text == "" || txt_Telefon.Text == "" +
                "" || comboBox_Bolum.Text == "" || comboBox_Doktoradi.Text == "" || comboBox_Saat.Text == "" || comboBox_Dakika.Text == "")
            {
                MessageBox.Show("Hiçbir alan boş bırakılamaz!!!");
            }
            else
            {
                EntityHst ent = new EntityHst();                                //Bu kod parçası, kullanıcının belirli alanları doldurmasını kontrol eder                                   
                ent.Hstname = txt_HastaAdi.Text;                                //Eğer kullanıcı herhangi bir alanı boş bırakırsa, uyarı mesajı görüntülenir.
                ent.Hstsurname = txt_HastaSoyadi.Text;                          //Eğer tüm alanlar doldurulmuşsa, kullanıcının girdiği bilgiler
                ent.Hsttckn = txt_TCKN.Text;                                    //"EntitiesHst" adlı sınıfın nesnesine atılır ve "LogicHst.LLHstEkle" metodu çağrılır.
                ent.Hstphone = txt_Telefon.Text;                                //Bu metod, kullanıcının girdiği bilgileri veritabanına ekler.
                ent.Hstbolum = comboBox_Bolum.Text;                             //Son olarak, kullanıcıya "Randevu başarıyla kaydedilmiştir" mesajı gösterilir.
                ent.Docname = comboBox_Doktoradi.Text;
                ent.Tarih = dateTimePicker1.Value;
                ent.Saat = comboBox_Saat.Text + ":" + comboBox_Dakika.Text;
                ent.Rapor = " ";
                LogicHst.LLHstEkle(ent);

                MessageBox.Show("Randevu başarıyla kaydedilmiştir.");
            }
           
        }
        private void comboBox_Bolum1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Doktoradi.Items.Clear();
            SqlDataReader dr = LogicHst.LLFilter(comboBox_Bolum.Text);              //bu kod parçası, seçilen bölüme göre
            while (dr.Read())                                                       //doktorların doktoradi comboBox'unda listelenmesini
            {                                                                       //sağlar.
                comboBox_Doktoradi.Items.Add(dr["DocAD"] + " " + dr["DocSOYAD"]);
            }
            DALHst.dr.Close();
        }

        private void txt_TCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;                                                        //bu kod parçası kimlik numarası ve telefon numarası
            }                                                                            //alanlarına harf girilmemesini ve en fazla
                                                                                         //11 karakter girilmesini sağlar.
            int maxLength = 11;
            if (txt_TCKN.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_Telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            int maxLength = 11;
            if (txt_Telefon.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtMainMenu_Click(object sender, EventArgs e)
        {
            SecAnaSayfa secAnaSayfa = new SecAnaSayfa();
            secAnaSayfa.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday || dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Hafta sonları seçilemez!");                //dateTimePicker üzerinde hafta sonunun
                dateTimePicker1.Value = DateTime.Now.AddDays(2);            //seçilmemesini sağlar
            }
        }
    }
}
