using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Calculadora***");
            Console.WriteLine();
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Qual cálculo deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Selecione uma opção:");
            short resposta = short.Parse(Console.ReadLine());
            
            Console.Clear();

            switch (resposta)
            {
                case 1: Soma(); break; 
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.WriteLine("Insira o primeiro valor: ");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = numero1 + numero2;
            Console.WriteLine($"O resultado da soma é: {resultado}");

            Console.WriteLine();
            Console.WriteLine("Aperte a tecla ENTER");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        static void Subtracao()
        {
            Console.WriteLine("Insira o primeiro valor: ");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = numero1 - numero2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");

            Console.WriteLine();
            Console.WriteLine("Aperte a tecla ENTER");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        static void Divisao()
        {
            Console.WriteLine("Insira o primeiro valor: ");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = numero1 / numero2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");

            Console.WriteLine();
            Console.WriteLine("Aperte a tecla ENTER");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Insira o primeiro valor: ");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = numero1 * numero2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");

            Console.WriteLine();
            Console.WriteLine("Aperte a tecla ENTER");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
    }
}
