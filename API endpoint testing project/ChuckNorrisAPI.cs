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
    public class ChuckNorrisClass
    {
        //Method
        public static void ChuckNorrisAPI()
        {
            //URL to access
            string url = "https://matchilling-chuck-norris-jokes-v1.p.rapidapi.com/jokes/random";
            
            //Initialisation of client
            var client = new RestClient(url);
            var request = new RestRequest();

            //API Keys
            request.AddHeader("X-RapidAPI-Key", "95420226abmshc17434483ca7701p1afebajsn23899967f720");
            request.AddHeader("X-RapidAPI-Host", "matchilling-chuck-norris-jokes-v1.p.rapidapi.com");

            //Execute and output request
            var response = client.Get(request);
            Console.WriteLine(response.Content);
        }
    }
}