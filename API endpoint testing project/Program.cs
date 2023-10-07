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

            //Receive input
            Console.WriteLine();    
            Console.Write("Enter your selection: ");
            int menuIN = Convert.ToInt32(Console.ReadLine());

            //Menu logic
            if (menuIN == 1) {ChuckNorrisClass.ChuckNorrisAPI();}
            else {MainC.Main();}
        }
    }
}