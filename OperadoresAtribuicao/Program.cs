using System;

namespace OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b;
            int c = 0;
            int d = 0;
            int e = 0;

            b = a++;
            c += a;
            d = +a;
            e = ++a;
            
            
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("e = " + e);
        }
    }
}
