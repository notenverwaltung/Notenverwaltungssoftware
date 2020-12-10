namespace Data
{
    using Plugin.Settings;
    using Plugin.Settings.Abstractions;

    /// <summary>
    /// Konstanten für die Datenbank-Abwicklung.
    /// </summary>
    public static class DatabaseSettings
    {
        public static object Database { get; internal set; }

        public static object Password { get; internal set; }

        public static object Server { get; internal set; }

        public static object User { get; internal set; }
    }
}