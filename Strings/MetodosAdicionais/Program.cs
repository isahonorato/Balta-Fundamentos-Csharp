using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAdicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var texto = "Buenas tardes!";

            Console.WriteLine(texto.ToUpper()); //Transforma tudo em maiúsculo
            Console.WriteLine(texto.ToLower()); //Transforma tudo em minúsculo
            Console.WriteLine(texto.Insert(5, "AQUI")); //Insere o que você quiser na posição do caractere indicada
            Console.WriteLine(texto.Remove(5,5)); //Remove o que você quiser na posição do caractere indicada. (Precisa indicar onde começa e quanto irá remover)
            Console.WriteLine(texto.Length); //Conta a quantidade de caracteres
        }
    }
}
