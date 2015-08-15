using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primzahlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static Byte[] zahlBerreich;//Null heißt noch nicht überprüft. //Eins ist keine Primzahl //Zwei ist eine Primzahl.
        public static int niedrigsteGetesteteZahl = 2; //Der Niedrigstestand des Siebes
        public int[] test;
        private void btn_errechnen_Click(object sender, EventArgs e)
        {

            zahlBerreich = new Byte[(int)numUD_maximum.Value];

        }

    }
}
