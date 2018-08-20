namespace GestionaleWinUI
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdArticoli = new System.Windows.Forms.Button();
            this.cmdOrdini = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anagraficheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUtenti = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClienti = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFornitori = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEsci = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdArticoli
            // 
            this.cmdArticoli.Location = new System.Drawing.Point(46, 46);
            this.cmdArticoli.Name = "cmdArticoli";
            this.cmdArticoli.Size = new System.Drawing.Size(249, 170);
            this.cmdArticoli.TabIndex = 0;
            this.cmdArticoli.Text = "Articoli";
            this.cmdArticoli.UseVisualStyleBackColor = true;
            this.cmdArticoli.Click += new System.EventHandler(this.cmdArticoli_Click);
            // 
            // cmdOrdini
            // 
            this.cmdOrdini.Location = new System.Drawing.Point(351, 46);
            this.cmdOrdini.Name = "cmdOrdini";
            this.cmdOrdini.Size = new System.Drawing.Size(249, 170);
            this.cmdOrdini.TabIndex = 1;
            this.cmdOrdini.Text = "Ordini";
            this.cmdOrdini.UseVisualStyleBackColor = true;
            this.cmdOrdini.Click += new System.EventHandler(this.cmdOrdini_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anagraficheToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anagraficheToolStripMenuItem
            // 
            this.anagraficheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUtenti,
            this.tsmClienti,
            this.tsmFornitori,
            this.tsmEsci});
            this.anagraficheToolStripMenuItem.Name = "anagraficheToolStripMenuItem";
            this.anagraficheToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.anagraficheToolStripMenuItem.Text = "Anagrafiche";
            // 
            // tsmUtenti
            // 
            this.tsmUtenti.Name = "tsmUtenti";
            this.tsmUtenti.Size = new System.Drawing.Size(180, 22);
            this.tsmUtenti.Text = "Utenti";
            this.tsmUtenti.Click += new System.EventHandler(this.tsmUtenti_Click);
            // 
            // tsmClienti
            // 
            this.tsmClienti.Name = "tsmClienti";
            this.tsmClienti.Size = new System.Drawing.Size(180, 22);
            this.tsmClienti.Text = "Clienti";
            this.tsmClienti.Click += new System.EventHandler(this.tsmClienti_Click);
            // 
            // tsmFornitori
            // 
            this.tsmFornitori.Name = "tsmFornitori";
            this.tsmFornitori.Size = new System.Drawing.Size(180, 22);
            this.tsmFornitori.Text = "Fornitori";
            this.tsmFornitori.Click += new System.EventHandler(this.tsmFornitori_Click);
            // 
            // tsmEsci
            // 
            this.tsmEsci.Name = "tsmEsci";
            this.tsmEsci.Size = new System.Drawing.Size(180, 22);
            this.tsmEsci.Text = "Esci";
            this.tsmEsci.Click += new System.EventHandler(this.tsmEsci_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 228);
            this.Controls.Add(this.cmdOrdini);
            this.Controls.Add(this.cmdArticoli);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(675, 267);
            this.Name = "MainForm";
            this.Text = "Gestionale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdArticoli;
        private System.Windows.Forms.Button cmdOrdini;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anagraficheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmUtenti;
        private System.Windows.Forms.ToolStripMenuItem tsmClienti;
        private System.Windows.Forms.ToolStripMenuItem tsmFornitori;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmEsci;
    }
}

