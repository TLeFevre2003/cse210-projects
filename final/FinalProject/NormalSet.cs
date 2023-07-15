namespace Tennis;

class NormalSet : Set
{
    private bool _isTie;
    private int _p1Score;
    private int _p2Score;
    private int _currentGame;
    public NormalSet()
    {
        _p1Score = 0;
        _p2Score = 0;
        _isTie = false;
        AddGame();
    }
    public override void AddGame()
    {
        _games.Add(new NormalGame());


    }
    public override void UpdateGame(string winner,string playerOne,string playerTwo)
    {
        _currentGame = _games.Count - 1;
        _games[_currentGame].AddPoint(playerOne, playerTwo, winner);
        if (_games[_currentGame].CheckScore())
        {
            AddGame();
            if (winner == playerOne)
            {
                _p1Score++;
            }
            else if (winner == playerTwo)
            {
                _p2Score++;
            }
            _currentGame = _games.Count - 1;
        }
    }
    public override string GetScore()
    {

        string score = _games[_currentGame].GetScore();
        score += $",{_p1Score},{_p2Score}";
        return score;



    }
    public override int CheckScore()
    {
        if ((_p1Score >= 6 & _p1Score-_p2Score>=2) || _p1Score==7)
        {
            return 1;
        }
        else if ((_p2Score >= 6 & _p2Score-_p1Score>=2) || _p2Score ==7)
        {
            return 1;
        }
        else if (_p1Score ==6 & _p2Score ==6)
        {
            if (_isTie == false)
            {
                _games.Add(new TieBreak());
                _isTie = true;
            }
            
            return 0;
        }
        return 0;
    }

}