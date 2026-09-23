namespace PersonenVerwaltung.Client.Configuration
{
    public class ClientSettings
    {
        public string ApiBaseUrl { get; set; } = string.Empty;
        public int LoadCooldownMs { get; set; } = 1000;
    }
}