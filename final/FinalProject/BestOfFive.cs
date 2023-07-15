namespace Tennis;

class BestOfFive : Match
{
    public BestOfFive(string playerOne,string playerTwo) : base(5,3)
    {
        _playerOne = playerOne;
        _playerTwo = playerTwo;
        _sets.Add(new NormalSet());
    }
}