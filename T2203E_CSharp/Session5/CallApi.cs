using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Text.Json.Nodes;
using Newtonsoft.Json;

namespace T2203E_CSharp.Session5
{
    public class CallApi
    {
        public async Task<Product> FetchData()
        {
            string url = "https://dummyjson.com/products/1";
            HttpClient client= new HttpClient();
            var rs = await client.GetAsync(url);
            
            if(rs.StatusCode == HttpStatusCode.OK) // Http Status Code?
            {
                string responseText = await rs.Content.ReadAsStringAsync();
                Product p = JsonConvert.DeserializeObject<Product>(responseText); // serial - deserial
                return p;
            }

            return null;
        }
    }
}
