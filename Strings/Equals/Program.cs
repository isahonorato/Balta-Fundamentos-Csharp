using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Retorna um boleano e verifica se os textos são iguais. 
            var texto = "Bom dia Isa!";

            Console.WriteLine(texto.Equals("Bom dia Isa!"));
            Console.WriteLine(texto.Equals("bom dia Isa!"));
            Console.WriteLine(texto.Equals("BOM DIA ISA!", StringComparison.OrdinalIgnoreCase));
        }
    }
}
