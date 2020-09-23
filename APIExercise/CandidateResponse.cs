using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace APIExercise
{
    class CandidateResponse
    {
        static HttpClient client = new HttpClient();
        public QuoteGenerator quote = new QuoteGenerator(client);

        public string GetQuestion()
        {
            Console.WriteLine("What question would you like to ask the 2020 presidential candidates?");
            return Console.ReadLine();
        }

        public void CandidatesRespond(string question)
        {
            Console.WriteLine();
            Console.WriteLine($"Question: {question}");
            Thread.Sleep(200);
            Console.WriteLine();
            Console.WriteLine($"Kanye: \"{quote.GetKanyeQuote()}\"");
            Thread.Sleep(200);
            Console.WriteLine($"Ron Swanson: {quote.GetRonSwansonQuote()}");
            Thread.Sleep(200);
            Console.WriteLine($"Trump: {quote.GetTrumpResponse()}");
            Thread.Sleep(200);
            Console.WriteLine();
        }

    }
}
