using System;

namespace Exe1Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número de estudantes");
            int numEstudantes = int.Parse(Console.ReadLine());

            
            Estudante[] vetorEstudante = new Estudante[10]; //Qtd de vezes a percorrer no laço for

            int i;

            for (i = 0; i < numEstudantes; i++)
            {
                Console.WriteLine("Informe o nome");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe o email");
                string email = Console.ReadLine();

                Console.WriteLine("Informe o quarto escolhido");
                int quartoEscolhido = int.Parse(Console.ReadLine());

                vetorEstudante[quartoEscolhido] = new Estudante { Nome = nome, Email = email, Quarto = quartoEscolhido };

            }

            for (i = 0; i < 10; i++)
            {
                
                if (vetorEstudante[i] != null)
                    //Console.WriteLine($"Num Vetor{i} - {vetorEstudante[i].Quarto}: {vetorEstudante[i].Nome} , {vetorEstudante[i].Email}");               
                    Console.WriteLine(i + ": " + vetorEstudante[i]);

            }
        }
    }
}
