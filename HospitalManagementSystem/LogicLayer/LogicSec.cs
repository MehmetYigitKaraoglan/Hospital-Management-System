using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicSec
    {
        public static List<EntitySec> LLSecList()
        {
            return DALSec.DALSecList();
        }
        public static int LLSecEkle(EntitySec p)
        {
            if (p.Secname != "" && p.Secsurname != "" && p.Secname.Length >= 3)
            {
                return DALSec.SecEkle(p);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLSecSil(int per)
        {
            if (per >= 1)
            {
                return DALSec.SecSil(per);
            }
            else
            {
                return false;
            }
        }

        public static bool LLSecGuncelle(EntitySec ent)
        {
            if (ent.Secname.Length >= 3 && ent.Secname != "")
            {
                return DALSec.SecGuncelle(ent);
            }
            else
            {
                return false;
            }
        }
        public static int LLSecGiris(EntitySec p)
        {
            return DALSec.SecGiris(p);
        }
    }
}