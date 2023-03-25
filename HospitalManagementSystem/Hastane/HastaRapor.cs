using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Hastane
{
    public partial class HastaRapor : Form
    {
        public HastaRapor()
        {
            InitializeComponent();
        }
        public string doktorad;
        public string doktorsoyad;
        private void btn_List_Click(object sender, EventArgs e)
        {
            EntityDoc doc = new EntityDoc();                                    //sadece o doktora 
            doc.Docname = doktorad;                                             //randevusu olan  
            doc.Docsurname = doktorsoyad;                                       //hastaların listelenmesini 
                                                                                //sağlayan kodlar
            List<EntityHst> PerList = LogicHst.LLDoktoraGoreHstList(doc);
            dataGridView1.DataSource = PerList;
        }

        private void listeleme(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;                                         //dataGridView üzerinde
            DataGridViewRow selectedRow = dataGridView1.Rows[index];        //listelenen hastaların
            txt_Rapor.Text = selectedRow.Cells[9].Value.ToString();         //isimlerine tıklandığında raporunun
            textBox1.Text = selectedRow.Cells[0].Value.ToString();          //textBox'a yansıtılmasını sağlayan fonksiyon
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            EntityHst ent = new EntityHst();
            ent.Hstid = Convert.ToInt32(textBox1.Text);
            ent.Rapor = txt_Rapor.Text;                                     //Hasta raporunun
            LogicHst.LLHstGuncelle2(ent);                                   //eklenmesini sağlayan kod bloğu

            EntityDoc doc = new EntityDoc();                                //raporu kaydettikten sonra
            doc.Docname = doktorad;                                         //datagridView üzerine
            doc.Docsurname = doktorsoyad;                                   //aynı hastaların listelenmesini
            List<EntityHst> PerList = LogicHst.LLDoktoraGoreHstList(doc);   //sağlayan kod bloğu
            dataGridView1.DataSource = PerList;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            EntityHst ent = new EntityHst();
            ent.Hstid = Convert.ToInt32(textBox1.Text);
            LogicHst.LLHstSil(ent.Hstid);

            List<EntityHst> PerList = LogicHst.LLHstList();
            dataGridView1.DataSource = PerList;

        }

        private void btn_Mail_Click(object sender, EventArgs e)
        {
            if (txt_Mail.Text==""|| txt_Rapor.Text=="")
            {
                MessageBox.Show("Boş Alan Bırakmayınız !!!");
            }
            else
            {
                MailMessage mesaj = new MailMessage();
                mesaj.From = new MailAddress("yigitkaraoglan81@outlook.com");                                       //Bu kod, kullanıcının girdiği
                mesaj.To.Add(txt_Mail.Text);                                                                        //e-posta ve rapor alanlarının
                mesaj.Subject = "# Karaoğlan Hastanesi Doktor Raporu #";                                            //boş olup olmadığını kontrol eder.
                mesaj.Body = txt_Rapor.Text;                                                                        //Eğer boşsa, kullanıcıya "Boş Alan Bırakmayınız !!!" mesajı gösterir.
                SmtpClient a = new SmtpClient();                                                                    //Eğer alanlar doluysa, kullanıcının girdiği e-posta adresine
                a.Credentials = new System.Net.NetworkCredential("yigitkaraoglan81@outlook.com", "Gorsel123");      //"# Karaoğlan Hastanesi Doktor Raporu #" konulu ve
                a.Port = 587;                                                                                       //içeriği kullanıcının girdiği rapor olan bir e-posta gönderir.
                a.Host = "smtp-mail.outlook.com";                                                                   //E-posta göndermek için SmtpClient sınıfı kullanılır
                a.EnableSsl = true;                                                                                 //ve gönderilirken Outlook.com SMTP sunucusu kullanılır.
                object userState = mesaj;                                                                           //E-posta gönderme sırasında bir hata oluşursa,
                                                                                                                    //kullanıcıya hata mesajı gösterilir.
                try
                {
                    a.SendAsync(mesaj, (object)mesaj);
                    MessageBox.Show("Mail Gönderilmiştir");
                }

                catch (SmtpException ex)
                {

                    System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
                }

            }

        }

        private void btn_Pdf_Click(object sender, EventArgs e)
        {
            string text = txt_Rapor.Text;

            // PDF dosyasının kaydedileceği konumu al
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF dosyası|*.pdf";
            saveFileDialog.Title = "PDF dosyasını kaydet";
            saveFileDialog.ShowDialog();

            // PDF dosyası oluştur
            if (saveFileDialog.FileName != "")
            {
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document document = new Document();
                    PdfWriter.GetInstance(document, fs);
                    document.Open();
                    document.Add(new Paragraph(text));
                    document.Close();
                }
            }
        }

        private void HastaRapor_Load(object sender, EventArgs e)
        {

        }

        private void txtMainMenu_Click(object sender, EventArgs e)
        {
            DocAnaSayfa dok = new DocAnaSayfa();
            dok.doktorad = doktorad;
            dok.doktorsoyad = doktorsoyad;
            dok.Show();
            this.Close();
        }
    }
}
