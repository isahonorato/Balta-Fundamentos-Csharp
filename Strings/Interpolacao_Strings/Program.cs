using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolacao_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interpolação é juntar strings com outros valores

            var price = 10.2;

            // O + serve para concatenar as informações
            var texto = "O preco do produto é " + price;

            //O string.format pega o que está entre chaves {} e coloca o que está depois da vírgula, como um REPLACE.
            var texto1 = string.Format("O preço do produto é {0} apenas na promoção {1}.", price, true);

            //O $ permite que através das chaves {} você coloque a variável desejada para impressão. O @ na frente do $ serve para continuar nessa condição mesmo quebrando a linha.
            var texto2 = $"O preço do produto é {price} apenas na promoção.";

            Console.WriteLine(texto);
            Console.WriteLine(texto1);
            Console.WriteLine(texto2);

            Console.ReadKey();
        }
    }
}
