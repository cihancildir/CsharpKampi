using System;
using System.Collections.Generic;
using System.Text;

namespace Metods
{
    class SepetManager
    {
        public void Ekle(Urun urun) {

            Console.WriteLine("Sepete Eklendi: "+ urun.Adi);
        }
        public void Ekle2(string urunAdi,string urunAciklama, double fiyat) 
        
        {
            Console.WriteLine("Sepete Eklendi: " + urunAdi);
        }
    }
}
