using System;

namespace odevClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap efsane = new Kitap
            {
                kitapAdi = "Efsane",
                kitapBaskiYili = "2005",
                kitapSayfaSayisi = 50,
                kitapYazari = "İskender PALA"
                   };

            Kitap kurkMantolu = new Kitap
            {
                kitapAdi = "Kurk Mantolu Madonna",
                kitapBaskiYili = "2002",
                kitapSayfaSayisi = 150,
                kitapYazari = "Sabahattin Ali"
            };
            Kitap[] kitaplar = new Kitap[] { efsane, kurkMantolu };
            Console.WriteLine("--------------------------------------------Foreach Döngüsü-------------------------------------\n");
            foreach (var kitapS in kitaplar) // Dizi 
            {
                Console.WriteLine("Kitap Adı: "+kitapS.kitapAdi + "......Kitap Yazarı: "+ kitapS.kitapYazari+"......Kitap Baskı Yılı: "+ kitapS.kitapBaskiYili+ "......Kitap Sayfa Sayısı: " + kitapS.kitapSayfaSayisi);
            }

            Console.WriteLine("--------------------------------------------For Döngüsü-------------------------------------\n");
            for (int i = 0; i < kitaplar.Length; i++) // Döngü
            {
                Console.WriteLine("Kitap Adı: " + kitaplar[i].kitapAdi + "......Kitap Yazarı: " + kitaplar[i].kitapYazari + "......Kitap Baskı Yılı: " + kitaplar[i].kitapBaskiYili+ "......Kitap Sayfa Sayısı: " + kitaplar[i].kitapSayfaSayisi);
            }
            Console.WriteLine("--------------------------------------------While Döngüsü-------------------------------------\n");
            // while
            int j = 0;
            while (j<kitaplar.Length) {

                Console.WriteLine("Kitap Adı: " + kitaplar[j].kitapAdi + "......Kitap Yazarı: " + kitaplar[j].kitapYazari + "......Kitap Baskı Yılı: " + kitaplar[j].kitapBaskiYili+ "......Kitap Sayfa Sayısı: " + kitaplar[j].kitapSayfaSayisi);
                j++;
            }
        }

        class Kitap {
            public string kitapAdi { get; set; }
            public string kitapYazari { get; set; }
            public string kitapBaskiYili { get; set; }

            public int kitapSayfaSayisi { get; set; }


        }

    }
}
