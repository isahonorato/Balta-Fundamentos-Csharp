using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoParaMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizamos o decimal para trabalhar com valores de moeda.
            decimal valor = 10.25m; //Precisa do m no final
            //Console.WriteLine(valor);

            //Formatando moedas
            Console.WriteLine(valor.ToString(
                "C", //coloca o R$ - padrão de moeda e segue assim para cada país (F, G, C, D, N, P)
                CultureInfo.CreateSpecificCulture("pt-BR")));

            //Math - operações matemáticas
            Console.WriteLine(Math.Round(valor)); //Arredonda o valor
            Console.WriteLine(Math.Ceiling(valor)); //Arredonda p cima
            Console.WriteLine(Math.Floor(valor)); //Arredonda p baixo

            Console.ReadKey();
        }
    }
}
