namespace PersonenVerwaltung.DataAccess.Models;

public partial class Anschrift
{
    public int AnschriftId { get; set; }

    public int PersonId { get; set; }

    public string Plz { get; set; } = null!;

    public string Ort { get; set; } = null!;

    public string Strasse { get; set; } = null!;

    public string Hausnummer { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
