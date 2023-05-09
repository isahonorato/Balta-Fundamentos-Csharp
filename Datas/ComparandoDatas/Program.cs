using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparandoDatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = DateTime.Now;

            if(data.Date == DateTime.Now.Date) {
                Console.WriteLine("É igual");
            }

            Console.WriteLine(data);
            Console.ReadKey();
        }
    }
}
