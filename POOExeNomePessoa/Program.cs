using System;

namespace POOExeNomePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa oPessoa1 = new Pessoa();

            Console.WriteLine("Insira o nome e idade da Pessoa 1");
            oPessoa1.nome = Console.ReadLine();
            oPessoa1.idade = int.Parse(Console.ReadLine());


            Pessoa oPessoa2 = new Pessoa();

            Console.WriteLine("Insira o nome e idade da Pessoa 2");
            oPessoa2.nome = Console.ReadLine();
            oPessoa2.idade = int.Parse(Console.ReadLine());

            if (oPessoa1.idade > oPessoa2.idade)
                Console.WriteLine($"A pessoa {oPessoa1.nome} é mais velha");
            else if (oPessoa2.idade > oPessoa1.idade)
                Console.WriteLine($"A pessoa {oPessoa2.nome} é mais velha");
            else Console.WriteLine("As duas tem a mesma idade");
           

        }
    }
}
