using System;
using System.IO;

namespace Tutorials.JsonInteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to my application!");
            JsonService.ReadJsonFile(AskForJsonFileName());
        }

        public static string AskForJsonFileName()
        {
            BEGIN:
            Console.Write("\nWhat is the name of your JSON file? ");
            var response = Console.ReadLine();
            if (File.Exists(response))
            {
                return response;
            }
            else
            {
                Console.Write("\nError: File doesn't exist!");
                goto BEGIN;
            }
        }

    }
}
