using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi! Müşteri Bilgileri: "+ musteri.Id + " " + musteri.MusteriIsmi + " " + musteri.MusteriSoyadi + " " + musteri.HesapTuru);
        }

        public void MusteriListele(Musteri musteri_)
        {
            Musteri[] musteriler = new Musteri[] {musteri_ };
            foreach (Musteri item in musteriler)
            {
                Console.WriteLine("Müşteri Bilgileri: " + item.Id + " " + item.MusteriIsmi + " " + item.MusteriSoyadi + " " + item.HesapTuru);
            }
        }

        public void MusteriSil(Musteri musteri__)
        {
            Console.WriteLine("Müşteri Başarıyla Silindi!");
        }
    }
}
