/// <summary>
/// Represents a chess board with a grid of cells containing pieces.
/// </summary>
public interface IBoard
{
    /// <summary>
    /// Gets the number of rows on the board.
    /// </summary>
    int Rows { get; }

    /// <summary>
    /// Gets the number of columns on the board.
    /// </summary>
    int Columns { get; }

    /// <summary>
    /// Sets a piece at the specified position on the board.
    /// </summary>
    /// <param name="piece">The piece to place.</param>
    /// <param name="position">The target position.</param>
    void SetPiece(IPiece piece, IPosition position);

    /// <summary>
    /// Gets the piece at a specific position on the board.
    /// </summary>
    /// <param name="position">The position to check.</param>
    /// <returns>The piece at the specified position. Returns null if the position is empty.</returns>
    IPiece GetPieceAt(IPosition position);

    /// <summary>
    /// Moves a piece from one position to another, if the move is legal.
    /// </summary>
    /// <param name="from">The starting position of the piece.</param>
    /// <param name="to">The destination position of the piece.</param>
    /// <returns>True if the move was successful; otherwise, false.</returns>
    bool TryMovePiece(IPosition from, IPosition to);

    /// <summary>
    /// Determines if a position is valid on the board.
    /// </summary>
    /// <param name="position">The position to check.</param>
    /// <returns>True if the position is valid, otherwise false.</returns>
    bool IsValidPosition(IPosition position);

    /// <summary>
    /// Determines if a move from one position to another is legal.
    /// </summary>
    /// <param name="from">The starting position of the move.</param>
    /// <param name="to">The destination position of the move.</param>
    /// <param name="validator">The move validator to check piece-specific movement rules.</param>
    /// <returns>True if the move is legal, otherwise false.</returns>
    bool IsMoveLegal(IPosition from, IPosition to, IMoveValidator validator);

    /// <summary>
    /// Resets the board to its initial state.
    /// </summary>
    void ResetBoard();
}