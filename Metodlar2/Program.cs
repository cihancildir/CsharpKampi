using System;

namespace Metodlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Topla(3,5);
        }
        static void Topla(int Sayi1,int Sayi2) {
            int sonuc = Sayi1 + Sayi2;
            Console.WriteLine("Ekleme İşlemi Sonucu : " + sonuc);
        }
    }
}
