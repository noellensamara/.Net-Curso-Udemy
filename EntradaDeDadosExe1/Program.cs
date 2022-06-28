using System;

namespace EntradaDeDadosExe1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu último nome, idade e altura(mesma linha, separado com ;) ");
            string variasPalavras = Console.ReadLine();
            string[] vet = variasPalavras.Split(";");

            string ultNome = vet[0];
            string idade = vet[1];
            string altura = vet[2];

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2"));

            Console.WriteLine(ultNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);


        }
    }
}
