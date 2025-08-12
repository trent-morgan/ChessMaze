/// <summary>
/// Provides functionality for compressing and expanding level data.
/// Designed as a stateless converter with pure methods.
/// </summary>
public interface IConverter
{
    /// <summary>
    /// Compresses the provided uncompressed level data.
    /// </summary>
    /// <param name="uncompressedLevel">The uncompressed level data.</param>
    /// <param name="validator">The validator to validate the level data before compression.</param>
    /// <returns>The compressed representation of the level data.</returns>
    string Compress(string uncompressedLevel, ICompressionValidator validator);

    /// <summary>
    /// Expands the provided compressed level data.
    /// </summary>
    /// <param name="compressedLevel">The compressed level data.</param>
    /// <param name="validator">The validator to validate the level data before expansion.</param>
    /// <returns>The expanded (uncompressed) representation of the level data.</returns>
    string Expand(string compressedLevel, ICompressionValidator validator);
}