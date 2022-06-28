using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorRefOut
{
    class Calculadora2
    {
        public static void Triplicar(ref int x)
        {
            x *= 3;
           
        }

        public static void TriplicarOut(int x, out int resultado)
        {
            resultado = x += 5;

        }
    }
}
