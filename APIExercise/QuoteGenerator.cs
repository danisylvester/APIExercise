using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIExercise
{
    public class QuoteGenerator
    {
        public QuoteGenerator(HttpClient client)
        {
            _client = client;
        }
        
        public HttpClient _client = new HttpClient();
        string kanyeURL = "https://api.kanye.rest";
        string ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
        string trumpURL = "https://api.whatdoestrumpthink.com/api/v1/quotes/random";


        public string GetKanyeQuote()
        {
            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;
            return JObject.Parse(kanyeResponse).GetValue("quote").ToString();
        }

        public string GetRonSwansonQuote()
        {
            var ronResponse = _client.GetStringAsync(ronSwansonURL).Result;
            return JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
        }

        public string GetTrumpResponse()
        {
            var trumpResponse = _client.GetStringAsync(trumpURL).Result;
            return JObject.Parse(trumpResponse).GetValue("message").ToString();
        }
    }
}
