namespace DownloaderY;

internal static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
#pragma warning disable WFO5001 // Typ jest przeznaczony wy��cznie do cel�w ewaluacyjnych i mo�e zosta� zmieniony albo usuni�ty w przysz�ych aktualizacjach. Wstrzymaj t� diagnostyk�, aby kontynuowa�.
        Application.SetColorMode(SystemColorMode.System);
#pragma warning restore WFO5001 // Typ jest przeznaczony wy��cznie do cel�w ewaluacyjnych i mo�e zosta� zmieniony albo usuni�ty w przysz�ych aktualizacjach. Wstrzymaj t� diagnostyk�, aby kontynuowa�.
        Application.Run(new MainForm());
    }
}