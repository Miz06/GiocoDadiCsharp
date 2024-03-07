using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraDadi
{
    internal class Gara
    {
        Giocatore g1;
        Giocatore g2;
        int numeroPartite, buffer;
        string winner;

        public Gara(string _g1, string _g2, int _numeroPartite)
        {
            g1 = new Giocatore(_g1);
            g2 = new Giocatore(_g2);
            numeroPartite = _numeroPartite; //partite da giocare
            buffer = _numeroPartite; //utilizzo buffer per tenere memorizzate le partite inserite ad inizio gara
        }

        public bool FineGara()
        {
            numeroPartite--;

            if (numeroPartite == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetWinner
        {
            get { return winner; }
        }

        public void Round()
        {
            Partita partita = new Partita();
            int num = partita.AvviaMatch(g1, g2);

            if (num == 1)
            {
                g1.IncreasePoints();
            }
            else if (num == 2)
            {
                g2.IncreasePoints();
            }
            else
            {
                g1.IncreasePoints();
                g2.IncreasePoints();
            }
        }

        public string GameWin()
        {
            if (g1.GetPoints > g2.GetPoints)
            {
                return g1.GetName;
            }
            else if (g1.GetPoints < g2.GetPoints)
            {
                return g2.GetName;
            }
            else
            {
                return "pareggio";
            }
        }

        public void ResetGame()
        {
            numeroPartite = buffer;
            g1.ResettaPunteggio();
            g2.ResettaPunteggio();
        }

        public string G1GetName()
        {
            return g1.GetName;
        }

        public string G2GetName()
        {
            return g2.GetName;
        }

        public int G1GetPoints()
        {
            return g1.GetPoints;
        }

        public int G2GetPoints()
        {
            return g2.GetPoints;
        }

        public int G1GetNum()
        {
            return g1.GetNumero();
        }

        public int G2GetNum()
        {
            return g2.GetNumero();
        }

        public int GetPartiteRimanenti
        {
            get{ return numeroPartite; }
        }
    }
}
