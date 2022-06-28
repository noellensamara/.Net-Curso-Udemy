using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Noellen","Samara","Ivani" }; //declaração de vetor já com valores

            foreach (string obj in vetor) //obj é como um apelido para cada objeto do vetor
            {
                Console.WriteLine(obj); //coloca o obj para imprimir, não precisa mais especificar a posição
            }

        }
    }
}
