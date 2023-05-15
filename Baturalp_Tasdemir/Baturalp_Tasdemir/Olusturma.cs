using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baturalp_Tasdemir
{
    internal class Olusturma
    {
        public int ucret;

        Random random = new Random();

        public Olusturma()
        {
            ucret = Convert.ToInt32(random.Next(300, 1000));

        }

        internal static bool OlusturmaDondur()
        {
            throw new NotImplementedException();
        }
    }
}