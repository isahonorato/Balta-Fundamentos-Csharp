using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparacao_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //O compareTo permite que você compare uma string com algum objeto e retorna um inteiro.
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.CompareTo("Teste"));
            Console.WriteLine(texto.CompareTo("teste"));

            //Esse método retorna se a string contém um pedaço de texto e retorna um boleano.
            Console.WriteLine(texto.Contains("teste"));
            //Para ignorar o case sensitive com esse método, basta usar
            Console.WriteLine(texto.Contains("teste", StringComparison.OrdinalIgnoreCase));

            Console.ReadKey();
        }
    }
}

