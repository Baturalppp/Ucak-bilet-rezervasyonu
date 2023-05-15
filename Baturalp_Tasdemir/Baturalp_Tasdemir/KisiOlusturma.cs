using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baturalp_Tasdemir
{
    internal class KisiOlusturma
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Yaş { get; set; }

        public string KimlikNo { get; set; }

        public string TelNo { get; set; }

        public int Cinsiyet { get; set; }

        public int Engel { get; set; }

        public Kisi kisi()
        {
            Console.Write("Adınızı Giriniz: ");
            Ad = Console.ReadLine();

            Console.Write("Soyadınızı Giriniz: ");
            Soyad = Console.ReadLine();

            Console.Write("Yaşınızı Giriniz: ");
            Yaş = Console.ReadLine();

            Console.Write("KimlikNo Giriniz: ");
            KimlikNo = Console.ReadLine();

            Console.Write("TelNo Giriniz: ");
            TelNo = Console.ReadLine();

            while (true)
            {
                string Temp = string.Empty;

                Console.Write("Cinsiyetinizi Giriniz(E/K): ");
                Temp = Console.ReadLine();

                if (Temp == "E")
                {
                    Cinsiyet = 1;
                    break;
                }
                else if (Temp == "K")
                {
                    Cinsiyet = 2;
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Değer");
                }
            }

            while (true)
            {
                string Temp = string.Empty;

                Console.Write("Engel Durumunuz Var mı?(E/H): ");
                Temp = Console.ReadLine();

                if (Temp == "E")
                {
                    Engel = 1;
                    break;
                }
                else if (Temp == "H")
                {
                    Engel = 2;
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Değer");
                }
            }

            Kisi kisi = new Kisi(Ad, Soyad, Yaş, KimlikNo, TelNo, Cinsiyet, Engel);

            return kisi;
        }
    }
}
