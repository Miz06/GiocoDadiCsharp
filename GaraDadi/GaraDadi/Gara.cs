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
        Dado dado;
        int numeroPartite, buffer;
        string winner, loser;

        public Gara(string _g1, string _g2, int _numeroPartite)
        {
            g1 = new Giocatore(_g1);
            g2 = new Giocatore(_g2);
            numeroPartite = _numeroPartite; //partite da giocare
            buffer = _numeroPartite; //utilizzo buffer per tenere memorizzate le partite inserite ad inizio gara
            dado = new Dado(); //ogni gara ha il suo dado
            winner = string.Empty; 
            loser = string.Empty;
        }

        public bool FineGara()
        {
            if (numeroPartite == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Winner()
        {
            return winner;
        }
        public void Round()
        {
            Partita partita = new Partita(dado);
            if (partita.AvviaMatch(dado) == 1)
            {
                g1.IncreasePoints();
            }
            else if (partita.AvviaMatch(dado) == 2)
            {
                g2.IncreasePoints();
            }
        }

        public void GameWin()
        {
            if (g1.GetPoints > g2.GetPoints)
            {
                winner = g1.GetName;
            }
            else if (g1.GetPoints < g2.GetPoints)
            {
                winner = g2.GetName;
            }
        }

        public void ResetGame()
        {
            numeroPartite = buffer;
        }

    }
}
