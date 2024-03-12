using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraDadi
{
    internal class Partita
    {
        public Partita()
        {
        }

        public int AvviaMatch(Giocatore g1, Giocatore g2)
        {//avvio partita tra giocatori
            g1.LanciaDado();
            g2.LanciaDado();

            if (g1.GetDado > g2.GetDado)
            {
                return 1;
            }
            else if (g1.GetDado < g2.GetDado)
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
