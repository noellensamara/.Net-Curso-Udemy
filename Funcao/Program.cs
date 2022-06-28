using System;

namespace Funcao
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite 3 números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3); //chamada do método (função) com parametros

            Console.WriteLine("Maior é: " + resultado);
        }

        static int Maior(int a, int b, int c) //Criando um método = static tipo e nome
        {
            int m;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
                m = b;
            else m = c;

            return m;


        }
    }
}
