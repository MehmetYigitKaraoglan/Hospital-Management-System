using EntityLayer;
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
    public partial class Grafik1 : Form
    {
        public Grafik1()
        {
            InitializeComponent();
        }

        private void Grafik1_Load(object sender, EventArgs e)
        {


            /* "string[] bolumler" değişkeni,
            bölümleri içeren bir dizi oluşturur.
            "int lenght" değişkeni, dizinin uzunluğunu tutar.
            Döngü, dizinin uzunluğunca döner ve her döngüde,
            LogicLayer.LogicDoc.LLBolumHastaSayisiCek() metodu ile
            veritabanından bölümler için hasta sayılarını çeken
            "SqlCommand b" değişkeni oluşturulur. "b.ExecuteScalar()" ile
            veritabanından çekilen hasta sayısı "Int32 sayi" değişkenine atanır.
            Son olarak, "chart1.Series[bolumler[a]].Points.AddXY(a+1, sayi)" ile
            grafikte bölümlerin hasta sayılarını gösteren noktalar eklenir.
            */
            string[] bolumler = {"Dahiliye", "Kulak-Burun-Boğaz", "Psikiyatri", "Üroloji", "Genel Cerrahi", "Kardiyoloji" };
            int lenght=bolumler.Length;
            
            for(int a =0; a < lenght; a++)
            {
                SqlCommand b = LogicLayer.LogicDoc.LLBolumHastaSayisiCek(bolumler[a]);
                Int32 sayi = (Int32)b.ExecuteScalar();
                chart1.Series[bolumler[a]].Points.AddXY(a+1, sayi);
            }
        }
    }
}
