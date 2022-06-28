using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("O nome é " + nome);



            Console.WriteLine("Informe 3 palavras");
            string s = Console.ReadLine();
            string[] armazenaPalavras = s.Split(' ');
            string var1 = armazenaPalavras[0];
            string var2 = armazenaPalavras[1];
            string var3 = armazenaPalavras[2];
            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);



            int n1 = int.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //coloca o invariant se quiser que entenda com ponto, e não vírgula

            Console.WriteLine(n1);
            Console.WriteLine(n2);


        }
    }
}
