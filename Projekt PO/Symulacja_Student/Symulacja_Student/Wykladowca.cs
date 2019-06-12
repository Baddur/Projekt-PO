using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symulacja_Student
{
    class Wykladowca:Pracownik,Kolowkium
    {
        public Przedmiot kurs;
         public Wykladowca(Przedmiot kurs)
        {
            this.kurs = kurs;
        }
         public int PiszSprawdzian(int PodanySpryt, int PodaneZmeczenie, int PodanaWiedza, int PodanePrzyswajanieWiedzy)
        {
            //int a = PodanaWiedza + PodanePrzyswajanieWiedzy + PodaneZmeczenie + PodanySpryt;
            if (((PodanySpryt - PodaneZmeczenie) > kurs.TrudnoscZdania) || (PodanaWiedza > kurs.TrudnoscZdania))
                return 1;
            else return 2;
        }
        public bool Zaliczenie(int a)
        {
            if (a == 1)
                return true;
            else return false;
        }
    }
    
}
