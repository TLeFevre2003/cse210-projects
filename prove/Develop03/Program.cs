using System;
namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
            bool active = true;
            
            Console.Clear();
            scripture.DisplayScripture();

            while (active)
            {

                string input = Console.ReadLine();

                if (input == "quit")
                {
                    active = false;
                }
                else if (input == "help")
                {
                    scripture.MakeVisible();
                }
                else
                {
                    active = scripture.MakeInvisible();
                    active = scripture.MakeInvisible();
                    
                }
                Console.Clear();
                scripture.DisplayScripture();


            }
        }
    }
}