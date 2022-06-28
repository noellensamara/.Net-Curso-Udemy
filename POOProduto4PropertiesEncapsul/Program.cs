using System;

namespace POOProduto4PropertiesEncapsul
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Entre com os Dados do Produto:");
            Console.Write("Nome:");
            string vnome = Console.ReadLine();

            Produto4 oProduto = new Produto4(vnome);


            /*-------------    Exemplo Properties com o Nome      ----------------*/
            Console.WriteLine(oProduto.Nome);

            oProduto.Nome = "Samara";
            

            Console.WriteLine($"Novo nome: {oProduto.Nome}");


            /*------------  Exemplo Auto Properties com preço / quantidade --------------*/

            oProduto.AlterarPreco(10); //metodo enviando o valor de 10, o preço é private, não tem como atribuir direto
            oProduto.Quantidade = 5; //qtd não é private, deixa atribuir normal

            Console.WriteLine($"O valor Total é {oProduto.ValorTotalEstoque()}");







        }
    }
}
