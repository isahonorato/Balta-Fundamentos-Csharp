using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Adicionando_Valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = DateTime.Now;
            Console.WriteLine(data);

            //Acrescentar algo na data
            Console.WriteLine(data.AddDays(10));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddYears(5));

            Console.ReadKey();  
        }
    }
}
