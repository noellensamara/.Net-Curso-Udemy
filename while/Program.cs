using System;

namespace whileExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
        
            }

            Console.WriteLine("Deseja continuar? Digite s ou n");
            char continuar = char.Parse(Console.ReadLine());

            if (continuar == 's')
            {
                goto Inicio;
            }
        }
    }
}
