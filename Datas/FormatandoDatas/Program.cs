using System;


namespace FormatandoDatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = DateTime.Now;

            // Y = ano, M = mes, D = dia, H = hora, S = segundo

            //Y = ano
            //var formatada = String.Format("{0:yyyy}", data);

            //M = mes
            //var formatada = String.Format("{0:M}", data);

            //D = dia
            //var formatada = String.Format("{0:D}", data);

            //Hora
            //var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss }", data);

            //Aparece somente a hora e mins com o t e com o T exibe os segundos
            //var formatada = String.Format("{0:t}", data);

            //Data no padrão que muitos sistemas usam
            //var formatada = String.Format("{0:r}", data);

            //Geralmente é o tipo de formato utilizado em JSON
            //var formatada = String.Format("{0:s}", data);

            //Padrão universal
            var formatada = String.Format("{0:u}", data);

            Console.WriteLine(formatada);

            Console.ReadKey();
        }
    }
}
