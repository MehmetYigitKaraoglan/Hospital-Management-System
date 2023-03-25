using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntitySec
    {
        private int secid;
        private string secname;
        private string secsurname;
        private string secphone;
        private string secusername;
        private string secpassword;

        public int Secid { get => secid; set => secid = value; }
        public string Secname { get => secname; set => secname = value; }
        public string Secsurname { get => secsurname; set => secsurname = value; }
        public string Secphone { get => secphone; set => secphone = value; }
        public string Secusername { get => secusername; set => secusername = value; }
        public string Secpassword { get => secpassword; set => secpassword = value; }
    }
}
