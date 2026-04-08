    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    namespace C____OOP___Project__1
    {
        public class Program
        {            
            static void Main(string[] args)
            {
            try
            {
                Kutuphane K = new Kutuphane();

                Kitap k1 = new Kitap("savaş", 2002, "ali", "10202345");
                Kitap k2 = new Kitap("barış", 2005, "cevdet", "1234572");
                Kitap k3 = new Kitap {Ad="Farişis", YayimYili = 2003, ISBN="1920",Yazar="ardıç"}; // default contsturctur olması lazım !! 
                Dergi D1 = new Dergi("spidey", 2012, "155012");

                Uye U1 = new Uye("ahmet", "ahmet@user.com");

                K.AddMaterial(D1);
                K.AddMaterial(k1);
                K.addUye(U1);
                // PascalCase -> KitapAdı
                // CamelCase -> kitapAdı
                K.ListMaterials();
                K.ListUyes();

                Generic<string> StringList = new Generic<string>();
                StringList.Add("ahmet");
                StringList.Add("Mehmet");
                Generic<int> IntList = new Generic<int>();
                IntList.Add(5);
                IntList.Add(10);
                StringList.Show();
                IntList.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Genel hata: " + ex.Message);
            }

        }
        }
    }
