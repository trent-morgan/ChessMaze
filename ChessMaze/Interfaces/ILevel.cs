/// <summary>
/// Represents a level in the Chess Maze game.
/// </summary>
public interface ILevel
{
    /// <summary>
    /// Gets the name of the level.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the level.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Gets the game board for this level.
    /// </summary>
    IBoard Board { get; }

    /// <summary>
    /// Sets or gets the start position for this level.
    /// </summary>
    IPosition StartPosition { get; set; }

    /// <summary>
    /// Sets or gets the end position for this level.
    /// </summary>
    IPosition EndPosition { get; set; }

    /// <summary>
    /// Gets the player for this level.
    /// </summary>
    IPlayer Player { get; }

    /// <summary>
    /// Determines if the level is completed.
    /// </summary>
    bool IsCompleted { get; }

    /// <summary>
    /// Checks if the player has reached the end position.
    /// </summary>
    /// <param name="playerPosition">The current position of the player.</param>
    /// <returns>True if the player has reached the end position, false otherwise.</returns>
    bool CheckCompletion(IPosition playerPosition);

    /// <summary>
    /// Resets the level to its initial state.
    /// </summary>
    void Reset();
}