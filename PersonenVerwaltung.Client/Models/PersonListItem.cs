namespace PersonenVerwaltung.Client.Models
{
    public class PersonListItem
    {
        public int PersonId { get; set; }
        public string Name { get; set; } = null!;
        public string Vorname { get; set; } = null!;
        public DateOnly Geburtsdatum { get; set; }
    }
}