/// <summary>
/// Represents a chess piece with a specific type.
/// </summary>
public interface IPiece
{
    /// <summary>
    /// Gets the type of the chess piece.
    /// </summary>
    PieceType Type { get; }	

    /// <summary>
    /// Gets a value indicating whether the chess piece is white.
    /// </summary>
    bool IsWhite { get; }
}