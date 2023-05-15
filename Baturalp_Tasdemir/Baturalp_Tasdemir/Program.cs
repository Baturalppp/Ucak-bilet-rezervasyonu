using System;
using System.Threading;

namespace Baturalp_Tasdemir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Uçak Rezervasyon Sistemi";

            Console.WriteLine("Uçak Rezervasyon Sistemine Hoşgeldiniz.\n");

            KisiOlusturma kisiOLusturma = new KisiOlusturma();
            Kisi kisi = kisiOLusturma.kisi();

            Rezervasyon rezervasyonOlusturma = new Rezervasyon(kisi.Ad, kisi.Soyad);
            Console.Write(rezervasyonOlusturma.UcusDondur());

            Console.Write("\n\n İyi Yolculuklar.");

            Thread.Sleep(1000);
        }
    }


}