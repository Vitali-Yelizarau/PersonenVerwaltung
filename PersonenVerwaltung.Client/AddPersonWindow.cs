using PersonenVerwaltung.Client.Models;
using PersonenVerwaltung.Client.Services;

namespace PersonenVerwaltung.Client
{
    public partial class AddPersonWindow : Form
    {
        private List<AnschriftInfo> _anschriften = new();
        public AddPersonWindow()
        {
            InitializeComponent();
        }

        private void anschriftBearbeitenTst_Click(object sender, EventArgs e)
        {
            using var popup = new AnschriftenPopup(_anschriften);

            if (popup.ShowDialog() == DialogResult.OK)
            {
                _anschriften = popup.Anschriften;
                addressLabel.Text = $"Adressen: {_anschriften.Count} hinzugefügt";
            }
        }

        private async void erstellenTst_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(vornameTextBox.Text))
            {
                MessageBox.Show("Bitte Name und Vorname ausfüllen.",
                                "Fehler",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (_anschriften.Count == 0)
            {
                MessageBox.Show("Bitte mindestens eine Adresse hinzufügen.",
                                "Fehler",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var telefonnummern = telefonnmrBox.Text
                                              .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                                              .ToList();

            if (telefonnummern.Count == 0)
            {
                MessageBox.Show("Bitte mindestens eine Telefonnummer angeben.",
                                "Fehler",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var request = new CreatePersonRequest
            {
                Name = nameTextBox.Text,
                Vorname = vornameTextBox.Text,
                Geburtsdatum = DateOnly.FromDateTime(geburtsDTPicker.Value),
                Anschriften = _anschriften,
                Telefonnummern = telefonnummern
            };

            erstellenTst.Enabled = false;
            try
            {
                await PersonApiClient.CreatePersonAsync(request);
                MessageBox.Show("Person wurde erfolgreich erstellt.",
                                "Erfolg",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Fehler beim Erstellen der Person: {ex.Message}",
                                "Fehler",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                erstellenTst.Enabled = true;
            }
        }
    }
}
