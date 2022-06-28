using System;

namespace Timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0,1,30); //hora minuto segundo
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan();


            Console.WriteLine( t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);



            TimeSpan t4 = new TimeSpan(2,3,5,7,11);
            Console.WriteLine(t4);
            Console.WriteLine(t4.TotalDays); //total de dias

            //Operações
            TimeSpan t5 = new TimeSpan(0, 1, 30);

            TimeSpan soma = t4.Add(t5); //soma de horas
            TimeSpan diferenca = t4.Subtract(t5); //diferença de horas

            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(soma);
            Console.WriteLine(diferenca);

        }
    }
}
