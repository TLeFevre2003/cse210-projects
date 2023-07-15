namespace Tennis;

class BestOfThree : Match
{
    public BestOfThree(string playerOne,string playerTwo) : base(3,2)
    {
        _playerOne = playerOne;
        _playerTwo = playerTwo;
        _sets.Add(new NormalSet());
    }
}