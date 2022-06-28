using System;

namespace POOClasseTriangulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo2 oTriangulo = new Triangulo2();

            oTriangulo.A = 3;
            oTriangulo.B = 4;
            oTriangulo.C = 5;

            double areaX = oTriangulo.Area();


            oTriangulo.A = 7.50;
            oTriangulo.B = 4.50;
            oTriangulo.C = 4.02;



            double areaY = oTriangulo.Area();

            Console.WriteLine($"A área e X é {areaX} e a de Y é {areaY:F2}");


        }
    }
}
