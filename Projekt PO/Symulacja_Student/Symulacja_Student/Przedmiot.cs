using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symulacja_Student
{
    public class Przedmiot
    {
        public string NazwaPrzedmiotu;
        public int IloscECTS;
        public int TrudnoscZdania;
        
        public Przedmiot (string NazwaPrzedmiotu, int IloscECTS, int TrudnoscZdania)
        {
            this.NazwaPrzedmiotu = NazwaPrzedmiotu;
            this.IloscECTS = IloscECTS;
            this.TrudnoscZdania = TrudnoscZdania;

        }
    }
}
