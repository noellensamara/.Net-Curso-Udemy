using System;

namespace POOExeSalarioPorcentagem
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa oPessoa = new Pessoa();

            Console.WriteLine("Informe os dados do Funcionário");
            Console.Write("Nome: ");
            oPessoa.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            oPessoa.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            oPessoa.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + oPessoa);

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário:");
            double porcentagem = double.Parse(Console.ReadLine());

            oPessoa.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados " + oPessoa);



        }
    }
}
