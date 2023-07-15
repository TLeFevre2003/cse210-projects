using System;
namespace Tennis;
class Program
{
    static void Main(string[] args)
    {
        InputOutput IO = new InputOutput();
        IO.NamePlayers();
        IO.CreateMatch();
        bool running = false;
        while (running == false)
        {
            IO.DisplayScore();
            running = IO.EnterScore();




        }
        IO.DisplayWinner();
        
    }
}