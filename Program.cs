using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace Patterns_and_Best_Practices_ProdC
{
    class Program
    {
        public static async Task Main()
        {
            using(var httpClient = new HttpClient() {BaseAddress = new Uri("https://api.github.com")})
            {
                
               var response = await httpClient.GetAsync("ors/microsoft/repos");
               var content = await response.Content.ReadAsStringAsync();
               Console.WriteLine(content);

            }
        }

        
    }
    
}
