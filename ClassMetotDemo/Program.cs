using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.MusteriAdi = "Furkan";
            musteri1.MusteriSoyadi = "Akarslan";
            musteri1.TCKN = "11111111112";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.MusteriAdi = "Hale";
            musteri2.MusteriSoyadi = "Odabaşı Akarslan";
            musteri2.TCKN = "21213121212";

            Musteri musteri3 = new Musteri();
            musteri3.ID = 3;
            musteri3.MusteriAdi = "Elif";
            musteri3.MusteriSoyadi = "Akarslan";
            musteri3.TCKN = "11661211712";

            Musteri musteri4 = new Musteri();
            musteri4.ID = 4;
            musteri4.MusteriAdi = "Zeynep";
            musteri4.MusteriSoyadi = "Akarslan";
            musteri4.TCKN = "11451033512";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteri = new MusteriManager();
            musteri.Ekle(musteri1);
            musteri.Ekle(musteri2);
            musteri.Sil(musteri1);
            musteri.Listele(musteriler);
        }
    }
}
