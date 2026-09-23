namespace PersonenVerwaltung.WebApi.DTOs
{
    public class AnschriftDto
    {
        public string Plz { get; set; } = null!;
        public string Ort { get; set; } = null!;
        public string Strasse { get; set; } = null!;
        public string Hausnummer { get; set; } = null!;
    }
}
