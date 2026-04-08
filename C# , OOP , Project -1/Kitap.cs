using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C____OOP___Project__1
{
    public class Kitap : Material
    {
        public string Yazar { get; set; }
        public string ISBN { get; set; }

        public Kitap()
        {
            
        }

        public Kitap(string Ad, int yayimYili, string yazar, string iSBN) : base(Ad, yayimYili)
        {
            Yazar = yazar;
            ISBN = iSBN;
        }

        public override void BilgiYaz()
        {
            Console.WriteLine($"Ad: {Ad} | Yayım Yılı: {YayimYili} | Yazar: {Yazar} | ISBN: {ISBN}");
        }
        public override void Kaydet()
        {
            Console.WriteLine("Kitap Kaydedildi " + Ad);
        }
    }
}
