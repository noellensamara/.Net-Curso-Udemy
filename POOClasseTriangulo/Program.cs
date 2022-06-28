using System;

namespace POOClasseTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo xTriangulo = new Triangulo(); //instanciando uam classe        

            xTriangulo.A = 3; //atribuindo valor aos atributos
            xTriangulo.B = 4;
            xTriangulo.C = 5;

            double areaX = area(xTriangulo.A, xTriangulo.B, xTriangulo.C);



            Triangulo yTriangulo = new Triangulo();

            yTriangulo.A = 7.50;
            yTriangulo.B = 4.50;
            yTriangulo.C = 4.02;

            double areaY = area(yTriangulo.A, yTriangulo.B, yTriangulo.C);

            Console.WriteLine($"A área de X é {areaX} e a área de Y é {areaY:F2}");

            if (areaY > areaX)
                Console.WriteLine("Y é maior");
            else
                Console.WriteLine("X é maior");

        }

        static double area (double a, double b, double c)
        {

            double p = (a + b + c) / 2;
            double resultado = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return resultado;


        }
    }
}
