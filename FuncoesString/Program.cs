using System;

namespace FuncoesString
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Noellen Samara da Silva";

          

            Console.WriteLine("Original: " + nome );
            Console.WriteLine("Maiusculo: " + nome.ToUpper()); //converter tudo para maiusculo
            Console.WriteLine("Maiusculo: " + nome.ToLower()); //converter tudo para minusculo
            Console.WriteLine("Apaga Espaço: " + nome.Trim()); //apaga espaço em branco no inicio e no fim

            int n1 = nome.IndexOf("len");
            Console.WriteLine("Posição: " + n1);
            Console.WriteLine(nome.Substring(3)); //da posição em diante
            Console.WriteLine(nome.Substring(0,7)); //pedaço da string
            Console.WriteLine(nome.Replace("l","")); //substitui

            bool b1 = String.IsNullOrEmpty(nome); //testa se a string é nula/vazia
            Console.WriteLine(b1);
            
            bool b2 = String.IsNullOrWhiteSpace(nome); //testa se a string está com espaço em branco
            Console.WriteLine(b2);


        }
    }
}
