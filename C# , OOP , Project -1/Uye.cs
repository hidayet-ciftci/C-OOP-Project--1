using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C____OOP___Project__1
{
    public class Uye : IKayitEdilebilir
    {
        public string Ad { get; private set; }
        public string Email { get; private set; }
        private static int _sayac;

        public int UyeNo { get; private set; }

        public Uye(string ad, string email)
        {
            Ad = ad;
            Email = email;
            _sayac++;
            UyeNo = _sayac;

        }
        public void Kaydet() { Console.WriteLine("Üye kaydedildi " + Ad); }
        public void BilgiYaz() { Console.WriteLine("Adı: " + Ad + " Email: " + Email); }
    }
}
