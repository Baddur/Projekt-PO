using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symulacja_Student
{
    public partial class FormSimulation : Form
    {   //stworzenie instancji poszczególnych klas
        Student student = new Student();
        Dziekan dziekan = new Dziekan();
        //stworzenie listy obiektow
        List<Wykladowca> ListaWykladowcow = new List<Wykladowca>();
        

        public FormSimulation(string SprytStudenta,string ZmeczenieStudenta, string WiedzaStudenta, string PrzyswajanieWiedzyStudenta)
        {
            InitializeComponent();
            //wprowadzamy statystyki studenta podane w poprzednim oknie jako zmienne obiektu 'student'
             student.Spryt= int.Parse(SprytStudenta);
            student.Zmeczenie = int.Parse(ZmeczenieStudenta);
           student.Wiedza = int.Parse(WiedzaStudenta);
            student.PrzyswajanieWiedzy = int.Parse(PrzyswajanieWiedzyStudenta);
            //uruchomienie timera
            timerSemestr.Start();
            //dodanie nowych wykladowców i ustalenie wartości ich zmiennych
            ListaWykladowcow.Add(new Wykladowca(new Przedmiot("Podstawy automatyki i robotyki",1,2)));
            ListaWykladowcow.Add(new Wykladowca(new Przedmiot("Programowanie obiektowe",6,4)));
            ListaWykladowcow.Add(new Wykladowca(new Przedmiot("Analiza matematyczna",5,6)));
            ListaWykladowcow.Add(new Wykladowca(new Przedmiot("Fizyka",5,3)));
            ListaWykladowcow.Add(new Wykladowca(new Przedmiot("Matematyka dyskretna",4,7)));


            //textboxy pozostają zakreslone az do czasu 'napisania sprawdzianu'
            textBoxKolokwiumPair.Text = "---";
            textBoxKolokwiumPo.Text = "---";
            textBoxKolokwiumAnaliza.Text = "---";
            textBoxKolokwiumFizyka.Text = "---";
            textBoxKolokwiumDyskretna.Text = "---";
        }
        //zmienna przechowująca liczbę zwracaną przez funkcję PiszSprawdzian klasy Wykladowca

        int czyZaliczyl = 0;
        //zmienna licznika Dni
        int licznikDni = 0;
        //zmienna przechowująca maksymalną liczbę ECTSów do uzyskania
        int licznikPozostalychECTS = 21;
       
        //funkcja wywoływana co sekundę
        private void TimerSemestr_Tick(object sender, EventArgs e)
        {
            if (student.Zmeczenie>10)
            {
                student.PiciePiwka();
            }
            if (student.PrzyswajanieWiedzy <3)
            {
                student.Spanie();
            }
            if (student.Wiedza <5)
            {
                student.Nauka();
            }
            //zwiększamy licznik Dni, w programie 1dzien= 1 sekunda rzeczywista
            licznikDni++;
            //wypisujemy textBoxy
            textBoxDni.Text = licznikDni.ToString();
            textBoxDniDoKolokwium.Text = (10-(licznikDni % 10)).ToString();
           
            textBoxSpryt.Text = student.Spryt.ToString();
            textBoxZmeczenie.Text = student.Zmeczenie.ToString();
            textBoxWiedza.Text = student.Wiedza.ToString();
            textBoxPrzyswajanieWiedzy.Text = student.PrzyswajanieWiedzy.ToString();
            textBoxZebraneECTS.Text = (21-licznikPozostalychECTS).ToString()+"/21";
           //sprawdzian z PAiR'u
            if (licznikDni == 10)
            {
                student.Zmeczenie++;
                czyZaliczyl = ListaWykladowcow[0].PiszSprawdzian(student.Spryt,student.Zmeczenie,student.Wiedza,student.PrzyswajanieWiedzy);
                
                
                if (ListaWykladowcow[0].Zaliczenie(czyZaliczyl) == true)
                {
                    licznikPozostalychECTS -= ListaWykladowcow[0].kurs.IloscECTS;
                    textBoxKolokwiumPair.Text = "Zdano!";
                }
                else textBoxKolokwiumPair.Text = "Nie zdano!";
            }
            //sprawdzian z Programowania Obiektowego
             if (licznikDni == 20)
             {
                //zwiększamy zmeczenie studenta
                student.Zmeczenie++;
                //nowa wartosc zmiennej czyZaliczyl, podamy ją do metody 'Zaliczenie' aby sprawdzić czy student zdał przedmiot
                czyZaliczyl = ListaWykladowcow[1].PiszSprawdzian(student.Spryt,student.Zmeczenie,student.Wiedza,student.PrzyswajanieWiedzy);
                if (ListaWykladowcow[1].Zaliczenie(czyZaliczyl) == true)
                {
                    licznikPozostalychECTS -= ListaWykladowcow[1].kurs.IloscECTS;
                    //zmiana zawartości texboxa
                    textBoxKolokwiumPo.Text = "Zdano!";

                }
                //zmiana wartosci textboxa
                else textBoxKolokwiumPo.Text = "Nie zdano!";
            }
             //sprawdzian z Analizy Matematycznej
             if (licznikDni == 30)
             {
                student.Zmeczenie++;
                czyZaliczyl =ListaWykladowcow[2].PiszSprawdzian(student.Spryt,student.Zmeczenie,student.Wiedza,student.PrzyswajanieWiedzy);
                if (ListaWykladowcow[2].Zaliczenie(czyZaliczyl) == true)
                {
                    licznikPozostalychECTS -= ListaWykladowcow[2].kurs.IloscECTS;
                    textBoxKolokwiumAnaliza.Text = "Zdano!";
                }
                else textBoxKolokwiumAnaliza.Text = "Nie zdano!";
            }
             //sprawdzian z fizyki
             if (licznikDni == 40)
             {
                student.Zmeczenie++;
                czyZaliczyl = ListaWykladowcow[3].PiszSprawdzian(student.Spryt,student.Zmeczenie,student.Wiedza,student.PrzyswajanieWiedzy);
                if (ListaWykladowcow[3].Zaliczenie(czyZaliczyl) == true)
                {
                    licznikPozostalychECTS -= ListaWykladowcow[3].kurs.IloscECTS;
                    textBoxKolokwiumFizyka.Text = "Zdano!";
                }
                else textBoxKolokwiumFizyka.Text = "Nie zdano!";
            }
             //sprawdzian z matematyki dyskretnej
             if (licznikDni == 50)
             {
                student.Zmeczenie++;
                czyZaliczyl = ListaWykladowcow[4].PiszSprawdzian(student.Spryt,student.Zmeczenie,student.Wiedza,student.PrzyswajanieWiedzy);
                if (ListaWykladowcow[4].Zaliczenie(czyZaliczyl) == true)
                {
                    licznikPozostalychECTS -= ListaWykladowcow[4].kurs.IloscECTS;
                    textBoxKolokwiumDyskretna.Text = "Zdano!";
                }
                else textBoxKolokwiumDyskretna.Text = "Nie zdano!";
                timerSemestr.Stop();
                if (licznikPozostalychECTS < 10) {
                    dziekan.WyplacPieniadze();
                    MessageBox.Show(dziekan.Gratulacje());
                }
                else {
                    dziekan.WyplacPieniadze();
                    MessageBox.Show(dziekan.WyrzucenieZUczelni());
            }

        }
        }
        //funkcja zatrzymująca działanie timera
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            timerSemestr.Stop();
        }

        //funkcja wznawiająca działanie timera
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            timerSemestr.Start();
            
        }

        private void FormSimulation_Load(object sender, EventArgs e)
        {

        }
    }
}
