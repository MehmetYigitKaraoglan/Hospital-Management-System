using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DALDoc
    {
        public static List<EntityDoc> DALDocList()
        {
            List<EntityDoc> degerler = new List<EntityDoc>();
            SqlCommand komut1 = new SqlCommand("Select * from DocBilgi", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {

                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityDoc ent = new EntityDoc();
                ent.Docid = int.Parse(dr["DocID"].ToString());
                ent.Docname = dr["DocAD"].ToString();
                ent.Docsurname = dr["DocSOYAD"].ToString();
                ent.Docbranch = dr["DocBRANŞ"].ToString();
                ent.Docphone = dr["DocTELEFON"].ToString();
                ent.Docusername = dr["DocUSERNAME"].ToString();
                ent.Docpassword = dr["DocPASSWORD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static SqlCommand BolumHastaSayisiCek(string brans)
        {
            SqlCommand komut2 = new SqlCommand("Select Count(HastaID) from HastaBilgi Where HastaBÖLÜM=@P1", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", brans);
            return komut2;
        }
        public static SqlCommand DoktorAdıCek(EntityDoc p)
        {
            SqlCommand komut2 = new SqlCommand("Select DocAD from DocBilgi where DocUSERNAME=@P1 AND DocPASSWORD=@P2", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p.Docusername);
            komut2.Parameters.AddWithValue("@P2", p.Docpassword);

            return komut2;
        }
        public static SqlCommand DoktorSoyadıCek(EntityDoc p)
        {
            SqlCommand komut2 = new SqlCommand("Select DocSOYAD from DocBilgi where DocUSERNAME=@P1 AND DocPASSWORD=@P2", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p.Docusername);
            komut2.Parameters.AddWithValue("@P2", p.Docpassword);

            return komut2;
        }

        public static int DocEkle(EntityDoc p)
        {
            SqlCommand komut2 = new SqlCommand("insert into DocBilgi(DocAD,DocSOYAD,DocBRANŞ,DocTELEFON,DocUSERNAME,DocPASSWORD) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p.Docname);
            komut2.Parameters.AddWithValue("@P2", p.Docsurname);
            komut2.Parameters.AddWithValue("@P3", p.Docbranch);
            komut2.Parameters.AddWithValue("@P4", p.Docphone);
            komut2.Parameters.AddWithValue("@P5", p.Docusername);
            komut2.Parameters.AddWithValue("@P6", p.Docpassword);
            return komut2.ExecuteNonQuery();
        }
        public static bool DocSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete from DocBilgi where DocID = @P1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static bool DocGuncelle(EntityDoc ent)
        {
            SqlCommand komut4 = new SqlCommand("Update DocBilgi SET DocAD=@P1,DocSOYAD = @P2,DocBRANŞ=@P3,DocTELEFON=@P4,DocUSERNAME=@P5,DocPASSWORD=@P6 WHERE DocID= @P7", Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", ent.Docname);
            komut4.Parameters.AddWithValue("@P2", ent.Docsurname);
            komut4.Parameters.AddWithValue("@P3", ent.Docbranch);
            komut4.Parameters.AddWithValue("@P4", ent.Docphone);
            komut4.Parameters.AddWithValue("@P5", ent.Docusername);
            komut4.Parameters.AddWithValue("@P6", ent.Docpassword);
            komut4.Parameters.AddWithValue("@P7", ent.Docid);
            return komut4.ExecuteNonQuery() > 0;
        }


        public static int DoktorGiris(EntityDoc p)
        {

            Baglanti.bgl.Close();
            Baglanti.bgl.Open();
            SqlCommand komut3 = new SqlCommand("Select * From DocBilgi where DocUSERNAME='" + p.Docusername + "' AND DocPASSWORD='" + p.Docpassword + "'", Baglanti.bgl);
            SqlDataReader dr = komut3.ExecuteReader();
            if (dr.Read())
            {
                EntityDoc doktor = new EntityDoc();
                doktor.Docid = Convert.ToInt16(dr["DocID"]);
                doktor.Docname = Convert.ToString(dr["DocAD"]);
                doktor.Docsurname = Convert.ToString(dr["DocSOYAD"]);
                doktor.Docusername = Convert.ToString(dr["DocUSERNAME"]);
                doktor.Docpassword = Convert.ToString(dr["DocPASSWORD"]);
                doktor.Docphone = Convert.ToString(dr["DocTELEFON"]);
                doktor.Docbranch = Convert.ToString(dr["DocBRANŞ"]);
                dr.Close();
                return 1;
            }
            else
            {
                dr.Close();
                return 2;
            }
        }
    }
}
