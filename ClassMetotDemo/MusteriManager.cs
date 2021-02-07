using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+"İsimli müsteri eklendi");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" isimli kişi silindi");
        }

        public void MusteriGuncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+"Adlı kişiye ait"+musteri.Adres+" Bilgisi güncellendi");
        }

        public void MusteriListele(Musteri[] musteris)
        {
            foreach (var musteri in musteris)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Adres);
                


            }
        }
    }
}
