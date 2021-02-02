using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            Kurs javaKursu = new Kurs
            {
                KursAdi = "Javaya Başlangıç",
                KursunEgitmeni = "Cihan Çildir",
                KursunIzlenmeOrani = "50"
            };

            Kurs cKursu = new Kurs
            {
                KursAdi = "c Başlangıç",
                KursunEgitmeni = "das Çildir",
                KursunIzlenmeOrani = "70"
            };
            //Console.WriteLine(javaKursu.kursunEgitmeni);

            Kurs[] kurslar = new Kurs[] {javaKursu,cKursu };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }



        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public  string KursunIzlenmeOrani { get; set; }

    }
}
