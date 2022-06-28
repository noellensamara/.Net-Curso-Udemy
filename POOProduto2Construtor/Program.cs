using System;

namespace POOProduto2Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Entre com os Dados do Produto:");
            Console.Write("Nome:");
            string vnome = Console.ReadLine();

            Console.Write("Preço:");
            double vpreco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade:");
            int vqtd = int.Parse(Console.ReadLine()); 


            //construtor indo 2 com parametros
            Produto2 oProduto = new Produto2(vnome, vpreco);


            //construtor indo sem parametro
            Produto2 oProduto2 = new Produto2();

            //construtor já passado com parametro e valores
            Produto2 oProduto3 = new Produto2
            {
                Nome = "TV",
                Preco = 20,
                Quantidade = 5
            };







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
