namespace PersonenVerwaltung.Client.Models
{
    public class CreatePersonRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Vorname { get; set; } = string.Empty;
        public DateOnly Geburtsdatum { get; set; }
        public List<AnschriftInfo> Anschriften { get; set; } = new();
        public List<string> Telefonnummern { get; set; } = new();
    }
}
