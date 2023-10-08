//Libraries
using System;
using System.Net.Http;
using RestSharp;
using RestSharp.Authenticators;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Globalization;
//Class
public class Amiibo
{
    public static void AmiiboAPI()
    {
        // API URL
        string queryUrl = "";
        Console.WriteLine();
        Console.WriteLine("====================================");
        Console.WriteLine("Amiibo Database API:");
        Console.WriteLine();
        Console.WriteLine("1. UID");
        Console.WriteLine("2. Search fields");
        Console.WriteLine();
        Console.Write("How will you query the database?");
        
        string querymethod = "1";
        //string querymethod = Console.ReadLine();
        if (querymethod == "1")
        {
            string apiUrl = "https://www.amiiboapi.com/api/amiibo/";
            Console.WriteLine("UID: ");
            string UID = "03520902";  //Console.ReadLine();
            queryUrl = apiUrl + "?tail=" + UID;
        }
        else
        {
            Console.WriteLine("yeet");
        }

        try
        {
            //Initialise restsharp client, response and make request
            var client = new RestClient(queryUrl);
            var request = new RestRequest();
            RestResponse response = client.Get(request);
            if (response.IsSuccessful)
            {
                Console.WriteLine("Response successful:");
                Console.WriteLine(response.Content);
            }
            else
            {
                Console.WriteLine("Failed to fetch data. Status code: " + response.StatusCode);
            }
        }
        
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex}");
        }



        // Delay completion until user interaction
        Console.Write("Press any key to exit...");
        Console.ReadKey();
    }
}
