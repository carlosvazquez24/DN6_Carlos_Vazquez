namespace Api.Entities
{
    public class ZoneWeather
    {

        public Zone Zone { get; set; }

        public IEnumerable<WeatherForecast> WeatherForecast { get; set; }

    }
}
