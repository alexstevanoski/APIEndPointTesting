using System;
using System.Net.Http;
using RestSharp;
using RestSharp.Authenticators;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace APITesting;

public class MainClass
{
    public static void Main()
    {
        string url = "https://matchilling-chuck-norris-jokes-v1.p.rapidapi.com/jokes/random";
        
        var client = new RestClient(url);
        var request = new RestRequest();
        request.AddHeader("X-RapidAPI-Key", "95420226abmshc17434483ca7701p1afebajsn23899967f720");
        request.AddHeader("X-RapidAPI-Host", "matchilling-chuck-norris-jokes-v1.p.rapidapi.com");

        var response = client.Get(request);

        Console.WriteLine(response.Content);
        Console.Read();
    }
}
