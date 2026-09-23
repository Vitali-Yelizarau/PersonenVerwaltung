using PersonenVerwaltung.Client.Services;
using System.Text;

namespace PersonenVerwaltung.Client
{
    public partial class PersonDetailenForm : Form
    {
        private readonly int _personId;
        private string _originalName = string.Empty;
        public PersonDetailenForm(int personId)
        {
            InitializeComponent();
            _personId = personId;
        }

        private int GetMaxItemWidth(ComboBox comboBox)
        {
            int maxWidth = comboBox.Width;
            using var g = comboBox.CreateGraphics();
            foreach (var item in comboBox.Items)
            {
                var size = g.MeasureString(item.ToString(), comboBox.Font);
                maxWidth = Math.Max(maxWidth, (int)size.Width + 20);
            }
            return maxWidth;
        }

        private async void PersonDetailenForm_Load(object sender, EventArgs e)
        {
            try
            {
                var person = await PersonApiClient.GetPersonByIdAsync(_personId);

                if (person is null)
                {
                    MessageBox.Show("Person wurde nicht gefunden.",
                                    "Fehler",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    Close();
                    return;
                }

                nameTextBox.Text = _originalName = person.Name;
                vornameTextBox.Text = person.Vorname;
                geburtsDTTextBox.Text = person.Geburtsdatum.ToString("dd.MM.yyyy");

                anschriftenBox.Items.Clear();
                foreach (var anschrift in person.Anschriften)
                {
                    anschriftenBox.Items.Add($"Strasse: {anschrift.Strasse} {anschrift.Hausnummer}, " +
                                             $"PLZ: {anschrift.Plz} " +
                                             $"Stadt/Ort: {anschrift.Ort}");
                }
                if (anschriftenBox.Items.Count > 0)
                {
                    anschriftenBox.SelectedIndex = 0;
                }
                anschriftenBox.DropDownWidth = GetMaxItemWidth(anschriftenBox);


                telefonnummernBox.Items.Clear();
                telefonnummernBox.Items.AddRange([.. person.Telefonnummern]);
                if (telefonnummernBox.Items.Count > 0)
                {
                    telefonnummernBox.SelectedIndex = 0;
                }
                telefonnummernBox.DropDownWidth = GetMaxItemWidth(telefonnummernBox);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Fehler beim Laden der Daten: {ex.Message}",
                                "Fehler",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private async void speichernTst_Click(object sender, EventArgs e)
        {
            try
            {
                await PersonApiClient.UpdatePersonNameAsync(_personId, nameTextBox.Text);
                _originalName = nameTextBox.Text;
                speichernTst.Enabled = false;

                MessageBox.Show("Name wurde erfolgreich aktualisiert.",
                                "Erfolg",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Fehler beim Speichern: {ex.Message}",
                                "Fehler",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            speichernTst.Enabled = nameTextBox.Text != _originalName;
        }

        private void kopierenTst_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Name: {nameTextBox.Text}");
            sb.AppendLine($"Vorname: {vornameTextBox.Text}");
            sb.AppendLine($"Geburtsdatum: {geburtsDTTextBox.Text}");

            var adressen = new List<string>();
            foreach (var item in anschriftenBox.Items)
            {
                adressen.Add(item.ToString() ?? string.Empty);
            }
            sb.AppendLine($"Adresse(n): {string.Join(", ", adressen)}");

            var telefonnummern = new List<string>();
            foreach (var item in telefonnummernBox.Items)
            {
                telefonnummern.Add(item.ToString() ?? string.Empty);
            }
            sb.AppendLine($"Telefonnummer(n): {string.Join(", ", telefonnummern)}");

            Clipboard.SetText(sb.ToString());
        }
    }
}
