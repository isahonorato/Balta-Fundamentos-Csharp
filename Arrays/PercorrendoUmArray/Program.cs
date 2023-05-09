using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercorrendoUmArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meuArray = new int[5] {1,2,3,4,5};
            meuArray[0] = 12;
            

            for (var index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);
            }
            

            Console.ReadKey();
        }
    }
}
