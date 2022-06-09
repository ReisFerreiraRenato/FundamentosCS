using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        //var data = new DateTime(2020, 10, 12, 13, 23, 14);
        var data = DateTime.Now;
        /*Console.WriteLine(data);
        Console.WriteLine(data.Year);
        Console.WriteLine(data.Month);
        Console.WriteLine(data.Day);
        Console.WriteLine(data.Hour);
        Console.WriteLine(data.Minute);
        Console.WriteLine(data.Second);
        Console.WriteLine(data.DayOfWeek);
        Console.WriteLine((int)data.DayOfWeek);
        Console.WriteLine(data.DayOfYear);
        
        */
        //Y - Year, M - Mês, d - dia, h - hora, s - segundo, m - minuto 
        /*
        var formatada = String.Format("{0:yyyy}", data);
        Console.WriteLine(formatada);
        formatada = String.Format("{0:yyyy-MM-dd}", data);
        Console.WriteLine(formatada);
        formatada = String.Format("{0:dd/MM/yyyy}", data);
        Console.WriteLine(formatada);
        formatada = String.Format("{0:dd * MM * yyyy HH:mm:ss ff z}", data);
        Console.WriteLine(formatada);

        formatada = String.Format("{0:M}", data); 
        Console.WriteLine(formatada);
        formatada = String.Format("{0:d}", data); 
        Console.WriteLine(formatada);
        formatada = String.Format("{0:HH}", data); 
        Console.WriteLine(formatada);
        formatada = String.Format("{0:mm}", data); 
        Console.WriteLine(formatada);
        formatada = String.Format("{0:t}", data); 
        Console.WriteLine(formatada);
        formatada = String.Format("{0:T}", data); 
        Console.WriteLine(formatada);
        formatada = String.Format("{0:d}", data); 
        Console.WriteLine(formatada);
        formatada = String.Format("{0:D}", data); 
        Console.WriteLine(formatada);
        formatada = String.Format("{0:f}", data); 
        Console.WriteLine(formatada);
        formatada = String.Format("{0:F}", data); 
        Console.WriteLine(formatada);
        formatada = String.Format("{0:g}", data); 
        Console.WriteLine(formatada);
        formatada = String.Format("{0:G}", data); 
        Console.WriteLine(formatada);
        formatada = String.Format("{0:r}", data); //padrão internacional
        Console.WriteLine(formatada);
        formatada = String.Format("{0:s}", data); //padrão Json
        Console.WriteLine(formatada);
        formatada = String.Format("{0:u}", data); //padrão Universal
        Console.WriteLine(formatada);
        */
        /*Console.WriteLine(data);
        var dia = data.Day + 1 ; //Evitar fazer pode ser virada de mês o ideal é utilizar as funções abaixo
        Console.WriteLine(dia);
        Console.WriteLine(data.AddDays(12));
        Console.WriteLine(data.AddDays(-12));
        Console.WriteLine(data.AddMonths(1));
        Console.WriteLine(data.AddYears(1));
        Console.WriteLine(data.AddHours(3));
        Console.WriteLine(data.AddMinutes(3));
        Console.WriteLine(data.AddSeconds(3));
        */

        //DateTime? data = null; //pode ser nula
        /*
        if(data == DateTime.Now)
        {
            Console.WriteLine("É igual!");
        }
        if(data.Date == DateTime.Now.Date)
        {
            Console.WriteLine("As datas são iguais!");
        }
        if(data.Date > DateTime.Now.Date)
        {
            Console.WriteLine("A data é maior!");
        }
        if(data.Date >= DateTime.Now.Date)
        {
            Console.WriteLine("A data é maior opu igual!");
        }
        */
        //Globalização
        /*var pt = new CultureInfo("pt-PT");
        var br = new CultureInfo("pt-BR");
        var en = new CultureInfo("en-US");
        var de = new CultureInfo("de-DE");
        var atual = CultureInfo.CurrentCulture; //Pega a cultura da máquina

        Console.WriteLine(data);
        Console.WriteLine(string.Format("{0}", data));
        Console.WriteLine(data.ToString("D", pt));
        Console.WriteLine(data.ToString("D", br));
        Console.WriteLine(data.ToString("D", en));
        Console.WriteLine(data.ToString("D", de));
        Console.WriteLine(data.ToString("D", atual));

        */
        //Timezone
        /*var utcDate = DateTime.UtcNow;
        Console.WriteLine(utcDate);
        Console.WriteLine(DateTime.Now);

        Console.WriteLine(utcDate.ToLocalTime());
        var timezoneAutralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
        Console.WriteLine(timezoneAutralia);

        var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAutralia);

        Console.WriteLine(horaAustralia);

        var timezones = TimeZoneInfo.GetSystemTimeZones();

        foreach (var timezone in timezones)
        {
            Console.WriteLine(timezone.Id);
            Console.WriteLine(timezone);
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
            Console.WriteLine("-----------");
        }
        */
        var timeSpan = new TimeSpan();
        Console.WriteLine(timeSpan);

        var timeSpanNanosegundos = new TimeSpan(1);
        Console.WriteLine(timeSpanNanosegundos);

        var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
        Console.WriteLine(timeSpanHoraMinutoSegundo);

        var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

        var timeSpanDiaHoraMinutoSegundoMilisegundo = new TimeSpan(15, 12, 55, 8, 100);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilisegundo);

        Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Hours);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Minutes);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Seconds);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Milliseconds);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

        Console.WriteLine(DateTime.DaysInMonth(2020, 2)); //Quantos dias tem o mês
        Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
        Console.WriteLine(DateTime.Now.IsDaylightSavingTime()); //Horário de verão baseado na cultura da data
    }

    static bool IsWeekend(DayOfWeek today) //Verifica se é final de semana
    {
        return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
    }
}