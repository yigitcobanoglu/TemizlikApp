using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TemizlikApp
{
    //bu Sınıf tüm kayıt işlemlerinden 
    //ve verinin diğer formlar ile
    //paylaşımından sorumlu olacak
    public static class KayitYoneticisi
    {
        public static BindingList<Sinif> Siniflar { get; set; }

        public static void Kaydet()
        {
            //kaydetme işlemleri
            string metin = JsonSerializer.Serialize(Siniflar);

            File.WriteAllText("siniflar.txt", metin);
        }
        public static void Yukle()
        {
            //yükleme işlemleri
            if(File.Exists("siniflar.txt"))
            {
                string metin = File.ReadAllText("siniflar.txt");
                var liste = JsonSerializer.Deserialize<List<Sinif>>(metin);
                Siniflar = new BindingList<Sinif>(liste);
            }
            else
            {
                Siniflar = new BindingList<Sinif>();
            }
        }
    }
}
