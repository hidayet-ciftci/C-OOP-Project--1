    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    namespace C____OOP___Project__1
    {
        internal class Program
        {
            interface IKayitEdilebilir
            {
                void Kaydet();
            }
            abstract class Material:IKayitEdilebilir
            {
                public string Ad{ get; private set; }
                public int YayimYili { get; private set; }
                public Material(string ad, int yayimYili)
                {
                    Ad = ad;
                    YayimYili = yayimYili;
                }
            
                public abstract void BilgiYaz();

                public abstract void Kaydet();
           
            }
            class Kitap:Material
            {
                public string Yazar { get; private set; }
                public string ISBN { get; private set; }
                public Kitap(string ad, int yayimYili, string yazar, string iSBN):base(ad,yayimYili)
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
                    Console.WriteLine("Kitap Kaydedildi "+ Ad);
                }
            }
            class Dergi:Material
            {
                public string SayiNO { get; private set; }

                public Dergi(string ad, int yayimYili,string sayiNO):base(ad,yayimYili)
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
            class Uye:IKayitEdilebilir
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
                public void Kaydet() { Console.WriteLine("Üye kaydedildi "+ Ad); }
                public void BilgiYaz() { Console.WriteLine("Adı: "+Ad +" Email: "+ Email); }
            }
            class Kutuphane
            {
            private List<Material> materials;
            private List<Uye> Uyes;

                public Kutuphane()
                {
                    materials = new List<Material>();
                    Uyes = new List<Uye>();
                }

                public void AddMaterial(Material m)
                {
                    try
                    {
                    materials.Add(m);
                    Console.WriteLine("Materyal eklendi");
                    m.Kaydet();
                    }
                    catch (Exception ex)
                    {
                    Console.WriteLine("Hata oluştu (Material): " + ex.Message);
                    }
                }
                public void addUye(Uye U)
                {
                    try
                    {
                    Uyes.Add(U);
                    Console.WriteLine("Üye eklendi");
                    U.Kaydet();
                    }
                    catch (Exception ex)
                    {
                    Console.WriteLine("Hata oluştu (Üye): " + ex.Message);
                    }
                }
                public void ListMaterials()
                {
                    foreach (Material m in materials)
                    {
                        m.BilgiYaz();
                    }
                }
                public void ListUyes()
                {
                    foreach (Uye u in Uyes)
                    {
                        u.BilgiYaz();
                    }
                }
            }
            static void Main(string[] args)
            {
            try
            {
                Kutuphane K = new Kutuphane();

                Kitap k1 = new Kitap("savaş", 2002, "ali", "10202345");
                Dergi D1 = new Dergi("spidey", 2012, "155012");

                Uye U1 = new Uye("ahmet", "ahmet@user.com");

                K.AddMaterial(D1);
                K.AddMaterial(k1);
                K.addUye(U1);

                K.ListMaterials();
                K.ListUyes();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Genel hata: " + ex.Message);
            }
        }
        }
    }
