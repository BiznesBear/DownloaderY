using System.Text.RegularExpressions;

namespace DownloderY
{
    internal static class Methods
    {
        public static string RemoveSpecialCharacters(this string str)
        {
            // Definiujemy wyrażenie regularne, które zachowuje tylko litery i cyfry
            Regex regex = new Regex("[^a-zA-Z0-9]");
            // Zastępujemy wszystkie znaki specjalne pustym ciągiem
            return regex.Replace(str, "");
        }
    }
}
