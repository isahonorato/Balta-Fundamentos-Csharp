using System;

namespace TimeZone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Horario global
            var dateTime = DateTime.UtcNow;
            Console.WriteLine(dateTime);

            //Pega a hora do servidor
            Console.WriteLine(DateTime.Now);
            
            //Data local
            Console.WriteLine(dateTime.ToLocalTime());

            //Pegar o horário de um país
            //var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            //Console.WriteLine(timezoneAustralia);

            ////Convertendo horário de um país

            //var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);
            //Console.WriteLine(horaAustralia);

            //Buscar as timezones disponíveis
            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
                Console.WriteLine("-----------------");
            }

            Console.ReadKey();
        }
    }
}
