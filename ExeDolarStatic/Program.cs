using System;

namespace ExeDolarStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dólar?");
            double dolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você vai comprar?");
            double comprarDolar = double.Parse(Console.ReadLine());


            Console.WriteLine("Valor a ser pago: " + ConversorDeMoeda.ConverterMoeda(dolar, comprarDolar));


        }
    }
}
