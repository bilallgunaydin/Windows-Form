using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Uygulama
{
    class Marti : Kus, IUcabilir, IYuzebilir
    {
        public string Yuz()
        {
            return "Hem uçabiliyorum, Hem yüzebiliyorum";
        }

        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Hizlan()
        {
            throw new NotImplementedException();
        }

        public void Dur()
        {
            throw new NotImplementedException();
        }
    }
}
