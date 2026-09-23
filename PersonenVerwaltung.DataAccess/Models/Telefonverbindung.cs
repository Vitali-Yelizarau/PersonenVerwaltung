namespace PersonenVerwaltung.DataAccess.Models;

public partial class Telefonverbindung
{
    public int TelefonNummerRecordId { get; set; }

    public int PersonId { get; set; }

    public string Nummer { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
