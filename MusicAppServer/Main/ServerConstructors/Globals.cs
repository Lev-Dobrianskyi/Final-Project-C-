namespace MusicAppServer.Main.ServerConstructors;

/// <summary>
/// Contains global string constants used for server logging and signaling.
/// </summary>
public static class Globals
{
    /// <summary>
    /// Message logged when a song has been fully transmitted to the client.
    /// </summary>
    public const string MsgSongSent = "Song has been sent.";

    /// <summary>
    /// Message logged when the TCP server starts successfully.
    /// </summary>
    public const string MsgServerStarted = "Server has been started.";

    /// <summary>
    /// Message logged when a client request is approved.
    /// </summary>
    public const string MsgApproveClientRequest = "Approve";

    /// <summary>
    /// Message logged when a client request is rejected.
    /// </summary>
    public const string MsgRejectClientRequest = "Approve";
}
