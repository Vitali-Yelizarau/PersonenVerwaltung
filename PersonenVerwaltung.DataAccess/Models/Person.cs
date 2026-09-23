namespace PersonenVerwaltung.DataAccess.Models;

public partial class Person
{
    public int PersonId { get; set; }

    public string Name { get; set; } = null!;

    public string Vorname { get; set; } = null!;

    public DateOnly Geburtsdatum { get; set; }

    public virtual ICollection<Anschrift> Anschrifts { get; set; } = new List<Anschrift>();

    public virtual ICollection<Telefonverbindung> Telefonverbindungs { get; set; } = new List<Telefonverbindung>();
}
