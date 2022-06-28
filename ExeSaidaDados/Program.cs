using System;

namespace ExeSaidaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            string nome = "Noellen";
            double saldo = 10.3584;

            //placeholders
            Console.WriteLine("(placeholders) / {0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo);

            //interpolação
            Console.WriteLine($"(interpolação) / {nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); ;

            //concatenação
            Console.WriteLine("(concatenação) / " + nome + "tem" + idade + "anos e tem saldo igual a " + saldo.ToString("F2") + "reais");
        }
    }
}
