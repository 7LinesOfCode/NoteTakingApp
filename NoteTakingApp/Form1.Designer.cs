namespace NoteTakingApp
{
    partial class NoteTakeApp
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.TittleBox = new System.Windows.Forms.TextBox();
            this.NoteBox = new System.Windows.Forms.TextBox();
            this.previousNote = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.NewNoteBox = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previousNote)).BeginInit();
            this.SuspendLayout();
            // 
            // TittleBox
            // 
            this.TittleBox.Location = new System.Drawing.Point(467, 38);
            this.TittleBox.Name = "TittleBox";
            this.TittleBox.Size = new System.Drawing.Size(316, 20);
            this.TittleBox.TabIndex = 0;
            this.TittleBox.TextChanged += new System.EventHandler(this.TittleBox_TextChanged);
            // 
            // NoteBox
            // 
            this.NoteBox.Location = new System.Drawing.Point(467, 86);
            this.NoteBox.Multiline = true;
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(316, 352);
            this.NoteBox.TabIndex = 1;
            this.NoteBox.TextChanged += new System.EventHandler(this.NoteBox_TextChanged);
            // 
            // previousNote
            // 
            this.previousNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousNote.Location = new System.Drawing.Point(12, 38);
            this.previousNote.Name = "previousNote";
            this.previousNote.Size = new System.Drawing.Size(429, 281);
            this.previousNote.TabIndex = 2;
            this.previousNote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousNotes);
            this.previousNote.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.previousNote_CellMouseDoubleClick);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 355);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(116, 355);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 4;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // NewNoteBox
            // 
            this.NewNoteBox.Location = new System.Drawing.Point(231, 355);
            this.NewNoteBox.Name = "NewNoteBox";
            this.NewNoteBox.Size = new System.Drawing.Size(75, 23);
            this.NewNoteBox.TabIndex = 5;
            this.NewNoteBox.Text = "New Note";
            this.NewNoteBox.UseVisualStyleBackColor = true;
            this.NewNoteBox.Click += new System.EventHandler(this.NewNoteBox_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(339, 355);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NoteTakeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NewNoteBox);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.previousNote);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.TittleBox);
            this.Name = "NoteTakeApp";
            this.Text = "NoteTakeApp";
            this.Load += new System.EventHandler(this.NoteTakeAppPole);
            ((System.ComponentModel.ISupportInitialize)(this.previousNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TittleBox;
        private System.Windows.Forms.TextBox NoteBox;
        private System.Windows.Forms.DataGridView previousNote;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button NewNoteBox;
        private System.Windows.Forms.Button DeleteButton;
    }
}

