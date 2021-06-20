using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Patterns_and_Best_Practices_ProdC
{
    class Program
    {
        public static async Task Main()
        {
            using(var httpClient = new HttpClient() {BaseAddress = new Uri("https://api.github.com")})
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "EddyBautista-93");

                var response = await httpClient.GetAsync("/orgs/microsoft/repos");
                var content = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine((int) response.StatusCode);

                    var json = JsonConvert.DeserializeObject(content);
                    Console.WriteLine(json);
                }

            }
        }

        
    }
    
}
