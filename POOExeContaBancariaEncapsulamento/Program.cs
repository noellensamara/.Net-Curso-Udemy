using System;

namespace POOExeContaBancariaEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Write("Informe o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Informe o títular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? Informe s ou n: ");
            char haveraDeposito = char.Parse(Console.ReadLine());

            double valor = 0;

            if (haveraDeposito == 's')
            {
                Console.Write("Informe o valor do depósito inicial: ");
                valor = double.Parse(Console.ReadLine());
            }

            Cliente oCliente = new Cliente(numConta, nomeTitular, valor);

            Console.WriteLine("Dados da Conta");
            Console.WriteLine(oCliente);

            /*****************************  Parte 2 - Depósito *******************************/

            Console.Write("Informe um valor para depósito: ");
            valor = double.Parse(Console.ReadLine());

            oCliente.Deposito(valor);

            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(oCliente);

            /*****************************  Parte 3 - Saque *******************************/

            Console.Write("Informe um valor para saque: ");
            valor = double.Parse(Console.ReadLine());

            oCliente.Saque(valor);

            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(oCliente);


            Console.WriteLine("Deseja continuar? s ou n");
            char continuar = char.Parse(Console.ReadLine());

            if (continuar == 's')
            {
                goto Inicio;
            }
            



        }
    }
}
