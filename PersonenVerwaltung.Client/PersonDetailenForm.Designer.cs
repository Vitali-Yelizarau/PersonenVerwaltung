namespace PersonenVerwaltung.Client
{
    partial class PersonDetailenForm
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
            geburtsDTTextBox = new TextBox();
            vornameTextBox = new TextBox();
            nameLabel = new Label();
            vornameLabel = new Label();
            geburtsDTLabel = new Label();
            addressLabel = new Label();
            telefonLabel = new Label();
            nameTextBox = new TextBox();
            anschriftenBox = new ComboBox();
            telefonnummernBox = new ComboBox();
            speichernTst = new Button();
            kopierenTst = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(geburtsDTTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(vornameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(nameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(vornameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(geburtsDTLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(addressLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(telefonLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(nameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(anschriftenBox, 1, 3);
            tableLayoutPanel1.Controls.Add(telefonnummernBox, 1, 4);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(431, 251);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // geburtsDTTextBox
            // 
            geburtsDTTextBox.Location = new Point(218, 103);
            geburtsDTTextBox.Name = "geburtsDTTextBox";
            geburtsDTTextBox.ReadOnly = true;
            geburtsDTTextBox.Size = new Size(202, 31);
            geburtsDTTextBox.TabIndex = 7;
            // 
            // vornameTextBox
            // 
            vornameTextBox.Location = new Point(218, 53);
            vornameTextBox.Name = "vornameTextBox";
            vornameTextBox.ReadOnly = true;
            vornameTextBox.Size = new Size(202, 31);
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
            addressLabel.Size = new Size(99, 25);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Adresse(n):";
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
            nameTextBox.Location = new Point(218, 3);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(202, 31);
            nameTextBox.TabIndex = 5;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // anschriftenBox
            // 
            anschriftenBox.DropDownStyle = ComboBoxStyle.DropDownList;
            anschriftenBox.FormattingEnabled = true;
            anschriftenBox.Location = new Point(218, 153);
            anschriftenBox.Name = "anschriftenBox";
            anschriftenBox.Size = new Size(202, 33);
            anschriftenBox.TabIndex = 8;
            // 
            // telefonnummernBox
            // 
            telefonnummernBox.DropDownStyle = ComboBoxStyle.DropDownList;
            telefonnummernBox.FormattingEnabled = true;
            telefonnummernBox.Location = new Point(218, 203);
            telefonnummernBox.Name = "telefonnummernBox";
            telefonnummernBox.Size = new Size(202, 33);
            telefonnummernBox.TabIndex = 9;
            // 
            // speichernTst
            // 
            speichernTst.Enabled = false;
            speichernTst.Location = new Point(308, 344);
            speichernTst.Name = "speichernTst";
            speichernTst.Size = new Size(112, 34);
            speichernTst.TabIndex = 5;
            speichernTst.Text = "Speichern";
            speichernTst.UseVisualStyleBackColor = true;
            speichernTst.Click += speichernTst_Click;
            // 
            // kopierenTst
            // 
            kopierenTst.Location = new Point(12, 344);
            kopierenTst.Name = "kopierenTst";
            kopierenTst.Size = new Size(290, 34);
            kopierenTst.TabIndex = 10;
            kopierenTst.Text = "In Zwischenablage kopieren";
            kopierenTst.UseVisualStyleBackColor = true;
            kopierenTst.Click += kopierenTst_Click;
            // 
            // PersonDetailenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 390);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(speichernTst);
            Controls.Add(kopierenTst);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PersonDetailenForm";
            Text = "Person Detailen";
            Load += PersonDetailenForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label nameLabel;
        private Label vornameLabel;
        private Label geburtsDTLabel;
        private Label addressLabel;
        private Label telefonLabel;
        private Button speichernTst;
        private TextBox geburtsDTTextBox;
        private TextBox vornameTextBox;
        private TextBox nameTextBox;
        private ComboBox anschriftenBox;
        private ComboBox telefonnummernBox;
        private Button kopierenTst;
    }
}