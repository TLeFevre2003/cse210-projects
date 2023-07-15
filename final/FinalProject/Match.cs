namespace Tennis;

abstract class Match
{
    protected string _playerOne;
    protected string _playerTwo;
    private string _winner;
    protected List<Set> _sets = new List<Set>();
    protected int _playerOneSets;
    protected int _playerTwoSets;

    abstract public void AddSet();

    abstract public void UpdateSet(string winner);

    abstract public string GetScore();



}