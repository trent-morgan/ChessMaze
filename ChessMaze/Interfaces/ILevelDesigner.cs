/// <summary>
/// Provides functionality for designing and editing levels in the Chess Maze game.
/// </summary>
public interface ILevelDesigner
{
    /// <summary>
    /// Gets the current level being designed.
    /// </summary>
    ILevel CurrentLevel { get; }

    /// <summary>
    /// Creates a new level with the specified number of rows and columns.
    /// This method initializes the level and sets the board size.
    /// </summary>
    /// <param name="rows">The number of rows in the new level.</param>
    /// <param name="columns">The number of columns in the new level.</param>
    /// <returns>The newly created level.</returns>
    ILevel CreateLevel(int rows, int columns);

    /// <summary>
    /// Places a piece at the specified position on the board.
    /// Throws an exception if the position is invalid or already occupied.
    /// </summary>
    /// <param name="piece">The piece to place.</param>
    /// <param name="position">The position to place the piece at.</param>
    void PlacePiece(IPiece piece, IPosition position);

    /// <summary>
    /// Undoes the last action performed on the board.
    /// Returns true if an action was undone, false otherwise.
    /// </summary>
    /// <returns>True if an action was undone, false otherwise.</returns>
    bool UndoLastAction();

    /// <summary>
    /// Removes a piece from the specified position on the board.
    /// Throws an exception if the position is invalid or already empty.
    /// </summary>
    /// <param name="position">The position to remove the piece from.</param>
    /// <exception cref="ArgumentException">Thrown if the position is invalid or already empty.</exception>
    void RemovePiece(IPosition position);

    /// <summary>
    /// Sets the start position for the current level.
    /// Throws an exception if the position is invalid or does not meet game constraints.
    /// </summary>
    /// <param name="position">The start position.</param>
    void SetStartPosition(IPosition position);

    /// <summary>
    /// Sets the end position for the current level.
    /// Throws an exception if the position is invalid or does not meet game constraints.</summary>
    /// <param name="position">The end position.</param>
    void SetEndPosition(IPosition position);

    /// <summary>
    /// Validates the current level and returns whether it is valid.
    /// </summary>
    /// <param name="errorMessage">The error message if the level is invalid.</param>
    /// <returns>True if the level is valid, false otherwise.</returns>
    bool ValidateLevel(out string errorMessage);
}
