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

        public Giocatore(string _nome)
        {
            nome = _nome;
            punteggioCorrente= 0;
        }

        public void IncreasePoints()
        {
            punteggioCorrente++;
        }

        public int GetPoints
        {
            get { return punteggioCorrente; }
        }
        public string GetName
        {
            get { return nome; }
        }

    }
}
