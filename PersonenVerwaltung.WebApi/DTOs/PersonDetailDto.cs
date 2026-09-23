namespace PersonenVerwaltung.WebApi.DTOs
{
    public class PersonDetailDto
    {
        public int PersonId { get; set; }
        public string Name { get; set; } = null!;
        public string Vorname { get; set; } = null!;
        public DateOnly Geburtsdatum { get; set; }
        public List<AnschriftDto> Anschriften { get; set; } = [];
        public List<string> Telefonnummern { get; set; } = [];
    }
}
