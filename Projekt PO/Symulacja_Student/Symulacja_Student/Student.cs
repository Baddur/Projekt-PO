using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symulacja_Student
{
    class Student
    {
        public int Spryt;
        public int PrzyswajanieWiedzy;
        public int Wiedza;
        public int Zmeczenie;
        public int IloscZaliczen = 0;
        public void PiciePiwka()
        {
            Zmeczenie -= 5;
        }
        public void Spanie()
        {
            PrzyswajanieWiedzy++;
        }

        public void Nauka()
        {
            Wiedza++;
        }
    }
}
