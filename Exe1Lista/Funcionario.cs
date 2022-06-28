using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1Lista
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salar)
        {
            Id = id;
            Nome = nome;
            Salario = salar;
        
        }


        public void AlterarSalario(double porcentagem)
        {
            Salario += (Salario * (porcentagem / 100));
        }


        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2");
        }


    }
}
