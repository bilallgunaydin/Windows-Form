using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Uygulama
{
    class Daire           //const kullanımı için yazıldı. Set edilemeyeceği için dörülemiyor.
    {
        public const double pi = 3.14;
        private int _cap;

        public int Cap
        {
            get { return _cap; }
            set { _cap = value; }
        }

        public double AlanHesapla()
        {
            return pi * (Cap / 2) * (Cap / 2);
        }
       
    }
}
