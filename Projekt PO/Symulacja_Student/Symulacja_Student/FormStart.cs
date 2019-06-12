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
    public partial class FormStart : Form
    {
        public FormStart()
        { 
            InitializeComponent();
        }
        FormSimulation formSimulation;

        private void ButtonSimulation_Click(object sender, EventArgs e)
        {
            bool error = false;
            char literka = ':';
            for (int i = 0; i <=118; i++)
            {
                
                if (textBoxSpryt.Text.Contains(literka) || textBoxZmeczenie.Text.Contains(literka) || textBoxWiedza.Text.Contains(literka) || textBoxPrzyswajanieWiedzy.Text.Contains(literka))
                { MessageBox.Show("Błędna wartość");
                    error = true;
                    break;
               
                }
                literka++;
            }
            if (!error)
            {
                int Spryt = int.Parse(textBoxSpryt.Text);
                int Zmeczenie = int.Parse(textBoxZmeczenie.Text);
                int Wiedza = int.Parse(textBoxWiedza.Text);
                int PrzyswajanieWiedzy = int.Parse(textBoxPrzyswajanieWiedzy.Text);
                if ((Spryt < 0) || (Spryt > 10) || (Zmeczenie < 0) || (Zmeczenie > 10) || (Wiedza < 0) || (Wiedza > 10) || (PrzyswajanieWiedzy < 0) || (PrzyswajanieWiedzy > 10))

                { MessageBox.Show("Wprowadzanymi wartościami powinny być liczby całkowite z przedziału <0,10>!"); }
                else
                {
                    formSimulation = new FormSimulation(textBoxSpryt.Text, textBoxZmeczenie.Text, textBoxWiedza.Text, textBoxPrzyswajanieWiedzy.Text);
                    formSimulation.Show();
                    Close();
                }
            }
            
        
        }
    }
}
