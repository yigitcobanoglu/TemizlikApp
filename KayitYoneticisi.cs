﻿using System;
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
        public static BindingList<Ogrenci> Ogrenciler { get; set; }

        public static void Kaydet()
        {
            //Kaydetme işlemleri
            string metin = JsonSerializer.Serialize(Siniflar);

            File.WriteAllText("siniflar.txt", metin);

            string metin2 = JsonSerializer.Serialize(Ogrenciler);

            File.WriteAllText("ogrenciler.txt", metin2);
        }
        public static void Yukle()
        {
            //Yükleme işlemleri
            if (File.Exists("siniflar.txt"))
            {
                string metin = File.ReadAllText("siniflar.txt");

                var liste = JsonSerializer.Deserialize<List<Sinif>>(metin);
                Siniflar = new BindingList<Sinif>(liste);
            }
            else
            {
                //Boş liste olarak oluştur
                Siniflar = new BindingList<Sinif>();
            }
            /////
            //Yükleme işlemleri
            if (File.Exists("ogrenciler.txt"))
            {
                string metin = File.ReadAllText("ogrenciler.txt");

                var liste = JsonSerializer.Deserialize<List<Ogrenci>>(metin);
                Ogrenciler = new BindingList<Ogrenci>(liste);
            }
            else
            {
                //Boş liste olarak oluştur
                Ogrenciler = new BindingList<Ogrenci>();
            }
        }
    }
}
