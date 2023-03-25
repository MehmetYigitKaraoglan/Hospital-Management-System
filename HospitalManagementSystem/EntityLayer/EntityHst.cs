using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityHst
    {
        private int hstid;
        private string hstname;
        private string hstsurname;
        private string hsttckn;
        private string hstphone;
        private string hstbolum;
        private string docname;
        private DateTime tarih;
        private string saat;
        private string rapor;

        public int Hstid { get => hstid; set => hstid = value; }
        public string Hstname { get => hstname; set => hstname = value; }
        public string Hstsurname { get => hstsurname; set => hstsurname = value; }
        public string Hsttckn { get => hsttckn; set => hsttckn = value; }
        public string Hstphone { get => hstphone; set => hstphone = value; }
        public string Hstbolum { get => hstbolum; set => hstbolum = value; }
        public string Docname { get => docname; set => docname = value; }
        public DateTime Tarih { get => tarih; set => tarih= value; }
        public string Saat { get => saat; set => saat= value; }
        public string Rapor { get => rapor; set => rapor= value; }
    }
}