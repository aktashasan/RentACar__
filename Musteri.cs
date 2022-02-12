using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar__
{
    class Musteri
    {
        private int id;
        private string isim;
        private string soyisim;
        private Int64 tc;
        private Int64 tel;
        private string adres;
        private string mail;
        private string password;

        public int Id { get => id; set => id = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Isim { get => isim; set => isim = value; }
        public Int64 Tc { get => tc; set => tc = value; }
        public Int64 Tel { get => tel; set => tel = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }

    }
}
