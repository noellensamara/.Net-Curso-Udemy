using System;

namespace Vetor2Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a qtd de produtos");
            int n = int.Parse(Console.ReadLine());

            //um vetor do tipo classe Produto, esse é um exemplo de vetor do tipo referência, esse é o momento que instancia o vetor
            Produto[] vetor = new Produto[n];

            //precisa instanciar o produto e depois colocar no valor - esse é o momento que instancia a referência

            int i;
            for (i = 0; i < n; i++)
            {
                Console.Write("Nome do Produto: ");
                string name = Console.ReadLine();

                Console.Write("Preço do Produto: ");
                double preco = double.Parse(Console.ReadLine());

                //instanciando o produto
                vetor[i] = new Produto { Name = name, Price = preco };
            }

            double soma = 0;
            for (i = 0; i < n; i++)
            {
                soma += vetor[i].Price;
            }


            double media = soma / n;

            Console.WriteLine($"Preço médio de {n} produtos é {media.ToString("F2")} ");

        }
    }
}
