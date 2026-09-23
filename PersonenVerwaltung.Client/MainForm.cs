using PersonenVerwaltung.Client.Configuration;
using PersonenVerwaltung.Client.Models;
using PersonenVerwaltung.Client.Services;

namespace PersonenVerwaltung.Client
{
    public partial class MainForm : Form
    {
        private readonly ToolTip _toolTip = new();
        private readonly ClientSettings _clientSettings = ClientSettingsLoader.Load();
        private readonly System.Windows.Forms.Timer _loadCooldownTimer = new();
        public MainForm()
        {
            InitializeComponent();

            _loadCooldownTimer.Interval = _clientSettings.LoadCooldownMs;
            _loadCooldownTimer.Tick += (s, e) =>
            {
                tstLaden.Enabled = true;
                _loadCooldownTimer.Stop();
            };

            _toolTip.SetToolTip(benutzerSuchenBox,
                    "Filter nach Nachname (oder Teil davon).\n" +
                    "Es werden alle Personen angezeigt, deren Nachname den eingegebenen Text enthält.");

            _toolTip.SetToolTip(tstLaden,
                    "Lädt die Personenliste vom Server.\n" +
                    "Suchfeld leer: alle Personen werden geladen.\n" +
                    "Suchfeld ausgefüllt: nur Personen, deren Nachname den eingegebenen Text enthält.\n" +
                    "Aus Sicherheitsgründen ist die Anzahl der geladenen Personen auf 10.000 max. begrenzt.");
        }

        private async void tstLaden_Click(object sender, EventArgs e)
        {
            tstLaden.Enabled = false;

            try
            {
                var persons = await PersonApiClient.GetPersonsAsync(benutzerSuchenBox.Text);
                dgvPersonen.DataSource = persons;

                neuPersonHinzuTst.Enabled = true;
                entfPersonTst.Enabled = true;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Fehler beim Laden der Daten: {ex.Message}",
                                "Fehler",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                neuPersonHinzuTst.Enabled = false;
                entfPersonTst.Enabled = false;
            }
            finally
            {
                _loadCooldownTimer.Start();
            }
        }

        private void dgvPersonen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvPersonen.Rows[e.RowIndex].DataBoundItem is not PersonListItem selectedPerson)
            {
                return;
            }

            using var detailForm = new PersonDetailenForm(selectedPerson.PersonId);
            detailForm.ShowDialog();
        }

        private void neuPersonHinzuTst_Click(object sender, EventArgs e)
        {
            using var addPersonWindow = new AddPersonWindow();

            if (addPersonWindow.ShowDialog() == DialogResult.OK)
            {
                tstLaden_Click(sender, e);
            }
        }

        private async void entfPersonTst_Click(object sender, EventArgs e)
        {
            if (dgvPersonen.CurrentRow?.DataBoundItem is not PersonListItem selectedPerson)
            {
                MessageBox.Show("Bitte zuerst eine Person in der Liste auswählen.", 
                                "Hinweis",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show($"Möchten Sie \"{selectedPerson.Vorname} {selectedPerson.Name}\" wirklich löschen?",
                                                "Löschen bestätigen",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            entfPersonTst.Enabled = false;
            try
            {
                await PersonApiClient.DeletePersonAsync(selectedPerson.PersonId);
                tstLaden_Click(sender, e);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Fehler beim Löschen: {ex.Message}", 
                                "Fehler",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                entfPersonTst.Enabled = true;
            }
        }
    }
}
