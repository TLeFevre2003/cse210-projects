using System.Collections.Generic;
namespace Tennis;
abstract class Game
{
    private List<Point> _points = new List<Point>();
    protected int _playerOneScore;
    protected int _playerTwoScore;

    protected int _winScore;
    public Game()
    {
        _playerOneScore = 0;
        _playerTwoScore = 0;
    }
    public void AddPoint(string playerOne, string playerTwo, string winner)
    {
        _points.Add(new Point(winner));
        if (winner == playerOne)
        {
            _playerOneScore++;
        }
        else if (winner == playerTwo)
        {
            _playerTwoScore++;
        }
    }
    public abstract string GetScore();
    public abstract bool CheckScore();
}