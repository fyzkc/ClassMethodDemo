using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id,Ad,Soyad....)
            //MusteriManager sınıfı oluşturunuz.
            //Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.


            Musteri musteri1 = new Musteri();
            musteri1.Id = 0;
            musteri1.MusteriIsmi = "Feyza";
            musteri1.MusteriSoyadi = "Koç";
            musteri1.HesapTuru = "Bireysel";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1;
            musteri2.MusteriIsmi = "Merve";
            musteri2.MusteriSoyadi = "Koç";
            musteri2.HesapTuru = "Bireysel";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriSil(musteri1);


        }
    }
}
