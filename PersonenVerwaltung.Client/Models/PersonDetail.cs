namespace PersonenVerwaltung.Client.Models
{
    public class PersonDetail
    {
        public int PersonId { get; set; }
        public string Name { get; set; } = null!;
        public string Vorname { get; set; } = null!;
        public DateOnly Geburtsdatum { get; set; }
        public List<AnschriftInfo> Anschriften { get; set; } = [];
        public List<string> Telefonnummern { get; set; } = [];
    }
}