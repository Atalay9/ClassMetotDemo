using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla eklendi: " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri listelendi: " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silme işlemi başarılı: " + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
