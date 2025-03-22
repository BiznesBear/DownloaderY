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
#pragma warning disable WFO5001 // Typ jest przeznaczony wy³¹cznie do celów ewaluacyjnych i mo¿e zostaæ zmieniony albo usuniêty w przysz³ych aktualizacjach. Wstrzymaj tê diagnostykê, aby kontynuowaæ.
        Application.SetColorMode(SystemColorMode.System);
#pragma warning restore WFO5001 // Typ jest przeznaczony wy³¹cznie do celów ewaluacyjnych i mo¿e zostaæ zmieniony albo usuniêty w przysz³ych aktualizacjach. Wstrzymaj tê diagnostykê, aby kontynuowaæ.
        Application.Run(new MainForm());
    }
}