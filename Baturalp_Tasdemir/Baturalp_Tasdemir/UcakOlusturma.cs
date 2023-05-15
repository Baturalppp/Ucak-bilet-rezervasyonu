using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baturalp_Tasdemir
{
    internal class UcakOlusturma
    {
        public string Model { get; set; }

        public int YolcuKapasitesi { get; set; }

        public int SeriNo { get; set; }
        private Random Random = new Random();

        public UcakOlusturma()
        {
            int random = Random.Next(0, 6);

            switch (random)
            {
                case 0:
                    Model = "AIRBUS A380";
                    YolcuKapasitesi = 853;
                    SeriNo = 380;
                    break;

                case 1:
                    Model = "Douglas DC-9";
                    YolcuKapasitesi = 90;
                    SeriNo = 9;
                    break;

                case 2:
                    Model = "BOEING 787";
                    YolcuKapasitesi = 250;
                    SeriNo = 787;
                    break;

                case 3:
                    Model = "CONCORDE";
                    YolcuKapasitesi = 120;
                    SeriNo = 2003;
                    break;
                default:
                    break;
            }
        }
    }
}
