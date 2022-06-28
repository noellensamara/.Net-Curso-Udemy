using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOProduto2Construtor
{
    class Produto2
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor
        /*public Produto2(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        
        } */


        /*public Produto2(string Nome, double Preco, int Quantidade)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;

        } */



        public Produto2(string nome, double preco, int qtd) : this(qtd)
        {

            Nome = nome;
            Preco = preco;
            

        }

        public Produto2(int qtd)
        {
            Quantidade = qtd;
        }






        //ToString com sobreposição - começa digitando override To... e da enter
        public override string ToString()
        {
            return Nome + ", R$" + Preco.ToString("F2") + ", " + Quantidade + " unidades. Total em valor: R$" + ValorTotalEmEstoque();
        }


        public double ValorTotalEmEstoque()
        {
            double valor = Preco * Quantidade;
            return valor;
        }

        public void AdicionarProdutos(int qtd)
        {
            Quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            Quantidade -= qtd;
        }

    }
}
