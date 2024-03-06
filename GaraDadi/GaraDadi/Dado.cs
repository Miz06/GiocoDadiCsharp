using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GaraDadi
{
    internal class Dado
    {//ogni giocatore ha un dado con gli operatori
        Random randomNumber;
        int num, facce;

        public Dado(int _facce)
        {
            randomNumber = new Random();
            facce = _facce;
        }

        public void LancioDado()
        {
            num = randomNumber.Next(1, facce+1);
        }

        public static bool operator > (Dado d1, Dado d2)
        {
            return (d1.num > d2.num);
        }

        public static bool operator < (Dado d1, Dado d2)
        {
            return (d1.num < d2.num);
        }

        public int GetNum
        {
            get { return num; }
        }
    }
}
