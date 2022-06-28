using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOProduto4PropertiesEncapsul
{
    class Produto4
    {

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; set; } //

        //public int MyProperty { get; set; } ------ prop + tab + tab

        //Construtor
        public Produto4(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }

        public Produto4(string nome)
        {
            _nome = nome;
        }

        public string Nome  //properties
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) //nessa condição substitui o que seria o parametro pro value
                    _nome = value;
            }
        }

        public void AlterarPreco(double preco)
        {

            Preco = preco;

        }

        public double ValorTotalEstoque()
        {
            return Preco* Quantidade;
        }
    }
}
