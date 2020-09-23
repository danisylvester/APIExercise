using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json.Linq;

namespace APIExercise
{
    class CandidateResponse
    {
        static HttpClient client = new HttpClient();
        public QuoteGenerator quote = new QuoteGenerator(client);

        public void CandidatesRespond(string question)
        {
            Console.WriteLine(question);
            Console.WriteLine();
            Console.WriteLine($"Kanye: \"{quote.GetKanyeQuote()}\"");
            Console.WriteLine($"Ron Swanson: {quote.GetRonSwansonQuote()}");
            Console.WriteLine();
        }

    }
}
