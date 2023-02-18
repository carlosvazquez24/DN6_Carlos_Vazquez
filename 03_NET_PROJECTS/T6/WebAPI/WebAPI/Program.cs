using Api.Entities;
using System.Net;
using System.Text;
using WebAPI;

class Program
{
    static void Main(string[] args)
    {

        //getIp();
        System.Threading.Thread.Sleep(5000);

        var forecast =  GetWeatherForecastAsync(new Zone
        {
            City = "Chetumal",
            Date = new DateTime(2001,10,24)
        }).Result;

        Console.WriteLine("City" + forecast.Zone.City);
        Console.WriteLine( "Date" + forecast.Zone.Date);

        foreach (var item in forecast.WeatherForecast)
        {
            Console.WriteLine("");
            Console.WriteLine("Temperature in degrees Celsius: " + item.TemperatureC);
            Console.WriteLine("Temperature in degrees Farenheit" + item.TemperatureF);
            Console.WriteLine("Temperature" + item.Summary);
            Console.WriteLine("Date: " + item.Date);
        }

        Console.ReadKey();
    }

    private static async Task<IpAddress> getIp()
    {
        HttpClient client = new HttpClient();

        //Método para consumir la api
        HttpResponseMessage response = await client.GetAsync("https://api.ipify.org/?format=json");
        //Se registra si la petición fue exitosa
        response.EnsureSuccessStatusCode();

        //Serializa el contenido del body del htpp a un string
        string responseBody = await response.Content.ReadAsStringAsync();

        IpAddress ip =  Newtonsoft.Json.JsonConvert.DeserializeObject<IpAddress>(responseBody);

        var info = await getIPInfo(ip.Ip);
        Console.WriteLine("Country: " + info.Country);
        Console.WriteLine("City: " + info.City);
        Console.WriteLine("TimeZone: " + info.TimeZone);


        return ip;
    }


    private static async Task<IpInfo> getIPInfo(string idParam)
    {
        HttpClient client = new HttpClient();

        //Método para consumir la api
        HttpResponseMessage response = await client.GetAsync($"https://ipinfo.io/{idParam}/geo");
        //Se registra si la petición fue exitosa
        response.EnsureSuccessStatusCode();

        //Serializa el contenido del body del htpp a un string
        string responseBody = await response.Content.ReadAsStringAsync();

        IpInfo info = Newtonsoft.Json.JsonConvert.DeserializeObject<IpInfo>(responseBody);
        return info;
    }

    private static async Task<ZoneWeather> GetWeatherForecastAsync(Zone zone)
    {
        HttpClient client = new HttpClient();
        string contenido = Newtonsoft.Json.JsonConvert.SerializeObject(zone);
        HttpResponseMessage response = await client.PostAsync("https://localhost:7041/weatherforecast/byZone", new StringContent(contenido, Encoding.UTF8, "application/json"));
        response.EnsureSuccessStatusCode();
        //Serializa el contenido del body del htpp a un string
        string responseBody = await response.Content.ReadAsStringAsync();

        ZoneWeather newZone = Newtonsoft.Json.JsonConvert.DeserializeObject<ZoneWeather>(responseBody);
        return newZone;
    }

}