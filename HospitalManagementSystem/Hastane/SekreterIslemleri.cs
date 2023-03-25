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
    public partial class SekreterIslemleri : Form
    {
        public SekreterIslemleri()
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
            DataGridViewRow selectedRow = dataGridView1.Rows[index];            //Bu kod bloğu, dataGridView üzerinde
            textBox1.Text = selectedRow.Cells[0].Value.ToString();              //tıklanan sekreterin tüm bilgilerini
            txt_SekreterAdi.Text = selectedRow.Cells[1].Value.ToString();       //gerekli textBoxların
            txt_SekreterSoyadi.Text = selectedRow.Cells[2].Value.ToString();    //üzerine çekilmesini sağlar
            txt_Telefon.Text = selectedRow.Cells[3].Value.ToString();
            txt_Username.Text = selectedRow.Cells[4].Value.ToString();
            txt_Password.Text = selectedRow.Cells[5].Value.ToString();
        }

        private void SekreterEkle_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;                       //Sekreter ID'si primary key olduğu için değiştirilebilir
        }                                                   //olmaması gerekiyor. Bu yüzden ID textboxu readonly yapılır.

        private void btn_List_Click(object sender, EventArgs e)
        {
            List<EntitySec> PerList = LogicSec.LLSecList();
            dataGridView1.DataSource = PerList;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            EntitySec ent = new EntitySec();
            ent.Secname = txt_SekreterAdi.Text;
            ent.Secsurname = txt_SekreterSoyadi.Text;
            ent.Secphone = txt_Telefon.Text;
            ent.Secusername = txt_Username.Text;
            ent.Secpassword = txt_Password.Text;
            LogicSec.LLSecEkle(ent);

            List<EntitySec> PerList = LogicSec.LLSecList();
            dataGridView1.DataSource = PerList;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (txt_SekreterAdi.Text == "" || txt_SekreterSoyadi.Text == "" || txt_Telefon.Text == "" +
               ""|| txt_Username.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Hiçbir Alan Boş Bırakılamaz", "!!!");      //Kodun amacı, kullanıcının girdiği bilgilerin
            }                                                               //doğruluğunu kontrol etmek ve bilgileri güncellemek
            else                                                            //için kullanılıyor. Öncelikle, kullanıcının formdaki
            {                                                               //bazı metin alanlarının boş olup olmadığı kontrol edilir.
                EntitySec ent = new EntitySec();                            //Eğer herhangi bir alan boş bırakılmışsa, kullanıcıya
                ent.Secid = Convert.ToInt32(textBox1.Text);                 //"Hiçbir Alan Boş Bırakılamaz" mesajı gösterilir.
                ent.Secname = txt_SekreterAdi.Text;                         //Eğer tüm alanlar doldurulmuşsa, bir "EntitiySec" adlı
                ent.Secsurname = txt_SekreterSoyadi.Text;                   //sınıfın nesnesi oluşturulur ve bu nesnenin özellikleri
                ent.Secphone = txt_Telefon.Text;                            //kullanıcı tarafından girilen bilgilerle doldurulur.
                ent.Secusername = txt_Username.Text;                        //daha sonra, "LogicSec" adlı sınıfın "LLSecGuncelle" metodu çağrılır
                ent.Secpassword = txt_Password.Text;                        //ve oluşturulan "EntitySec" nesnesi metodun parametresi olarak gönderilir.
                LogicSec.LLSecGuncelle(ent);                                //Bu metodun amacı, veritabanındaki bilgileri güncellemektir.
                                                                            //Son olarak, "LogicSec" sınıfının "LLSecList" metodu çağrılır
                List<EntitySec> PerList = LogicSec.LLSecList();             //ve geri dönen liste "dataGridView" adlı bir nesnenin
                dataGridView1.DataSource = PerList;                         //veri kaynağı olarak atanır. Bu sayede kullanıcı
            }                                                               //veritabanındaki bilgileri güncellediğinde, dataGridView'a
        }                                                                   //güncellenen bilgiler yansıtılmış olur.

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            EntitySec ent = new EntitySec();
            ent.Secid = Convert.ToInt32(textBox1.Text);
            LogicSec.LLSecSil(ent.Secid);

            List<EntitySec> PerList = LogicSec.LLSecList();
            dataGridView1.DataSource = PerList;
        }

        private void txt_Telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))                 //bu kod bloğu telefon
            {                                                                           //numarasının girildiği textboxun
                e.Handled = true;                                                       //sadece sayılardan oluşmasını sağlar.
            }                                                                           //Ayrıca telefon numaraları 11
                                                                                        //karakterden oluştuğu için textbox
            int maxLength = 11;                                                         //içine maksimum 11 karakter girilebilmesini sağlar.
            if (txt_Telefon.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
