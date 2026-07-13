// keep the username, email and password for the user's session for easy access by forms
namespace Music_App
{
    public static class UserSession
    {
        public static string Username { get; set; }
        public static string Email { get; set; }
        public static string Password { get; set; }
    }
}