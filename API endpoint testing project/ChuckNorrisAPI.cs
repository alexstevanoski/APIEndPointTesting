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
            // Header
            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine("Chuck Norris API:");
            Console.WriteLine();

            //URL to access
            string url = "https://matchilling-chuck-norris-jokes-v1.p.rapidapi.com/jokes/random";
            
            //Initialisation of client
            var client = new RestClient(url);
            var request = new RestRequest();

            //API Keys
            request.AddHeader("X-RapidAPI-Key", "95420226abmshc17434483ca7701p1afebajsn23899967f720");
            request.AddHeader("X-RapidAPI-Host", "matchilling-chuck-norris-jokes-v1.p.rapidapi.com");

            try
            {
                RestResponse response = client.Get(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    ValueResponse valueresponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ValueResponse>(response.Content);

                    // Print value
                    Console.WriteLine(">   Value: " + valueresponse.Value);
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

    public class ValueResponse
    {
        public string Value { get; set;}
    }
}