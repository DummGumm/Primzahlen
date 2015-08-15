using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primzahlen
{
    class Primzahlen_Rechner
    {

        public void berreichRechnen()
        {
            for (int i = 0; i < Form1.niedrigsteGetesteteZahl; i++)
            {
                if (Form1.zahlBerreich[i] == 0)
                {
                    Form1.zahlBerreich[i] = 2;
                    berreichStreichen(i);
                }
            }
        }
        private void berreichStreichen(int eigenePrim)
        {
            for (int i = eigenePrim ^ 2; i <= Form1.zahlBerreich.Length; i += eigenePrim)
            {
                if (i < Form1.niedrigsteGetesteteZahl)
                {
                    Form1.niedrigsteGetesteteZahl = i - 1;
                }
                if (i < Form1.niedrigsteGetesteteZahl)
                {
                    Form1.niedrigsteGetesteteZahl = i;
                }
                Form1.zahlBerreich[i]++;

            }

        }

    }
}
