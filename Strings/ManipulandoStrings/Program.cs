using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Troca uma objeto por outro.
            var texto = "A baleia é amiga da sereia";
            Console.WriteLine(texto.Replace("amiga","colega"));

            //O split é usado para dividir
            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            Console.ReadKey();
        }
    }
}
