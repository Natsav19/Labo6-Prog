using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Calculateur
    {
        public int Diviser (int x, int y)
        {
            int total = x / y;
            return total;
        }

        public double Multiplier(int x, int y)
        {
            double total = x * y;
            return total;
        }
    }
}
