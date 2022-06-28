using System;
using System.Collections.Generic; //necessário para uso de listas

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------> declarar e já instanciar a lista
            List<string> lista = new List<string>();

            //lista.Add(new Produto(....colocaria os valores dos produtos)) pode ser uma lista de Classe(referencia) tbm
            lista.Add("Maria"); //add adiciona do inicio ao final da lista
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Insert(2, "Marco"); //com o insert, é possível definir a posição de cada elemento, exemplo "2"


            foreach (string obj in lista) //leitura da lista
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("O tamanho da lista é " + lista.Count); //contador de registros da lista

            string s1 = lista.Find(Test); //o Find recebe como argumento uma função com o que queremos, no caso retornar um nome que comece com A
            Console.WriteLine("Primeiro nome com A: " + s1);

            //OU abaixo tem exemplo de expressão lambda

            s1 = lista.Find(x => x[0] == 'M');
            Console.WriteLine("Primeiro nome com M: " + s1);

            string s2 = lista.FindLast(x => x[0] == 'M');
            Console.WriteLine("O último nome com M:" + s2);

            //Posição
            int pos1 = lista.FindIndex(x => x[0] == 'M');
            Console.WriteLine("Posição começando com M: " + pos1);

            pos1 = lista.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine("Última começando com M: " + pos1);


            Console.WriteLine("--------------------");


            //Retornar todos com os filtros determinados, no caso nomes com tamanho 5
            List<string> lista2 = lista.FindAll(x => x.Length == 5);
            foreach (string obj in lista2)
            {
                Console.WriteLine(obj);                
            }

            Console.WriteLine("--------------------");

            //Remover itens da lista
            lista.Remove("Bob");
            foreach (string obj in lista) //leitura da lista
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------");

            //Remove todos conforme condição
            lista.RemoveAll(x => x[0] == 'M');
            foreach (string obj in lista) //leitura da lista
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------");


            //Remover pela posição
            lista.RemoveAt(0);
            foreach (string obj in lista) //leitura da lista
            {
                Console.WriteLine(obj);
            }

        }

        static bool Test(string s)
        {
            return s[0] == 'A';
        }

    }
}
