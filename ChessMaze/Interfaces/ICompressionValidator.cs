/// <summary>
/// Provides validation methods for level data before compression or expansion operations.
/// </summary>
public interface ICompressionValidator
{
    /// <summary>
    /// Validates the input data before performing expansion (decompression).
    /// </summary>
    /// <param name="input">The compressed data to validate.</param>
    /// <param name="errorMessage">The error message if validation fails.</param>
    /// <returns>
    /// True if the input data is valid and safe to expand; otherwise, false.
    /// </returns>
    bool ValidateBeforeExpansion(string input, out string errorMessage);

    /// <summary>
    /// Validates the input data before performing compression.
    /// </summary>
    /// <param name="input">The uncompressed data to validate.</param>
    /// <param name="errorMessage">The error message if validation fails.</param>
    /// <returns>
    /// True if the input data is valid and safe to compress; otherwise, false.
    /// </returns>
    bool ValidateBeforeCompression(string input, out string errorMessage);
}