using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cronometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos 10s = 10 segundos");
            Console.WriteLine("M = Minuto 1m = 1 minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string dados = Console.ReadLine().ToLower();
            char type = char.Parse(dados.Substring(dados.Length -1, 1));
            int time = int.Parse(dados.Substring(0, dados.Length -1));
            int multiplier = 1;

            if(type == 'm')

                multiplier = 60;

            if(time == 0)

                System.Environment.Exit(0);
            PreStart(time * multiplier);

        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Fogo!");
            Thread.Sleep(2500);
            Start(time);
        }
        static void Start( int tempo)
        {
            int tempoAtual = 0;

            while (tempoAtual != tempo)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronômetro finalizado");
            Thread.Sleep(2000);
            Menu();
        }
    }
}
