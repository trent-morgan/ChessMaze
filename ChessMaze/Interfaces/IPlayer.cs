/// <summary>
/// Represents a player in the Chess Maze game.
/// </summary>
public interface IPlayer
{
    /// <summary>
    /// Gets the current position of the player on the board.
    /// The position is updated internally by the game logic.
    /// </summary>
    IPosition CurrentPosition { get; }

    /// <summary>
    /// Resets the player's position to the starting point of the level.
    /// </summary>
    /// <param name="startPosition">The starting position defined by the level.</param>
    void ResetPosition(IPosition startPosition);

    /// <summary>
    /// Updates the player's position.
    /// Should be called only by game logic after validating a move.
    /// </summary>
    /// <param name="newPosition">The new position to set.</param>
    void SetPosition(IPosition newPosition);
}
