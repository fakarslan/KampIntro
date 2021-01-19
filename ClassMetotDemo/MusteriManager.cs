using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi: " + musteri.ID);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.TCKN+ " kimlik nolu müşteri silindi.");
        }

        public void Listele(Musteri[] musteriler) 
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.TCKN + " kimlik numaralı müşterinin adı " + musteri.MusteriAdi +"'dır.");
            }
        
        }

}

    }

