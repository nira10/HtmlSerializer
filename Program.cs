using System;
using System.Threading.Tasks;

namespace HtmlProcessor
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HtmlSerializer loader = new HtmlSerializer();
            string url = "https://www.example.com";

            string htmlContent = await loader.Load(url);

            Console.WriteLine(htmlContent);
        }

    }
}

