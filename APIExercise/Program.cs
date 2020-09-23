using System;
using System.Net.Http;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace APIExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Questions
            string qOne = "Q1: How will you prevent pharmaceutical companies from driving up the costs of life-saving drugs?";
            string qTwo = "Q2: What are you going to do about climate change?";
            string qThree = "Q3: How will you address homelessness?";

            //Greeting
            Console.WriteLine("WELCOME TO THE 2020 PRESIDENTIAL CONVENTION.");
            Console.WriteLine("Today our Republican candidate Kanye West will be debating the staunch Libertarian Ron Swanson.");
            Console.WriteLine();
            Thread.Sleep(200);

            //Candidate responses 
            var respond = new CandidateResponse();
            respond.CandidatesRespond(qOne);
            respond.CandidatesRespond(qTwo);
            respond.CandidatesRespond(qThree);

            string qFour = respond.GetQuestion();
            respond.CandidatesRespond(qFour);

        }
    }
}
