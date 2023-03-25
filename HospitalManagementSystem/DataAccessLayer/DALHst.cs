using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace DataAccessLayer
{
    public class DALHst
    {
        public static SqlDataReader dr;

        public static List<EntityHst> DALHstList()
        {

            List<EntityHst> degerler = new List<EntityHst>();
            SqlCommand komut1 = new SqlCommand("Select * from HastaBilgi", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {

                komut1.Connection.Open();
            }
            SqlDataReader hst = komut1.ExecuteReader();
            while (hst.Read())
            {
                EntityHst ent = new EntityHst();
                ent.Hstid = int.Parse(hst["HastaID"].ToString());
                ent.Hstname = hst["HastaAD"].ToString();
                ent.Hstsurname = hst["HastaSOYAD"].ToString();
                ent.Hsttckn = hst["HastaTCKN"].ToString();
                ent.Hstphone = hst["HastaTELEFON"].ToString();
                ent.Hstbolum = hst["HastaBÖLÜM"].ToString();
                ent.Docname = hst["DoktorADI"].ToString();
                ent.Tarih = Convert.ToDateTime(hst["Tarih"]);
                ent.Saat = hst["Saat"].ToString();
                ent.Rapor = hst["Rapor"].ToString();
                degerler.Add(ent);
            }
            hst.Close();
            return degerler;
        }

        public static int HstEkle(EntityHst p)
        {
            SqlCommand komut2 = new SqlCommand("insert into HastaBilgi(HastaAD,HastaSOYAD,HastaTCKN,HastaTELEFON,HastaBÖLÜM,DoktorADI,Tarih,Saat,Rapor) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p.Hstname);
            komut2.Parameters.AddWithValue("@P2", p.Hstsurname);
            komut2.Parameters.AddWithValue("@P3", p.Hsttckn);
            komut2.Parameters.AddWithValue("@P4", p.Hstphone);
            komut2.Parameters.AddWithValue("@P5", p.Hstbolum);
            komut2.Parameters.AddWithValue("@P6", p.Docname);
            komut2.Parameters.AddWithValue("@P7", p.Tarih);
            komut2.Parameters.AddWithValue("@P8", p.Saat);
            komut2.Parameters.AddWithValue("@P9", p.Rapor);
            return komut2.ExecuteNonQuery();
        }
        public static bool HstSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete from HastaBilgi where HASTAID = @P1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static bool HstGuncelle(EntityHst ent)
        {
            SqlCommand komut4 = new SqlCommand("Update HastaBilgi SET HastaAD=@P1,HastaSOYAD = @P2,HastaTCKN=@P3,HastaTELEFON=@P4,HastaBÖLÜM=@P5 ,DoktorADI=@P6,Tarih = @P7,Saat =@P8 WHERE HASTAID= @P9", Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", ent.Hstname);
            komut4.Parameters.AddWithValue("@P2", ent.Hstsurname);
            komut4.Parameters.AddWithValue("@P3", ent.Hsttckn);
            komut4.Parameters.AddWithValue("@P4", ent.Hstphone);
            komut4.Parameters.AddWithValue("@P5", ent.Hstbolum);
            komut4.Parameters.AddWithValue("@P6", ent.Docname);
            komut4.Parameters.AddWithValue("@P7", ent.Tarih);
            komut4.Parameters.AddWithValue("@P8", ent.Saat);
            komut4.Parameters.AddWithValue("@P9", ent.Hstid);

            return komut4.ExecuteNonQuery() > 0;
        }
        public static SqlDataReader filter(string Branch)
        {
             SqlCommand komut5 = new SqlCommand("Select *FROM DocBilgi WHERE DocBRANŞ = @P1",Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@P1",Branch);
             dr = komut5.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
            
        }

        public static bool HstGuncelle2(EntityHst ent)
        {
            SqlCommand komut4 = new SqlCommand("Update HastaBilgi SET Rapor=@P1 WHERE HASTAID= @P2", Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", ent.Rapor);
            komut4.Parameters.AddWithValue("@P2", ent.Hstid);

            return komut4.ExecuteNonQuery() > 0;
        }

        public static List<EntityHst> DALDoktoraGoreHstList(EntityDoc p)
        {

            List<EntityHst> degerler = new List<EntityHst>();
            SqlCommand komut1 = new SqlCommand("Select * from HastaBilgi where DoktorADI=@P1", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {

                komut1.Connection.Open();
            }
            string adsoyad = p.Docname + " " + p.Docsurname;
            komut1.Parameters.AddWithValue("@P1",adsoyad);
            SqlDataReader hst = komut1.ExecuteReader();
            while (hst.Read())
            {
                EntityHst ent = new EntityHst();
                ent.Hstid = int.Parse(hst["HastaID"].ToString());
                ent.Hstname = hst["HastaAD"].ToString();
                ent.Hstsurname = hst["HastaSOYAD"].ToString();
                ent.Hsttckn = hst["HastaTCKN"].ToString();
                ent.Hstphone = hst["HastaTELEFON"].ToString();
                ent.Hstbolum = hst["HastaBÖLÜM"].ToString();
                ent.Docname = hst["DoktorADI"].ToString();
                ent.Tarih = Convert.ToDateTime(hst["Tarih"]);
                ent.Saat = hst["Saat"].ToString();
                ent.Rapor = hst["Rapor"].ToString();
                degerler.Add(ent);
            }
            hst.Close();
            return degerler;
        }

    }
}

