using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraDadi
{
    internal class Giocatore
    {
        string nome;
        int punteggioCorrente;
        Dado dado;

        public Giocatore(string _nome)
        {
            nome = _nome;
            punteggioCorrente = 0;
            dado = new Dado(6);
        }

        public void IncreasePoints()
        {
            punteggioCorrente++;
        }

        public void RollDice()
        {
            dado.RollDice();
        }

        public void ResetScore()
        {
            punteggioCorrente = 0;
        }

        public int GetNumber()
        {
            return dado.GetNum;
        }

        public static bool operator >(Giocatore g1, Giocatore g2)
        {
            return (g1.punteggioCorrente > g2.punteggioCorrente);
        }

        public static bool operator <(Giocatore g1, Giocatore g2)
        {
            return (g1.punteggioCorrente < g2.punteggioCorrente);
        }

        public int GetPoints
        {
            get { return punteggioCorrente; }
        }

        public string GetName
        {
            get { return nome; }
        }

        public Dado GetDado
        {
            get { return dado; }
        }
    }
}
