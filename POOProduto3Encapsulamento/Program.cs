using System;

namespace POOProduto3Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os Dados do Produto:");
            Console.Write("Nome:");
            string vnome = Console.ReadLine();

           /* Console.Write("Preço:");
            double vpreco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade:");
            int vqtd = int.Parse(Console.ReadLine()); */

            //construtor
            Produto3 oProduto = new Produto3 (vnome);

            Console.WriteLine(oProduto.GetNome()); //metodo para receber o nome

            Console.WriteLine("Entre com os Dados do Produto:");
            Console.Write("Nome:");
            vnome = Console.ReadLine();

            oProduto.SetNome(vnome); //metodo para alterar o nome

            Console.WriteLine(oProduto.GetNome()); //metodo para receber o nome
        }
    }
}
