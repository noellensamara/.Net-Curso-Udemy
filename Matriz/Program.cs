using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2,3]; //instancia uma matriz de 2 colunas e 3 linhas

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
