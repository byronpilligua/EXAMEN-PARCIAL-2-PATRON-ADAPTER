using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Adapter
{
    // Esta es la clase que deseamos adaptar.
    class CalculadorArray
    {
        public double suma(int[] operandos)
        {
            int n = 0;
            double r = 0;

            for (n = 0; n < operandos.Length; n++)
            {
                r += operandos[n];
            }
            return r;
        }
    }
}
