/// <summary>
/// Represents a game session in the Chess Maze game.
/// </summary>
public interface IGame
{
    /// <summary>
    /// Gets the current level being played.
    /// </summary>
    ILevel CurrentLevel { get; }

    /// <summary>
    /// Loads a specified level into the game.
    /// </summary>
    /// <param name="level">The level to load.</param>
    void LoadLevel(ILevel level);

    /// <summary>
    /// Starts the game session by initializing the game state and resetting the level.
    /// </summary>
    void StartGame();

    /// <summary>
    /// Attempts to move the player to a new position.
    /// Handles legality checks, move counting, and win/loss condition updates.
    /// Move() must call ILevel.CheckCompletion() and update Status accordingly.    
    /// </summary>
    /// <param name="newPosition">The target position.</param>
    /// <returns>True if the move is valid and successful; otherwise, false.</returns>
    bool Move(IPosition newPosition);

    /// <summary>
    /// Gets the current status of the game (e.g., Ongoing, Won, Lost).
    /// </summary>
    GameStatus Status { get; }

    /// <summary>
    /// Gets the number of valid moves made in the current game session.
    /// </summary>
    /// <returns>The number of successful moves made by the player.</returns>
    int GetMoveCount();

    /// <summary>
    /// Resets the current level and player state to the initial configuration.
    /// </summary>
    void ResetLevel();
}
