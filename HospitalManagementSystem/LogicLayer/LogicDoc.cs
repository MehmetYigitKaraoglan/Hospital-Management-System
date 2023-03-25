using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using System.Data.SqlClient;

namespace LogicLayer
{
    public class LogicDoc
    {
        public static List<EntityDoc> LLDocList() 
        {
            return DALDoc.DALDocList();
        }
        public static int  LLDocEkle(EntityDoc p)
        {
            if(p.Docname!= ""&&p.Docsurname !=""&&p.Docname.Length>=3)
            {
                return DALDoc.DocEkle(p);
            }
            else
            {
                return -1;
            }
        }
    
        public static bool LLDocSil(int per)
        {
            if(per >= 1)
            {
                return DALDoc.DocSil(per);
            }
            else
            {
                return false;
            }
        }

        public static bool LLDocGuncelle(EntityDoc ent)
        {
            if(ent.Docname.Length>=3 && ent.Docname !="")
            {
                return DALDoc.DocGuncelle(ent);
            }
            else
            {
                return false;
            }
        }
        public static int LLDoktorGiris(EntityDoc p)
        {
            return DALDoc.DoktorGiris(p);
        }
        public static SqlCommand LLBolumHastaSayisiCek(string brans)
        {
            return DALDoc.BolumHastaSayisiCek(brans);
        }
        public static SqlCommand LLDoktorAdıCek(EntityDoc p)
        {
            return DALDoc.DoktorAdıCek(p);
        }
        public static SqlCommand LLDoktorSoyadıCek(EntityDoc p)
        {
            return DALDoc.DoktorSoyadıCek(p);
        }
    }
}
