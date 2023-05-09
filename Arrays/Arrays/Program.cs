using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //O array é uma lista/vetor e a sua posição inicial sempre começa do zero

            //Se eu tenho um array de 5, significa que eu estou percorrendo ele de 0 a 4
            var meuArray = new int[5];

            meuArray[0] = 1; meuArray[1] = 2; meuArray[2] = 3; meuArray[3] = 4;

            Console.WriteLine(meuArray[2]);

            Console.ReadKey();
        }
    }
}
