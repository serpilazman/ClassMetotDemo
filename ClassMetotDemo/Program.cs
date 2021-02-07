using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() { Id = 1, Ad = "Ali", Soyad = "Kara", Adres = "İstanbul" };
            Musteri musteri2 = new Musteri() { Id = 2 , Ad = "Ayşe" , Soyad = "Kara" , Adres = "İzmir" };
            Musteri musteri3 = new Musteri() { Id = 3, Ad = "Talip", Soyad = "Altın", Adres = "İzmir" };
            Musteri musteri4 = new Musteri() { Id = 4, Ad = "Şükran", Soyad = "Ovalı", Adres = "Kastamonu" };
            Musteri musteri5 = new Musteri() { Id = 5, Ad = "Dilara", Soyad = "Koçak", Adres = "Ankara" };


            MusteriManager musteriManager = new MusteriManager();

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3,musteri4,musteri5 };

            Console.WriteLine("----Musteriler Ekleniyor----");
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);
            musteriManager.MusteriEkle(musteri5);

            Console.WriteLine();

            Console.WriteLine("----Musteriler Listeleniyor----");

            musteriManager.MusteriListele(musteriler);

            Console.WriteLine();

            Console.WriteLine(musteri1.Ad+" isimli müşteri siliniyor");

            musteriManager.MusteriSil(musteri1);

            Console.WriteLine();

            Console.WriteLine(musteri3.Id+" Id'li "+musteri3.Ad+"isimli müşterinin adresi güncelleniyor");

            musteriManager.MusteriGuncelle(musteri3);




        }
    }
}
