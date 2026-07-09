using TestStyle;

namespace Music_App.Main;

public class Realisation
{

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    public static void EnterProgram()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        //Application.Run(new MainMenuForm());
        Application.Run(new MainMenuForm());
    }
}