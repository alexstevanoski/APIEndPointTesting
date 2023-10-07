using System;
using RestSharp;
using Newtonsoft.Json;
class BPIClass
{
    public static void BPI()
    {
        try
        {
            // Define the API endpoint URL
            string apiUrl = "https://api.coindesk.com/v1/bpi/currentprice.json";

            // Initialise RestSharp client, response, and make request
            var client = new RestClient(apiUrl);
            var request = new RestRequest();
            RestResponse response = client.Get(request);

            // Check if the request was successful (status code 200 OK)
            if (response.IsSuccessful)
            {
                // Deserialize the JSON response into objects
                CoinDeskResponse coinDeskResponse = JsonConvert.DeserializeObject<CoinDeskResponse>(response.Content);

                // Header
                Console.Clear();
                Console.WriteLine(coinDeskResponse.Disclaimer);
                Console.WriteLine();
                Console.WriteLine("====================================");
                Console.WriteLine("BPI Information:");

                //USD
                Console.WriteLine();
                Console.WriteLine(">  USD:");
                Console.WriteLine("   " + coinDeskResponse.Bpi.USD.Rate_float + " " + coinDeskResponse.Bpi.USD.Description + "s");

                //GBP
                Console.WriteLine();
                Console.WriteLine(">  GBP:");
                Console.WriteLine("   " + coinDeskResponse.Bpi.GBP.Rate_float + " " + coinDeskResponse.Bpi.GBP.Description + "s");

                //EUR
                Console.WriteLine();
                Console.WriteLine(">  EUR:");
                Console.WriteLine("   " + coinDeskResponse.Bpi.EUR.Rate_float + " " + coinDeskResponse.Bpi.EUR.Description + "s");
                
                // Delay completion until user interaction
                Console.Write("Press any key to exit...");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine($"Failed to fetch data. Status code: {response.StatusCode}");
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

// Define classes to match the JSON structure
public class TimeInfo
{
    public string Updated { get; set; }
}

public class CurrencyInfo
{
    public string Code { get; set; }
    public string Description { get; set; }
    public float Rate_float { get; set; }
}

public class Bpi
{
    public CurrencyInfo USD { get; set; }
    public CurrencyInfo GBP { get; set; }
    public CurrencyInfo EUR { get; set; }
}

public class CoinDeskResponse
{
    public TimeInfo Time { get; set; }
    public Bpi Bpi { get; set; }
    public string Disclaimer { get; set; }
}
