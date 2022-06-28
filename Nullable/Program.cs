using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null; //quer dizer que valor para essa variável é opcional
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault()); //pega o valor de x ou o valor padrão da variavel, que no caso é 0
            Console.WriteLine(x.HasValue); //diz se a variavel tem valor - false
            
            if (x.HasValue)            
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X é null");

            Console.WriteLine("-----------------------------------");

            //se o valor de x não for nulo, atribui o valor, se for nulo, joga o outro valor

            double? a = null;
            double? b = 8;

            double c = a ?? 5;
            double d = b ?? 5;

            Console.WriteLine(c);
            Console.WriteLine(d);



        }
    }
}
