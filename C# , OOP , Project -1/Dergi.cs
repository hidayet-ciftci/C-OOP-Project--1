using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C____OOP___Project__1
{
    public class Dergi : Material
    {
        public string SayiNO { get; private set; }

        public Dergi(string ad, int yayimYili, string sayiNO) : base(ad, yayimYili)
        {
            SayiNO = sayiNO;
        }

        public override void BilgiYaz()
        {
            Console.WriteLine($"Ad: {Ad} | Yayım Yılı: {YayimYili} | Sayi No: {SayiNO}");
        }
        public override void Kaydet()
        {
            Console.WriteLine("Dergi Kaydedildi." + Ad);
        }
    }
}
