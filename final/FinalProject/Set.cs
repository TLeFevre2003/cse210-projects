namespace Tennis;

abstract class Set
{
    protected string _setWinner;
    protected List<Game> _games = new List<Game>();

    protected int _playerOneScore;
    protected int _playerTwoScore;


    public abstract void AddGame();
    public abstract void UpdateGame(string winner,string playerOne,string playerTwo);

    public abstract string GetScore();

    public abstract int CheckScore();
}