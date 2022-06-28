using System;

namespace ExpressaoTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = (x == 10) ? x + 1 : x - 1;
            //     condicao    se verdadeiro  :  se falso

            Console.WriteLine(y);
        }
    }
}
