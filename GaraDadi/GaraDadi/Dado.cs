using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraDadi
{
    internal class Dado
    {
        Random randomNumber;
        int num;

        public Dado()
        {
            randomNumber = new Random();
        }

        public int GeneraNumero()
        {
            num = randomNumber.Next(1, 7);
            return num;
        }

        public int GetNumero
        {
            get { return num; }
        }
    }
}
