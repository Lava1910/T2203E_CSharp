using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using T2203E_CSharp.Session5;

namespace T2203E_CSharp.Exercise.API
{
    internal class CallWeatherAPI
    {
        public async Task<WeatherData> FetchData()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
            HttpClient client = new HttpClient();
            var rs = await client.GetAsync(url);

            if (rs.StatusCode == HttpStatusCode.OK) // Http Status Code?
            {
                string responseText = await rs.Content.ReadAsStringAsync();
                WeatherData p = JsonConvert.DeserializeObject<WeatherData>(responseText); // serial - deserial
                return p;
            }

            return null;
        }
    }
}
