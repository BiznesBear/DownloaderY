using System.Text.RegularExpressions;

namespace DownloderY;

internal static class Extensions
{
    public static string RemoveSpecialCharacters(this string str)
    {
        Regex regex = new Regex("[^a-zA-Z0-9]");
        return regex.Replace(str, "");
    }
}
