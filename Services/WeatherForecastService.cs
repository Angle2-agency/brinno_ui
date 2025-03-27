namespace MyBlazorServerApp.Services
{
    public class WeatherForecastService
    {
        public Task<WeatherForecast[]> GetDataAsync()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 6).Select(index => new WeatherForecast
            {
                Area = rng.Next(0, 100),
            }).ToArray());
        }
    }
}