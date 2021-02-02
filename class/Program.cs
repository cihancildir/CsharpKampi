using System;

namespace classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Meyve Elma = new Meyve {
                MeyveAdi = "Elma",
                MeyveTuru = "kışlık",
                MeyveSayisi = 5
            };


            Meyve[] Meyveler = new Meyve[] { Elma };

            foreach (var meyve in Meyveler)
            {
                Console.WriteLine(meyve.MeyveAdi);
                Console.WriteLine(meyve.MeyveTuru);
                Console.WriteLine(meyve.MeyveSayisi);
            }
        }
    }
	

	
        

        class Meyve {
            public string MeyveAdi { get; set; }
            public string MeyveTuru { get; set; }

            public int MeyveSayisi { get; set; }

        }

}
