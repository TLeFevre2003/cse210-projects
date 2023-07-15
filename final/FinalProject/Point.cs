namespace Tennis;

class Point
{
    private string _playerOne;
    private string _playerTwo;

    private string _winner;

    public Point(string winner)
    {
        _winner = winner;
    }
    public string GetWinner()
    {
        return _winner;
    }

}