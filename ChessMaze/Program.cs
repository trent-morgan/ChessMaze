namespace ChessMaze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new ChessMazeController(new Game(new MoveValidator())).Go();
        }
    }
}
