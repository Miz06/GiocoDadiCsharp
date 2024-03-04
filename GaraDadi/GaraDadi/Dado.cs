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

        public Dado()
        {
             randomNumber = new Random();
        }

        public int GeneraNumero()
        {
            return randomNumber.Next(1, 7);
        }
    }
}
