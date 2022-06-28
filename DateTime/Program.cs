using System;

namespace DateTimeTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2018,11,25); //data
            DateTime d2 = DateTime.Now; //data de hoje
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03); //data e hora


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            //Propriedades do DateTime
            Console.WriteLine(d3.Day);
            Console.WriteLine(d2.DayOfWeek);

            //Formatação de Data
            Console.WriteLine(d3.ToLongDateString()); //Data inteira
            Console.WriteLine(d3.ToLongTimeString()); //hora completa hh:mm:ss
            Console.WriteLine(d3.ToShortDateString()); //Data curta
            Console.WriteLine(d3.ToShortTimeString()); //Hora curta, só hh:mm

            //mascara de formatação - cada simbolo é uma coisa
            string d4 = d3.ToString("yyyy-MM-dd HH:mm:ss");
            string d5 = d3.ToString("yy-MMMM-ddd");

            Console.WriteLine("----------------------------------------");

            Console.WriteLine(d4);
            Console.WriteLine(d5);

            //Operações
            DateTime d6 = d3.AddDays(2); //Adiciona dias à data, tem várias opções de Add 

            TimeSpan d7 = d6.Subtract(d3); //Diferença entre datas

            

            Console.WriteLine("----------------------------------------");

            Console.WriteLine(d6);
            Console.WriteLine(d7);





        }
    }
}
