using System;

namespace dogsay_main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What do you want the dog to say?");
            string textInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"   __\r\no-''|\\_____/)\r\n \\_/|_)     )\r\n    \\  __  /\r\n    (_/ (_/    {textInput}\r\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===============\rPress any key to exit...");
            Console.ReadKey();
        }
    }
}