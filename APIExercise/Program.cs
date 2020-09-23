using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var qGenerator = new QuoteGenerator(client);


            for(int i = 0; i < 5; i++)
            {
                var kanyeQuote = qGenerator.GetKanyeQuote();
                Console.WriteLine($"Kanye: '{kanyeQuote}'");
                Console.WriteLine();

                var ronQuote = qGenerator.GetRonSwansonQuote();
                Console.WriteLine($"Ron Swanson: '{ronQuote}'");
                Console.WriteLine("....................................................");
            }
        }
    }
}
