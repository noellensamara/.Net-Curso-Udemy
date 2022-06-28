using System;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //vamos determinar a qtd de posições no vetor
            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];
            int i;

            for (i = 0; i < n; i++)
            {

                vetor[i] = double.Parse(Console.ReadLine());
            
            }

            for (i = 0; i < n; i++ )
            {
                Console.WriteLine(vetor[i]);            
            }

        }
    }
}
