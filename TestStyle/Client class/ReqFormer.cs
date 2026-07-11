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

/// <summary>
/// Represents the Data Transfer Object (DTO) containing details for sending a message from the client to the server.
/// </summary>
public class MessageRequestModel
{
    /// <summary>
    /// Gets or sets the action identifier used by the server to route the message request. Defaults to <c>"sendMessage"</c>.
    /// </summary>
    public string Action { get; set; } = "sendMessage";
    /// <summary>
    /// Gets or sets the content of the message that the client wants to send.
    /// </summary>
    public string MessageContent { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether the message was sent successfully.
    /// </summary>
    public bool IsSuccess { get; set; } = true;
}

/// <summary>
/// Represents the Data Transfer Object (DTO) containing user login details sent from the client to the server.
/// </summary>
public class LoginRequestModel
{
    /// <summary>
    /// Gets or sets the action identifier used by the server to route the login request. Defaults to <c>"login"</c>.
    /// </summary>
    public string Action { get; set; } = "login";
    /// <summary>
    /// Gets or sets the unique email address provided for user authentication.
    /// </summary>
    public string Email { get; set; }
    /// <summary>
    /// Gets or sets the raw password provided by the user for authentication.
    /// </summary>
    public string Password { get; set; }
}

public class LoginResponseModel
{
    public string Action { get; set; } = "loginResponse";
    public string MessageContent { get; set; }
    public string Name { get; set; }
}