using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternandoValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assim você atribui o mesmo valor
            //var arr = new int[4];
            //var arrb = arr;

            //Assim você atribui um novo valor
            var arr = new int[4];
            var arrb = new int[5];

            arrb[0] = arr[0];

            Console.WriteLine(arr);

            Console.ReadKey();

        }
    }
}
