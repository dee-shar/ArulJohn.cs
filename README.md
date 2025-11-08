# ArulJohn.cs
Web-API for [aruljohn.com](https://aruljohn.com) A collection of online tools and articles. Utilities to find your IP Address, track an email or phone number

## Example
```cs
using ArulJohnApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new ArulJohn();
            string ip = await api.GetIp();
            Console.WriteLine(ip);
        }
    }
}
```
