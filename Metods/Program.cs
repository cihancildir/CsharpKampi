using System;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Urun urun1 = new Urun{Adi = "Elma",Id = 1,Fiyat = 5,Aciklama = "Tatlı Elma"};

            Urun urun2 = new Urun { Adi = "Karpuz", Id = 2, Fiyat = 80, Aciklama = "Diyarbakır Karpuzu" };

            Urun[] urunler = new Urun[] { urun1,urun2 };
            foreach (Urun urungetir in urunler)
            {
                Console.WriteLine(urungetir.Adi);
                Console.WriteLine(urungetir.Fiyat);
                Console.WriteLine(urungetir.Aciklama);
            }

            Console.WriteLine("------------------Metodlar-------------------" );

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle2("armut","deveci",30);
            sepetManager.Ekle2("kiraz", "Naployon", 25);
            sepetManager.Ekle2("ceviz", "kanada", 45);

        }
    }
}
