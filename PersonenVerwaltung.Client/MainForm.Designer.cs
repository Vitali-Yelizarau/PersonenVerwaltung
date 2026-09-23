namespace PersonenVerwaltung.Client
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tstLaden = new Button();
            dgvPersonen = new DataGridView();
            benutzerSuchenBox = new TextBox();
            neuPersonHinzuTst = new Button();
            entfPersonTst = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonen).BeginInit();
            SuspendLayout();
            // 
            // tstLaden
            // 
            resources.ApplyResources(tstLaden, "tstLaden");
            tstLaden.Name = "tstLaden";
            tstLaden.UseVisualStyleBackColor = true;
            tstLaden.Click += tstLaden_Click;
            // 
            // dgvPersonen
            // 
            dgvPersonen.AllowUserToAddRows = false;
            dgvPersonen.AllowUserToDeleteRows = false;
            dgvPersonen.AllowUserToResizeColumns = false;
            dgvPersonen.AllowUserToResizeRows = false;
            dgvPersonen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonen.BackgroundColor = SystemColors.Control;
            dgvPersonen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonen.GridColor = SystemColors.InactiveCaptionText;
            resources.ApplyResources(dgvPersonen, "dgvPersonen");
            dgvPersonen.Name = "dgvPersonen";
            dgvPersonen.ReadOnly = true;
            dgvPersonen.CellDoubleClick += dgvPersonen_CellDoubleClick;
            // 
            // benutzerSuchenBox
            // 
            resources.ApplyResources(benutzerSuchenBox, "benutzerSuchenBox");
            benutzerSuchenBox.Name = "benutzerSuchenBox";
            // 
            // neuPersonHinzuTst
            // 
            resources.ApplyResources(neuPersonHinzuTst, "neuPersonHinzuTst");
            neuPersonHinzuTst.Name = "neuPersonHinzuTst";
            neuPersonHinzuTst.UseVisualStyleBackColor = true;
            neuPersonHinzuTst.Click += neuPersonHinzuTst_Click;
            // 
            // entfPersonTst
            // 
            resources.ApplyResources(entfPersonTst, "entfPersonTst");
            entfPersonTst.Name = "entfPersonTst";
            entfPersonTst.UseVisualStyleBackColor = true;
            entfPersonTst.Click += entfPersonTst_Click;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(entfPersonTst);
            Controls.Add(neuPersonHinzuTst);
            Controls.Add(benutzerSuchenBox);
            Controls.Add(dgvPersonen);
            Controls.Add(tstLaden);
            Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvPersonen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tstLaden;
        private DataGridView dgvPersonen;
        private TextBox benutzerSuchenBox;
        private Button neuPersonHinzuTst;
        private Button entfPersonTst;
    }
}
