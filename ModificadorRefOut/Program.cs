using System;

namespace ModificadorRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora2 oCalc = new Calculadora2();
            int a = 10; //com o ref é obrigado iniciar a variável
            
            Calculadora2.Triplicar(ref a);  //Mudar o valor da referencia da variável                      
            
            Console.WriteLine(a);


            Console.WriteLine("---------------------------------------------");


            int recebeValor;

            Calculadora2.TriplicarOut(a, out recebeValor);

            Console.WriteLine(recebeValor);


        }
    }
}
