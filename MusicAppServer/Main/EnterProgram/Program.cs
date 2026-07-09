namespace MusicAppServer.Main.EnterProgram;

/// <summary>
/// Defines the entry point of the server application, initializing the TCP listener loop.
/// </summary>
/// <param name="args">Command-line arguments.</param>
static class Program
{
    /// <summary>
    /// Defines the entry point of the server application, initializing the TCP listener loop.
    /// </summary>
    /// <param name="args">Command-line arguments.</param>
    static async Task Main(string[] args)
    {
        await Realisation.EnterProgram();
    }
}
