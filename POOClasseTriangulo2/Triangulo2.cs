using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOClasseTriangulo2
{
    class Triangulo2
    {

        public double A;
        public double B;
        public double C;

        public double Area() //o () seriam os parametros, mas aqui não é necessario receber nada
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); //pode dar return direto na formula

        }


    }
}
