using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Uklon
{
    public class Solution4
    {
        private WebClient webClient = new WebClient();

        public Solution4() { }

        public Weather[] getWeather()
        {
            var json_Kyiv = webClient.DownloadString("https://goweather.herokuapp.com/weather/Kyiv");
            var json_Odesa = webClient.DownloadString("https://goweather.herokuapp.com/weather/Odesa");

            var parsedJson_Kyiv = JsonConvert.DeserializeObject<Weather>(json_Kyiv);
            var parsedJson_Odesa = JsonConvert.DeserializeObject<Weather>(json_Odesa);

            return new Weather[] {parsedJson_Kyiv, parsedJson_Odesa};
        }


        public static void TestTask4()
        {
            Solution4 a = new Solution4();

            Console.WriteLine("Curresnt temperature at Kyiv is " + a.getWeather()[0].Temperature);
            Console.WriteLine("Curresnt temperature at Odesa is " + a.getWeather()[1].Temperature);
        }
    }


    public partial class Weather
    {
        [JsonProperty("temperature")]
        public string Temperature { get; set; }

        [JsonProperty("wind")]
        public string Wind { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("forecast")]
        public Forecast[] Forecast { get; set; }
    }

    public partial class Forecast
    {
        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("temperature")]
        public string Temperature { get; set; }

        [JsonProperty("wind")]
        public string Wind { get; set; }
    }
}
