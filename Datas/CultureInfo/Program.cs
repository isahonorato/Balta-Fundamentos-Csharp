using System;
using System.Globalization;

namespace culture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("pt-US");

            Console.WriteLine(DateTime.Now.ToString("D", en));
            Console.ReadKey();  
        }
    }
}
