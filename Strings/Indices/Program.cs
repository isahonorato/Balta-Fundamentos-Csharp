using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //O índice indica a posição de um caractere em uma lista/array. 
            var texto = "Bom dia Isa! Oi Isa";
            Console.WriteLine(texto.IndexOf("dia")); //Sempre passar dentro do IndexOf coisas do mesmo tipo (int, double e etc)
            Console.WriteLine(texto.LastIndexOf("Isa")); //O último index que o programa encontrar


            Console.ReadKey();
        }
    }
}
