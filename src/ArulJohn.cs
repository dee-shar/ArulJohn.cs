using System.Net.Http;

namespace ArulJohnApi
{
    public class ArulJohn
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://api.aruljohn.com";
        public ArulJohn()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetIp()
        {
          return await (await httpClient.GetAsync($"{apiUrl}/ip/json")).Content.ReadAsStringAsync();
        }
    }
}
