using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Atalay";
            musteri1.Soyad = "Yılmazşimşek";
            musteri1.KayitTarihi = 2023;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Alper";
            musteri2.Soyad = "Polat";
            musteri2.KayitTarihi = 2014;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Listeleme(musteri1);
            musteriManager.Listeleme(musteri2);

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);


        }
    }
}