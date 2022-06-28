using System;

namespace DataEHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = DateTime.Now.ToString("hh:mm:ss tt");
            Console.WriteLine(a);

            Console.WriteLine("---------------------------------------------");


            DateTime b = DateTime.Today;
            Console.WriteLine(b.ToString("d")); //só a data
            Console.WriteLine(b.ToString("D")); //data por extenso
            Console.WriteLine(b.ToString("g")); //data e hora */

            Console.WriteLine("---------------------------------------------");

            DateTime[] dates = { DateTime.Now,
                           new DateTime(2013, 9, 14, 9, 28, 0),
                           new DateTime(2011, 5, 28, 10, 35, 0),
                           new DateTime(1979, 12, 25, 14, 30, 0) };
            foreach (var date in dates)
            {
                Console.WriteLine("Day: {0:d} Time: {1:g}", date.Date, date.TimeOfDay);
                Console.WriteLine("Day: {0:d} Time: {0:t}\n", date);
            }

        }
    }
}
