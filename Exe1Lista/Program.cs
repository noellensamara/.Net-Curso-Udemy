using System;
using System.Collections.Generic;

namespace Exe1Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de funcionários");
            int qtdFunc = int.Parse(Console.ReadLine());

                       
            List<Funcionario> lista = new List<Funcionario>();

            int i;
            for (i = 0; i < qtdFunc; i++)
            {
               
                Console.Write("Informe o ID: ");
                int id = (int.Parse(Console.ReadLine()));               

                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Informe o Salario: ");
                double salario = (double.Parse(Console.ReadLine()));

                lista.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("Qual id deseja alterar o salário?");
            int funcAltSal = int.Parse(Console.ReadLine());

            Console.Write("Qual a porcentagem?");
            double porcentagem = double.Parse(Console.ReadLine());


            Funcionario alterFuncLista = lista.Find(x => x.Id == funcAltSal);
            if (alterFuncLista != null)
            {
                alterFuncLista.AlterarSalario(porcentagem);
            }
            else
                Console.WriteLine("Funcionario não existe");




            foreach (Funcionario obj in lista)
            {
                Console.WriteLine("Dados Atualizados: " + obj);
                
            }

            



        }
    }
}
