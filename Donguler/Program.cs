using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"Kamp","java","Temel" };


            //for (int i = 0; i < kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            
            //for (int i = 0; i < 10; i+=2)
            //{
            //    Console.WriteLine(i+"\n");
            //}  
        }
    }
}
