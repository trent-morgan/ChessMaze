/// <summary>
/// Represents the status of a Chess Maze game session.
/// </summary>
public enum GameStatus
{
    /// <summary>
    /// The game is still in progress.
    /// </summary>
    Ongoing,

    /// <summary>
    /// The player has won by reaching the end position.
    /// </summary>
    Won,

    /// <summary>
    /// The player has lost, e.g., no valid moves remain.
    /// </summary>
    Lost
}