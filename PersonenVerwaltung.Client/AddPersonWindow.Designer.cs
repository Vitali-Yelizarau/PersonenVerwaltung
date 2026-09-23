namespace PersonenVerwaltung.Client
{
    partial class AddPersonWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            vornameTextBox = new TextBox();
            nameLabel = new Label();
            vornameLabel = new Label();
            geburtsDTLabel = new Label();
            addressLabel = new Label();
            telefonLabel = new Label();
            nameTextBox = new TextBox();
            geburtsDTPicker = new DateTimePicker();
            telefonnmrBox = new TextBox();
            anschriftBearbeitenTst = new Button();
            erstellenTst = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(vornameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(nameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(vornameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(geburtsDTLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(addressLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(telefonLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(nameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(geburtsDTPicker, 1, 2);
            tableLayoutPanel1.Controls.Add(telefonnmrBox, 1, 4);
            tableLayoutPanel1.Controls.Add(anschriftBearbeitenTst, 1, 3);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(454, 251);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // vornameTextBox
            // 
            vornameTextBox.Location = new Point(230, 53);
            vornameTextBox.Name = "vornameTextBox";
            vornameTextBox.Size = new Size(221, 31);
            vornameTextBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(3, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(63, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // vornameLabel
            // 
            vornameLabel.AutoSize = true;
            vornameLabel.Location = new Point(3, 50);
            vornameLabel.Name = "vornameLabel";
            vornameLabel.Size = new Size(87, 25);
            vornameLabel.TabIndex = 1;
            vornameLabel.Text = "Vorname:";
            // 
            // geburtsDTLabel
            // 
            geburtsDTLabel.AutoSize = true;
            geburtsDTLabel.Location = new Point(3, 100);
            geburtsDTLabel.Name = "geburtsDTLabel";
            geburtsDTLabel.Size = new Size(130, 25);
            geburtsDTLabel.TabIndex = 2;
            geburtsDTLabel.Text = "Geburtsdatum:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(3, 150);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(204, 25);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Adressen: 0 hinzugefügt";
            addressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new Point(3, 200);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new Size(159, 25);
            telefonLabel.TabIndex = 4;
            telefonLabel.Text = "Telefonnummer(n):";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(230, 3);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(221, 31);
            nameTextBox.TabIndex = 5;
            // 
            // geburtsDTPicker
            // 
            geburtsDTPicker.Location = new Point(230, 103);
            geburtsDTPicker.Name = "geburtsDTPicker";
            geburtsDTPicker.Size = new Size(221, 31);
            geburtsDTPicker.TabIndex = 10;
            // 
            // telefonnmrBox
            // 
            telefonnmrBox.Location = new Point(230, 203);
            telefonnmrBox.Name = "telefonnmrBox";
            telefonnmrBox.Size = new Size(221, 31);
            telefonnmrBox.TabIndex = 11;
            // 
            // anschriftBearbeitenTst
            // 
            anschriftBearbeitenTst.Location = new Point(230, 153);
            anschriftBearbeitenTst.Name = "anschriftBearbeitenTst";
            anschriftBearbeitenTst.Size = new Size(221, 34);
            anschriftBearbeitenTst.TabIndex = 12;
            anschriftBearbeitenTst.Text = "Adressen bearbeiten…";
            anschriftBearbeitenTst.UseVisualStyleBackColor = true;
            anschriftBearbeitenTst.Click += anschriftBearbeitenTst_Click;
            // 
            // erstellenTst
            // 
            erstellenTst.Location = new Point(15, 269);
            erstellenTst.Name = "erstellenTst";
            erstellenTst.Size = new Size(451, 37);
            erstellenTst.TabIndex = 13;
            erstellenTst.Text = "Person erstellen";
            erstellenTst.UseVisualStyleBackColor = true;
            erstellenTst.Click += erstellenTst_Click;
            // 
            // AddPersonWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 318);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(erstellenTst);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddPersonWindow";
            Text = "Neue Person hinzufuegen";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox vornameTextBox;
        private Label nameLabel;
        private Label vornameLabel;
        private Label geburtsDTLabel;
        private Label addressLabel;
        private Label telefonLabel;
        private TextBox nameTextBox;
        private DateTimePicker geburtsDTPicker;
        private TextBox telefonnmrBox;
        private Button anschriftBearbeitenTst;
        private Button erstellenTst;
    }
}