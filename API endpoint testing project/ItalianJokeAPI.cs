//Libraries
using System;
using System.Net.Http;
using RestSharp;
using RestSharp.Authenticators;
using System.Threading.Tasks;
using System.Net.Http.Headers;

//Namespace
namespace APITesting
{
    //Class
    public class ItalianJokesClass
    {
        //Method
        public static void ItalianJokesAPI()
        {
            //URL to access
            string url = "https://italian-jokes.vercel.app/api/jokes";

            //Initalisation of client
            var client = new RestClient(url);
            var request = new RestRequest();

            // Header
            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine("Italian Joke API:");
            Console.WriteLine();

            try
            {
                RestResponse response = client.Get(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    JokeResponse jokeResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<JokeResponse>(response.Content);
                    
                    //Print Joke
                    Console.WriteLine(">   Joke: " + jokeResponse.Joke);

                    Console.WriteLine();
                    Console.WriteLine("====================================");
                    Console.WriteLine();

                    //Print other info
                    Console.WriteLine(">   Id:        " + jokeResponse.Id);
                    Console.WriteLine(">   Type:      " + jokeResponse.Type);
                    Console.WriteLine(">   Subtype:   " + jokeResponse.Subtype);
                }

                else
                {
                    Console.WriteLine("Error: " + response.ErrorMessage);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine();
            
            // Delay completion until user interaction
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }

    public class JokeResponse
    {
        public string Joke { get; set;}
        public string Id { get; set;}
        public string Type { get; set;}
        public string Subtype { get; set;}

    }
}