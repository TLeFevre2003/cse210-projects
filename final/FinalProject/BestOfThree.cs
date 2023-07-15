namespace Tennis;

class BestOfThree : Match
{
    


    public BestOfThree(string playerOne,string playerTwo)
    {
        _playerOne = playerOne;
        _playerTwo = playerTwo;
        _sets.Add(new NormalSet());
    }
    public override void AddSet()
    {
        _sets.Add(new NormalSet());
    }
    public override void UpdateSet(string winner)
    {
        _sets[_sets.Count - 1].UpdateGame(winner, _playerOne, _playerTwo);
        int check = _sets[_sets.Count - 1].CheckScore();
        if (check == 1)
        {
            AddSet();
            if (winner == _playerOne)
            {
                _playerOneSets++;
            } 
            else if (winner == _playerTwo)
            {
                _playerTwoSets++;
            }
        }
    }
    
    public override string GetScore()
    {
        string score = _sets[_sets.Count - 1].GetScore();
        score+=$",{_playerOneSets},{_playerTwoSets}";
        return score;
    }



}