/// <summary>
/// Defines methods for validating chess piece movements in the Chess Maze game.
/// </summary>
public interface IMoveValidator
{
    /// <summary>
    /// Determines if a move from one position to another is valid for a given piece type.
    /// </summary>
    /// <param name="pieceType">The type of the chess piece.</param>
    /// <param name="from">The starting position of the move.</param>
    /// <param name="to">The destination position of the move.</param>
    /// <param name="board">The game board to check for obstacles or boundaries.</param>
    /// <returns>True if the move is valid according to the piece's movement rules, otherwise false.</returns>
    bool IsValidMove(PieceType pieceType, IPosition from, IPosition to, IBoard board);
}