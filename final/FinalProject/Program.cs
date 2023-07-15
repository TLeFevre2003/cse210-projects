using System;
namespace Tennis;
class Program
{
    static void Main(string[] args)
    {
        string playerOne = "tyler";
        string playerTwo = "james";
        BestOfThree match = new BestOfThree(playerOne,playerTwo);

        bool playing = true;
        string answer;
        while (playing)
        {
            Console.Clear();
            Console.WriteLine(match.GetScore());
            Console.WriteLine("Press 1 for player 1, 2 for player 2, 3 to quit");

            answer = Console.ReadLine();

            if (answer == "1")
            {
                match.UpdateSet(playerOne);
            }
            else if (answer == "2")
            {
                match.UpdateSet(playerTwo);
            }
            else if (answer == "3")
            {
                playing = false;
            }


        }
    }
}