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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FormStart formStart;
        FormInfo formInfo;
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            formStart = new FormStart();
            formStart.Show();
            

        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            formInfo = new FormInfo();
            formInfo.Show();
            
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
