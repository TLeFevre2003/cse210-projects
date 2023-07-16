using System;
using System.Collections.Generic;
namespace Tennis;

abstract class Match
{
    private string _matchWinner;
    protected string _playerOne;
    protected string _playerTwo;
    private string _winner;
    protected List<Set> _sets = new List<Set>();
    protected int _playerOneSets;
    protected int _playerTwoSets;
    private int _totalSets;
    private int _minSets;
    public Match(int sets,int min)
    {
        _totalSets = sets;
        _minSets = min;
        _matchWinner = "0";
    }
    public void AddSet()
    {
        _sets.Add(new NormalSet());
    }

    public bool UpdateSet(string winner)
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
            if ((_totalSets == _playerOneSets+_playerTwoSets) || ((Math.Abs(_playerOneSets-_playerTwoSets)>=2 ) & ((_playerOneSets>=_minSets) || (_playerTwoSets>=_minSets))))
            {
                _matchWinner = winner;
                return true;
            }
        }
        return false;
    }
    public  string GetScore()
    {
        string score = _sets[_sets.Count - 1].GetScore();
        score+=$",{_playerOneSets},{_playerTwoSets}";
        return score;
    }
    public string GetWinner()
    {
        return _matchWinner;
    }
}