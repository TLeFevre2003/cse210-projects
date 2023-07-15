using System;
namespace Tennis;

class InputOutput
{
    private bool _over;
    private Match _match;
    private string _playerOne;
    private string _playerTwo;
    public InputOutput()
    {
        _playerOne="temp";
        _playerTwo="temp";
        _over = false;
    }


    public void CreateMatch()
    {
        bool creatingMatch = true;
        while (creatingMatch)
        {
            Console.Clear();
            Console.WriteLine("What type of match? ");
            Console.WriteLine("  1. Best of 3");
            Console.WriteLine("  2. Best of 5");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                _match = new BestOfThree(_playerOne,_playerTwo);
                creatingMatch = false;
            }
            else if (answer == "2")
            {
                _match = new BestOfFive(_playerOne,_playerTwo);
                creatingMatch = false;
            }
        }
        
    }
    public void NamePlayers()
    {
        Console.Clear();
        Console.WriteLine("What is your name? ");
        string answer = Console.ReadLine();
        _playerOne = answer;
        Console.WriteLine("What is your opponent's name? ");
        answer = Console.ReadLine();
        _playerTwo = answer;
    }


    public void DisplayScore()
    {
        string[] data = _match.GetScore().Split(',');
        string goalType = data[0];
        Console.Clear();
        Console.WriteLine($"1. {_playerOne} {data[4]} {data[2]} {data[0]}");
        Console.WriteLine($"2. {_playerTwo} {data[5]} {data[3]} {data[1]}");
    }
    public bool EnterScore()
    {
        Console.WriteLine("Press 1 for player 1, 2 for player 2, 3 to quit");

        string answer = Console.ReadLine();

        if (answer == "1")
        {
            _over = _match.UpdateSet(_playerOne);
            
        }
        else if (answer == "2")
        {
            _over = _match.UpdateSet(_playerTwo);
            
        }
        else if (answer == "3")
        {
           return true;
        }
        return _over;
    }
    public void DisplayWinner()
    {
        DisplayScore();
        string winner = _match.GetWinner();
        if (winner == "0")
        {
            Console.WriteLine("No winner");
        }
        else 
        {
            Console.WriteLine($"{winner} Won!!!!!");
        }

    }

}