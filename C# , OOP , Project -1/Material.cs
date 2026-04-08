using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C____OOP___Project__1
{
    public abstract class Material : IKayitEdilebilir
    {
        public string Ad { get; set; }
        public int YayimYili { get; set; }

        public Material()
        {
            
        }
        public Material(string ad, int yayimYili)
        {
            Ad = ad;
            YayimYili = yayimYili;
        }

        public abstract void BilgiYaz();

        public abstract void Kaydet();

    }
}
