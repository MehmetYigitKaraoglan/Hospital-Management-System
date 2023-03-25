using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane
{
    public partial class DoktorIslemleri : Form
    {
        public DoktorIslemleri()
        {
            InitializeComponent();
        }
        private void txtMainMenu_Click(object sender, EventArgs e)
        {
            SecAnaSayfa secAnaSayfa = new SecAnaSayfa();
            secAnaSayfa.Show();
            this.Hide();
        }

        private void listeleme(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();              //Bu kod bloğu, dataGridView üzerinde
            txt_DoktorAdi.Text = selectedRow.Cells[1].Value.ToString();         //tıklanan sekreterin tüm bilgilerini
            txt_DoktorSoyadi.Text = selectedRow.Cells[2].Value.ToString();      //gerekli textBoxların
            comboBox_Bolum.Text = selectedRow.Cells[3].Value.ToString();        //üzerine çekilmesini sağlar
            txt_Telefon.Text = selectedRow.Cells[4].Value.ToString();
            txt_Username.Text = selectedRow.Cells[5].Value.ToString();
            txt_Password.Text = selectedRow.Cells[6].Value.ToString();
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {                                                       //Doktor ID'si primary key olduğu için değiştirilebilir
            textBox1.ReadOnly = true;                           //olmaması gerekiyor. Bu yüzden ID textboxu readonly yapılır.
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            List<EntityDoc> PerList = LogicDoc.LLDocList();
            dataGridView1.DataSource = PerList;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (txt_DoktorAdi.Text == "" || txt_DoktorSoyadi.Text == "" ||txt_Telefon.Text == "" +
             "" || comboBox_Bolum.Text == "" || txt_Username.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Hiçbir Alan Boş Bırakılamaz", "!!!");          
            }                                                                   
            else                                                                
            {                                                                   
                EntityDoc ent = new EntityDoc(); 
                ent.Docid = Convert.ToInt32(textBox1.Text);                    
                ent.Docname = txt_DoktorAdi.Text;                              
                ent.Docsurname = txt_DoktorSoyadi.Text;                        
                ent.Docbranch = comboBox_Bolum.Text;                            
                ent.Docphone = txt_Telefon.Text;                               
                ent.Docusername = txt_Username.Text;                           
                ent.Docpassword = txt_Password.Text;                           
                LogicDoc.LLDocGuncelle(ent);                                    
                                                                         
                List<EntityDoc> PerList = LogicDoc.LLDocList();                 
                dataGridView1.DataSource = PerList;                            
            }                                                                   
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            EntityDoc ent = new EntityDoc();                      //Bu kod parçacığı, bir EntityDoc
            ent.Docid = Convert.ToInt32(textBox1.Text);           //nesnesi oluşturur ve Docid özelliğini
            LogicDoc.LLDocSil(ent.Docid);                         //textBox1'den alınan değerle atar. Ardından,
                                                                  //LogicDoc sınıfındaki LLDocSil metodu bu Docid değerini
            List<EntityDoc> PerList = LogicDoc.LLDocList();       //kullanarak belirli doktoru siler. Daha sonra, LogicDoc
            dataGridView1.DataSource = PerList;                   //sınıfındaki LLDocList metodu kullanılarak doktorların listesi
        }                                                         //alınır ve dataGridView1 içinde listelenir.

        private void btn_Add_Click(object sender, EventArgs e)
        {
            EntityDoc ent = new EntityDoc();
            ent.Docname = txt_DoktorAdi.Text;
            ent.Docsurname = txt_DoktorSoyadi.Text;
            ent.Docbranch = comboBox_Bolum.Text;
            ent.Docphone = txt_Telefon.Text;
            ent.Docusername = txt_Username.Text;
            ent.Docpassword = txt_Password.Text;
            LogicDoc.LLDocEkle(ent);

            List<EntityDoc> PerList = LogicDoc.LLDocList();
            dataGridView1.DataSource = PerList;
        }

        private void txt_Telefon_KeyPress(object sender, KeyPressEventArgs e)
        {                                                                               //bu kod bloğu telefon
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))                 //numarasının girildiği textboxun
            {                                                                           //sadece sayılardan oluşmasını sağlar.
                e.Handled = true;                                                       //Ayrıca telefon numaraları 11
            }                                                                           //karakterden oluştuğu için textbox
                                                                                        //içine maksimum 11 karakter girilebilmesini sağlar.
            int maxLength = 11;
            if (txt_Telefon.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
