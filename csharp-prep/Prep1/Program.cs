using System;

namespace game

{
    class Program 
    {

    
        static void Main(string[] args)
        {
            Console.WriteLine("What's good? ");
            Console.WriteLine("The world of C# is goofy ");
            Console.Write("What is your color? ");
            string BRcolor = Console.ReadLine();


            Console.WriteLine($"Your color is {BRcolor}");
        }
    }
}