namespace PersonenVerwaltung.Client
{
    partial class AnschriftenPopup
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
            anschriftDataGrid = new DataGridView();
            strasseSplt = new DataGridViewTextBoxColumn();
            hausnumSplt = new DataGridViewTextBoxColumn();
            plzSplt = new DataGridViewTextBoxColumn();
            ortSplt = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            okTst = new Button();
            abbrechenTst = new Button();
            ((System.ComponentModel.ISupportInitialize)anschriftDataGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // anschriftDataGrid
            // 
            anschriftDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            anschriftDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            anschriftDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            anschriftDataGrid.Columns.AddRange(new DataGridViewColumn[] { strasseSplt, hausnumSplt, plzSplt, ortSplt });
            anschriftDataGrid.Location = new Point(0, 0);
            anschriftDataGrid.Name = "anschriftDataGrid";
            anschriftDataGrid.RowHeadersWidth = 62;
            anschriftDataGrid.Size = new Size(881, 254);
            anschriftDataGrid.TabIndex = 0;
            // 
            // strasseSplt
            // 
            strasseSplt.HeaderText = "Strasse";
            strasseSplt.MinimumWidth = 8;
            strasseSplt.Name = "strasseSplt";
            // 
            // hausnumSplt
            // 
            hausnumSplt.HeaderText = "Hausnummer";
            hausnumSplt.MinimumWidth = 8;
            hausnumSplt.Name = "hausnumSplt";
            // 
            // plzSplt
            // 
            plzSplt.HeaderText = "Postleitzahl";
            plzSplt.MinimumWidth = 8;
            plzSplt.Name = "plzSplt";
            // 
            // ortSplt
            // 
            ortSplt.HeaderText = "Ort/Stadt";
            ortSplt.MinimumWidth = 8;
            ortSplt.Name = "ortSplt";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(okTst, 1, 0);
            tableLayoutPanel1.Controls.Add(abbrechenTst, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 253);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(881, 42);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // okTst
            // 
            okTst.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            okTst.Location = new Point(443, 3);
            okTst.Name = "okTst";
            okTst.Size = new Size(435, 36);
            okTst.TabIndex = 1;
            okTst.Text = "Ok";
            okTst.UseVisualStyleBackColor = true;
            okTst.Click += okTst_Click;
            // 
            // abbrechenTst
            // 
            abbrechenTst.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            abbrechenTst.Location = new Point(3, 3);
            abbrechenTst.Name = "abbrechenTst";
            abbrechenTst.Size = new Size(434, 36);
            abbrechenTst.TabIndex = 0;
            abbrechenTst.Text = "Abbrechen";
            abbrechenTst.UseVisualStyleBackColor = true;
            abbrechenTst.Click += abbrechenTst_Click;
            // 
            // AnschriftenPopup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 297);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(anschriftDataGrid);
            MinimumSize = new Size(700, 300);
            Name = "AnschriftenPopup";
            Text = "Anschriften";
            ((System.ComponentModel.ISupportInitialize)anschriftDataGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView anschriftDataGrid;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn strasseSplt;
        private DataGridViewTextBoxColumn hausnumSplt;
        private DataGridViewTextBoxColumn plzSplt;
        private DataGridViewTextBoxColumn ortSplt;
        private Button okTst;
        private Button abbrechenTst;
    }
}