using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeDolarStatic
{
    class ConversorDeMoeda
    {

        public static double Iof = 0.06;

        public static double ConverterMoeda(double dolar, double qtddolar)
        {

            double valorBruto = dolar * qtddolar;
            return valorBruto - (valorBruto * Iof);


        }

    }
}
