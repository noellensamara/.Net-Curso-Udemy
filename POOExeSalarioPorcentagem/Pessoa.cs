using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExeSalarioPorcentagem
{
    class Pessoa
    {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public override string ToString()
        {
            return Nome + ", R$" + SalarioLiquido();
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
            
        }

        public void AumentarSalario(double porcentagem)
        {

            SalarioBruto = SalarioBruto + (SalarioBruto * (porcentagem / 100));
        
        }



    }
}
