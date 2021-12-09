using System;

namespace Diary.API
{
    public class WeatherForecast
    {
        //Teste mudanca use git. 
        // arquivo sera apagado
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }


        //teste
    }
}
