using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Double dec = 9.2;
            Console.WriteLine(Convert.ToDecimal(dec).GetType());
        }
    }
}
