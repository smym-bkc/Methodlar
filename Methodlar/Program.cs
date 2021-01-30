using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double Fiyati = 15;
            string Aciklama = "Amasya elması"

                string[] meyveler = new string[] { };
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
        }
        Urun[] urunler 0 new Urun[] {urun1,urun2 };
         //type-safe -- tip güvenli
         foreach (Urun urun in urunler) 

	}
                Console.Writline(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");

	}

              Console.WriteLine("----------------Metotlar-------------");
SepetManager SepetManager = new sepetManager();
SepetManager.Ekle(urun1);
SepetManager.Ekle(urun2);


SepetManager.Ekle2("Armut", "Yeşil Armut", 12);                         //bunlar farklı sayfalar
SepetManager.Ekle2("Elma", "Yeşil Elma", 12);
SepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12);
//böyle yazssanda olur ama classlar...
           
    }
}



