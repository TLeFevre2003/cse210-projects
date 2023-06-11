using System;
namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            Breathing myBreathing = new Breathing();
            

            Reflection myReflection = new Reflection();
            

            Listing myListing = new Listing();
            
            string userInput="0";

            while (userInput != "4")
            {
                Console.Clear();
                Console.WriteLine("Menu options:");
                Console.WriteLine("  1. Start breathing activity");
                Console.WriteLine("  2. Start reflecting activity");
                Console.WriteLine("  3. Start listing activity");
                Console.WriteLine("  4. Quit");
                Console.Write("Select a choice from the menu: ");
                userInput = Console.ReadLine();
                Console.Clear();
                if (userInput == "1")
                {
                    myBreathing.BreathingActivity();
                }
                else if (userInput == "2")
                {
                    myReflection.ReflectionActivity();
                }
                else if (userInput == "3")
                {
                    myListing.ListingActivity();
                }

            }

        }
        
    }
}