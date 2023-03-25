using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDoc
    {
        private int docid;
        private string docname;
        private string docsurname;
        private string docbranch;
        private string docphone;
        private string docusername;
        private string docpassword;

        public int Docid { get => docid; set => docid = value; }
        public string Docname { get => docname; set => docname = value; }
        public string Docsurname { get => docsurname; set => docsurname = value; }
        public string Docbranch { get => docbranch; set => docbranch = value; }
        public string Docphone { get => docphone; set => docphone = value; }
        public string Docusername { get => docusername; set => docusername = value; }
        public string Docpassword { get => docpassword; set => docpassword = value; }
    }
}