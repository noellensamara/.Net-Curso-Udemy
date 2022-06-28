using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOProduto3Encapsulamento
{
    class Produto3
    {

        private string _nome;
        private double _preco;
        private int _quantidade; //

            

        //Construtor
        public Produto3(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        
        }

        public Produto3(string nome)
        {

            _nome = nome;
        
        }

        //metodos get - para obter o nome do produto na classe principal
        public string GetNome()
        {
            return _nome;
        
        }

        //metodo set - se quiser alterar o nome, ele é void pq ele não retorna nada, quem retorna é o get
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1  )
                 _nome = nome;            
        }

        //ToString com sobreposição - começa digitando override To... e da enter
        public override string ToString()
        {
            return _nome + ", R$" + _preco.ToString("F2") + ", " + _quantidade + " unidades. Total em valor: R$" + ValorTotalEmEstoque();
        }


        public double ValorTotalEmEstoque()
        {
            double valor = _preco * _quantidade;
            return valor;
        }

        public void AdicionarProdutos(int qtd)
        {
            _quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            _quantidade -= qtd;
        }

    }
}
