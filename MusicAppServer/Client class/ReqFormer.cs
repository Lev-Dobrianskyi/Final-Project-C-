namespace Music_App.Client_class;

/// <summary>
/// Represents the Data Transfer Object (DTO) containing user registration details sent from the client to the server.
/// </summary>
public class SignupRequestModel
{
    /// <summary>
    /// Gets or sets the action identifier used by the server to route the request. Defaults to <c>"signup"</c>.
    /// </summary>
    public string Action { get; set; } = "signup";

    /// <summary>
    /// Gets or sets the display name or username chosen by the registering user.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the unique email address provided for the new user account.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the raw password chosen by the user for account authentication.
    /// </summary>
    public string Password { get; set; }
}

/// <summary>
/// Represents the Data Transfer Object (DTO) containing details for requesting an audio track stream from the server.
/// </summary>
public class ListenRequestModel
{
    /// <summary>
    /// Gets or sets the action identifier used by the server to route the playback request. Defaults to <c>"listenSong"</c>.
    /// </summary>
    public string Action { get; set; } = "listenSong";

    /// <summary>
    /// Gets or sets the name or identifier of the song that the client wants to stream.
    /// </summary>
    public string SongName { get; set; }
}