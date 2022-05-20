namespace PrimerBlazor.Data;

public class WeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {
        WeatherForecast[] arr=new WeatherForecast[5];
        for(int i=0;i<arr.Length;i++)
        {
            WeatherForecast forecast = new WeatherForecast();
            forecast.Date=startDate.AddDays(i);
            forecast.TemperatureC=Random.Shared.Next(-20, 55);
            switch (forecast.TemperatureC)
            {
                case <= -13:
                    forecast.Summary=Summaries[0];
                    break;
                case <= -6:
                    forecast.Summary=Summaries[1];
                    break;
                case <= 2:
                    forecast.Summary=Summaries[2];
                    break;
                case <= 10:
                    forecast.Summary=Summaries[3];
                    break;
                case <= 17:
                    forecast.Summary=Summaries[4];
                    break;
                case <= 24:
                    forecast.Summary=Summaries[5];
                    break;
                case <= 32:
                    forecast.Summary=Summaries[6];
                    break;
                case <= 40:
                    forecast.Summary=Summaries[7];
                    break;
                case <= 47:
                    forecast.Summary=Summaries[8];
                    break;
                case > 47:
                    forecast.Summary=Summaries[9];
                    break;   
            }
            arr[i]=forecast;
        }
        return Task.FromResult(arr);
        // return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        // {
        //     Date = startDate.AddDays(index),
        //     TemperatureC = Random.Shared.Next(-20, 55),
        //     Summary = Summaries[Random.Shared.Next(Summaries.Length)],
        //     switch (TemperatureC)
        //     {
                
        //         default:
        //     },
        // }).ToArray());
    }
}
