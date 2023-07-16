namespace Tennis;

class TieBreak : Game
{

   public TieBreak() : base()
    {

    }
    public override string GetScore()
    {
        return $"{_playerOneScore}-{_playerTwoScore}";
    }
    public override bool CheckScore()
    {
        if (_playerOneScore >= 7 & (_playerOneScore-_playerTwoScore)>=2)
        {
            return true;
        }
        else if (_playerTwoScore >= 7 & (_playerTwoScore-_playerOneScore)>=2)
        {
            return true;
        }
        return false;
    }


}