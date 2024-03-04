using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraDadi
{
    internal class Partita
    {
        int punteggioG1, punteggioG2;

        public Partita()
        {
            punteggioG1 = 0;
            punteggioG2 = 0;
        }

        public int AvviaMatch(Dado dado)
        {//lancio dadi di Giocatore1me
            int lancioG1, lancioG2;

            lancioG1 = dado.GeneraNumero();
            lancioG2 = dado.GeneraNumero();

            if (lancioG1 > lancioG2)
            {
                return 1;
            }
            else if (lancioG1 < lancioG2)
            {
                return 2;
            }
            else
            {
                return 0;
            }

        }
    }
}
