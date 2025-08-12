/// <summary>
/// Represents an immutable position on the chess board with row and column coordinates.
/// </summary>
public interface IPosition
{
    /// <summary>
    /// Gets the row number of the position.
    /// </summary>
    int Row { get; }

    /// <summary>
    /// Gets the column number of the position.
    /// </summary>
    int Column { get; }

    /// <summary>
    /// Determines if two positions are equal.
    /// </summary>
    /// <param name="other">The other position to compare.</param>
    /// <returns>True if the positions are equal, otherwise false.</returns>
    bool Equals(IPosition other);

    /// <summary>
    /// Checks if the position is valid based on the maximum number of rows and columns.
    /// </summary>
    /// <param name="maxRows">The maximum number of rows.</param>
    /// <param name="maxColumns">The maximum number of columns.</param>
    /// <returns>True if the position is valid, otherwise false.</returns>
    bool IsValid(int maxRows, int maxColumns);
}