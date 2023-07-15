using System.Collections.Generic;
namespace Tennis;

class NormalGame : Game
{
    string _scoreOne;
    string _scoreTwo;
    public NormalGame() : base()
    {
        _winScore = 4;
    }
    public override string GetScore()
    {
        Dictionary<int, string> tennisScores = new Dictionary<int, string>()
        {
            { 0, "0" },
            { 1, "15" },
            { 2, "30" },
            { 3, "40"},
            { 4, "adv"}
        };
        if (_playerOneScore<4 || _playerTwoScore<4)
        {
            _scoreOne = tennisScores[_playerOneScore];
            _scoreTwo = tennisScores[_playerTwoScore]; 
        }
        else
        {
            if (_playerOneScore > _playerTwoScore)
            {
                _scoreOne = "adv";
                _scoreTwo = "40";
            }
            else if (_playerOneScore < _playerTwoScore)
            {
                _scoreTwo = "adv";
                _scoreOne = "40";
            }
            else if (_playerOneScore == _playerTwoScore)
            {
                _scoreOne = "40";
                _scoreTwo = "40";
            }
        }
        return $"{_scoreOne},{_scoreTwo}";
    }
    public override bool CheckScore()
    {
        if (_playerOneScore >= 4 & (_playerOneScore-_playerTwoScore)>=2)
        {
            return true;
        }
        else if (_playerTwoScore >= 4 & (_playerTwoScore-_playerOneScore)>=2)
        {
            return true;
        }
        return false;
    }
}