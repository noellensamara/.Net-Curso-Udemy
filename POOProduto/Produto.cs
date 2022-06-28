using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOProduto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        //ToString com sobreposição - começa digitando override To... e da enter
        public override string ToString()
        {
            return Nome + ", R$" + Preco.ToString("F2") + ", " + Quantidade + " unidades. Total em valor: R$" + ValorTotalEmEstoque() ;
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
