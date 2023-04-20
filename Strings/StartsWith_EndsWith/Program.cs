using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartsWith_EndsWith
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //StartsWith/EndsWith - Começa com / Termina com 
            //Valida se a string começa ou termina com o valor indicado e retorna um boleano
            var texto = "Esse texto é um teste";

            Console.WriteLine(texto.StartsWith("Esse"));
            Console.WriteLine(texto.StartsWith("esse", StringComparison.OrdinalIgnoreCase)); //para ignorar o case sensitive
            Console.WriteLine(texto.StartsWith("texto"));

            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.StartsWith("Teste"));

            Console.ReadKey();
        }
    }
}
