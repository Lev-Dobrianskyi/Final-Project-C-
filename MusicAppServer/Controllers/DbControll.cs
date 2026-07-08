using MusicAppServer.Data;

namespace MusicAppServer.Controllers;

/// <summary>
/// Provides methods for controlling the database, such as resetting it.
/// </summary>
public class DbControll
{

    /// <summary>
    /// Resets the database by deleting it and recreating it. This method ensures that the database is in a clean state.
    /// </summary>
    public static void ResetDb()
    {
        using (var context = new AppDBContext())
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
