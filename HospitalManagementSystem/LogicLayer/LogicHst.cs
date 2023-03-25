using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class LogicHst
    {
        public static List<EntityHst> LLHstList()
        {
            return DALHst.DALHstList();
        }
        public static List<EntityHst> LLDoktoraGoreHstList(EntityDoc p)
        {
            return DALHst.DALDoktoraGoreHstList(p);
        }
        public static int LLHstEkle(EntityHst p)
        {
            if (p.Hstname != "" && p.Hstsurname != "" && p.Hstname.Length >= 3)
            {
                return DALHst.HstEkle(p);
            }
            else
            {
                return -1;
            }
        }
        public static SqlDataReader LLFilter(string Branch)
        {
            return DALHst.filter(Branch);
        }


        public static bool LLHstSil(int per)
        {
            if (per >= 1)
            {
                return DALHst.HstSil(per);
            }
            else
            {
                return false;
            }
        }

        public static bool LLHstGuncelle(EntityHst ent)
        {
            if (ent.Hstname.Length >= 3 && ent.Hstname != "")
            {
                return DALHst.HstGuncelle(ent);
            }
            else
            {
                return false;
            }
        }

        public static bool LLHstGuncelle2(EntityHst ent)
        {
            if (ent.Rapor.Length >= 3 && ent.Rapor != "")
            {
                return DALHst.HstGuncelle2(ent);
            }
            else
            {
                return false;
            }
        }
    }
}