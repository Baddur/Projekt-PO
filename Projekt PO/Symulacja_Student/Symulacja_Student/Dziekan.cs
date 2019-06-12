using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symulacja_Student
{
    class Dziekan:Pracownik
    {
        public string Gratulacje()
        {
            return "Dziekan: Gratuluję zdania semestru!";
        }
        public string WyrzucenieZUczelni()
        {
            return "Dziekan: Uzyskał pan fatalne wyniki w nauce. Niestety muszę skreślić Pana z listy studentów.";
        }
       private int Premia = 1000;
       
        public int WyplacPieniadze()
        {
            return Premia + Pensja;
        }
    }
}

