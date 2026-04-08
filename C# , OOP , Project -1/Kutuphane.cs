using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C____OOP___Project__1
{
    public class Kutuphane
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
}
