using System.Text.Json;

namespace PersonenVerwaltung.Client.Configuration
{
    public static class ClientSettingsLoader
    {
        private const string FileName = "appsettings.json";

        private static readonly JsonSerializerOptions _jsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public static ClientSettings Load()
        {
            var path = Path.Combine(AppContext.BaseDirectory, FileName);

            if (!File.Exists(path))
            {
                return new ClientSettings();
            }

            try
            {
                var json = File.ReadAllText(path);
                var settings = JsonSerializer.Deserialize<ClientSettings>(json, _jsonOptions);

                return settings ?? new ClientSettings();
            }
            catch (JsonException)
            {
                return new ClientSettings();
            }
        }
    }
}