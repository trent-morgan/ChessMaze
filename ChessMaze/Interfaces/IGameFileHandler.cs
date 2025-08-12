/// <summary>
/// Provides functionality for handling file operations related to Chess Maze game sessions.
/// </summary>
public interface IGameFileHandler
{
    /// <summary>
    /// Saves a game to a specified file path.
    /// Throws IOException, UnauthorizedAccessException, etc. that must be caught by caller.
    /// </summary>
    /// <param name="game">The game to save.</param>
    /// <param name="filePath">The file path to save the game to.</param>    
    /// <param name="converter">The converter for compressing level data.</param>    
    void SaveGame(IGame game, string filePath, IConverter converter = null);

    /// <summary>
    /// Loads a game from a specified file path.
    /// Throws exceptions on failure
    /// </summary>
    /// <param name="filePath">The file path to load the game from.</param>    
    /// <param name="converter">The converter for expanding level data.</param>
    /// <returns>The loaded game.</returns>
    IGame LoadGame(string filePath, IConverter converter = null);
}