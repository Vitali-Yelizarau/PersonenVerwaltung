using PersonenVerwaltung.Client.Models;

namespace PersonenVerwaltung.Client
{
    public partial class AnschriftenPopup : Form
    {
        public List<AnschriftInfo> Anschriften { get; private set; } = [];
        public AnschriftenPopup(List<AnschriftInfo> currentAnschriften)
        {
            InitializeComponent();

            // Grid mit den bereits vorhandenen Adressen vorbefuellen
            foreach (var anschrift in currentAnschriften)
            {
                anschriftDataGrid.Rows.Add(anschrift.Strasse, anschrift.Hausnummer, anschrift.Plz, anschrift.Ort);
            }
        }

        private void okTst_Click(object sender, EventArgs e)
        {
            var anschriften = new List<AnschriftInfo>();

            foreach (DataGridViewRow row in anschriftDataGrid.Rows)
            {
                if (row.IsNewRow) { continue; }

                var strasse = row.Cells[0].Value?.ToString() ?? string.Empty;
                var hausnummer = row.Cells[1].Value?.ToString() ?? string.Empty;
                var plz = row.Cells[2].Value?.ToString() ?? string.Empty;
                var ort = row.Cells[3].Value?.ToString() ?? string.Empty;

                // Komplett leere Zeilen ueberspringen (z. B. angefangen, aber nicht ausgefuellt)
                if (string.IsNullOrWhiteSpace(strasse) && string.IsNullOrWhiteSpace(hausnummer) &&
                    string.IsNullOrWhiteSpace(plz) && string.IsNullOrWhiteSpace(ort))
                {
                    continue;
                }

                anschriften.Add(new AnschriftInfo
                {
                    Strasse = strasse,
                    Hausnummer = hausnummer,
                    Plz = plz,
                    Ort = ort
                });
            }

            Anschriften = anschriften;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void abbrechenTst_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
