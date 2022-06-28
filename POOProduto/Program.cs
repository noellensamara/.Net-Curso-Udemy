using System;

namespace POOProduto
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto oProduto = new Produto();

            Console.WriteLine("Entre com os Dados do Produto:");
            Console.Write("Nome:");
             oProduto.Nome = Console.ReadLine();

            Console.Write("Preço:");
             oProduto.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade:");
             oProduto.Quantidade = int.Parse(Console.ReadLine());


            //Console.WriteLine($"Dados do Produto: {oProduto.Nome}, R${oProduto.Preco:F2}, {oProduto.Quantidade} unidades. Total em valor: R$ {oProduto.ValorTotalEmEstoque():F2} ");
            Console.WriteLine("Dados do Produto:" + oProduto);


            #region Adicionar Produtos

            Console.WriteLine("Digite o número de produtos a ser adicionado:");
            int qtdProd = int.Parse(Console.ReadLine());


            oProduto.AdicionarProdutos(qtdProd); //não tem como atribuir numa variavel, só chamo o método

            //Console.WriteLine($"Dados Atualizados: {oProduto.Nome}, R${oProduto.Preco:F2}, {oProduto.Quantidade} unidades. Total em valor: R$ {oProduto.ValorTotalEmEstoque():F2}");
            Console.WriteLine("Dados Atualizados:" + oProduto);
            #endregion


            #region Remover Produtos

            Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
            qtdProd = int.Parse(Console.ReadLine());

            //chama metodo
            oProduto.RemoverProdutos(qtdProd);

            //Console.WriteLine($"Dados Atualizados: {oProduto.Nome}, R${oProduto.Preco:F2}, {oProduto.Quantidade} unidades. Total em valor: R$ {oProduto.ValorTotalEmEstoque():F2}");
            Console.WriteLine("Dados Atualizados:" + oProduto);

            #endregion


        }
    }
}
