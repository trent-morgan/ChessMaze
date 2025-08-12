/// <summary>
/// Provides functionality for handling file operations related to Chess Maze levels.
/// </summary>
public interface ILevelFileHandler
{
    /// <summary>
    /// Saves a level to a specified file path.
    /// Throws exceptions on failure, e.g., IOException for file I/O errors, 
    /// ArgumentException for invalid arguments, Other specific exceptions as applicable.
    /// </summary>
    /// <param name="level">The level to save.</param>
    /// <param name="filePath">The file path to save the level to.</param>    
    /// <param name="converter">The converter for compressing level data.</param>    
    void SaveLevel(ILevel level, string filePath, IConverter converter = null);

    /// <summary>
    /// Loads a level from a specified file path.
    /// Throws exceptions on failure.
    /// </summary>
    /// <param name="filePath">The file path to load the level from.</param>    
    /// <param name="converter">The converter for expanding level data.</param>
    /// <returns>The loaded level.</returns>
    ILevel LoadLevel(string filePath, IConverter converter = null);
}