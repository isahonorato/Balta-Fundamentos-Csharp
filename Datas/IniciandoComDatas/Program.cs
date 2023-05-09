using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoComDatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //O datetime é um struct

            //var data = new DateTime(); //Busca a data 01/01/01

            //var data = DateTime.Now; //Busca a data atual

            var data = new DateTime(2023, 05, 07, 20, 07, 15); //Criando uma data com ano, mês, dia, horas, minutos e segs

            Console.WriteLine(data);

            //Imprime a data separada
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            //Busca o dia da semana
            Console.WriteLine(data.DayOfWeek);

            Console.ReadKey();
        }
    }
}
