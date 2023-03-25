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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane
{
    public partial class RandevuUpdate : Form
    {
        public RandevuUpdate()
        {
            InitializeComponent();
        }

        private void txtMainMenu_Click(object sender, EventArgs e)
        {
            SecAnaSayfa secAnaSayfa = new SecAnaSayfa();
            secAnaSayfa.Show();
            this.Hide();
        }

        private void HastaEkle_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }
        string saat;
        string dakika;
        private void listeleme(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();                      //Bu kod bloğu, dataGridView üzerinde
            txt_HastaAdi.Text = selectedRow.Cells[1].Value.ToString();                  //tıklanan hastanın tüm bilgilerini
            txt_HastaSoyadi.Text = selectedRow.Cells[2].Value.ToString();               //gerekli textBox, comboBox ve
            txt_TCKN.Text = selectedRow.Cells[3].Value.ToString();                      //dateTimePicker üzerine çekilmesini sağlar
            txt_Telefon.Text = selectedRow.Cells[4].Value.ToString();
            comboBox_Bolum.Text = selectedRow.Cells[5].Value.ToString();
            comboBox_Doktoradi.Text = selectedRow.Cells[6].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells[7].Value);
            saat = selectedRow.Cells[8].Value.ToString();
            saat = saat.Substring(0, 2);
            comboBox_Saat.Text = saat;
            dakika = selectedRow.Cells[8].Value.ToString();
            dakika = dakika.Substring(3);
            comboBox_Dakika.Text = dakika;
        }

        private void comboBox_Bolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Doktoradi.Items.Clear();
            SqlDataReader dr = LogicHst.LLFilter(comboBox_Bolum.Text);                  //bu kod bloğu, Bölüm comboBoxundaki  
            while (dr.Read())                                                           //seçilen bölüme göre doktorların
            {                                                                           //doktor comboBoxında listelenmesini sağlar
                comboBox_Doktoradi.Items.Add(dr["DocAD"] + " " + dr["DocSOYAD"]);
            }
            DALHst.dr.Close();
        }
        private void btn_List_Click(object sender, EventArgs e)
        {
            List<EntityHst> PerList = LogicHst.LLHstList();
            dataGridView1.DataSource = PerList;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {


            if (txt_HastaAdi.Text == ""||txt_HastaSoyadi.Text ==""||txt_TCKN.Text==""||txt_Telefon.Text=="" +
                ""||comboBox_Bolum.Text == ""||comboBox_Doktoradi.Text==""||comboBox_Saat.Text==""||comboBox_Dakika.Text=="")
            {
                MessageBox.Show("Hiçbir Alan Boş Bırakılamaz", "!!!");
            }
            else
            {
                EntityHst ent = new EntityHst();
                ent.Hstid = Convert.ToInt32(textBox1.Text);
                ent.Hstname = txt_HastaAdi.Text;
                ent.Hstsurname = txt_HastaSoyadi.Text;
                ent.Hsttckn = txt_TCKN.Text;
                ent.Hstphone = txt_Telefon.Text;
                ent.Hstbolum = comboBox_Bolum.Text;
                ent.Docname = comboBox_Doktoradi.Text;
                ent.Tarih = dateTimePicker1.Value;
                ent.Saat = comboBox_Saat.Text + ":" + comboBox_Dakika.Text;
                LogicHst.LLHstGuncelle(ent);

                List<EntityHst> PerList = LogicHst.LLHstList();
                dataGridView1.DataSource = PerList;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            EntityHst ent = new EntityHst();
            ent.Hstid = Convert.ToInt32(textBox1.Text);
            LogicHst.LLHstSil(ent.Hstid);

            List<EntityHst> PerList = LogicHst.LLHstList();
            dataGridView1.DataSource = PerList;
        }

        private void txt_TCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

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
    }
}
