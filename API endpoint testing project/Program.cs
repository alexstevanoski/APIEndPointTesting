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
    public class MainC
    {
        // Method
        public static void Main()
        {
            //Header
            Console.Clear();    
            Console.WriteLine("Welcome. Make your selection:");
            Console.WriteLine("=============================");

            //Menu items
            Console.WriteLine("1. Chuck Norris Jokes API");
            Console.WriteLine("2. Italian Jokes API");
            Console.WriteLine("3. Coindesk BPI API");

            //Receive input
            Console.WriteLine();    
            Console.Write("Enter your selection: ");
            string menuIN = Console.ReadLine();

            //Menu logic
            if (menuIN == "1") {ChuckNorrisClass.ChuckNorrisAPI();}
            else if (menuIN == "2") {ItalianJokesClass.ItalianJokesAPI();}
            else if (menuIN == "3") {BPIClass.BPI();}
            else {Console.WriteLine("Invalid. Press any key to try again."); Console.ReadKey(); MainC.Main();}

            //Clear console on completion
            Console.Clear();
        }
    }
}