using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace span
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanoSegundos = new TimeSpan(1, 5, 18); //Hora, min, seg
            Console.WriteLine(timeSpanNanoSegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(1, 5, 1, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            Console.ReadKey();
        }
    }
}
