using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>();

            isimler.Add("Ali");
            isimler.Add("Veli");
            isimler.Add("Ahmet");
            isimler.Add("Mehmet");
            Console.WriteLine(isimler[0]);
            isimler.Add("Cihan");

            Console.WriteLine(isimler[4]);
        }
    }
}
