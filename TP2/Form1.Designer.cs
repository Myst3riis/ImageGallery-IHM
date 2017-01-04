namespace TP2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avancerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reculerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerLimageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawImage1 = new TP2.Album();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importerImageToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // importerImageToolStripMenuItem
            // 
            this.importerImageToolStripMenuItem.Name = "importerImageToolStripMenuItem";
            this.importerImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.importerImageToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.importerImageToolStripMenuItem.Text = "Importer Image";
            this.importerImageToolStripMenuItem.Click += new System.EventHandler(this.importerImageToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dispositionToolStripMenuItem,
            this.couperToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.supprimerLimageToolStripMenuItem,
            this.annulerToolStripMenuItem,
            this.rétablirToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            this.editionToolStripMenuItem.Click += new System.EventHandler(this.editionToolStripMenuItem_Click);
            // 
            // dispositionToolStripMenuItem
            // 
            this.dispositionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avancerToolStripMenuItem,
            this.reculerToolStripMenuItem});
            this.dispositionToolStripMenuItem.Name = "dispositionToolStripMenuItem";
            this.dispositionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.dispositionToolStripMenuItem.Text = "Disposition";
            // 
            // avancerToolStripMenuItem
            // 
            this.avancerToolStripMenuItem.Name = "avancerToolStripMenuItem";
            this.avancerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.avancerToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.avancerToolStripMenuItem.Text = "Avancer l\'image";
            this.avancerToolStripMenuItem.Click += new System.EventHandler(this.avancerToolStripMenuItem_Click);
            // 
            // reculerToolStripMenuItem
            // 
            this.reculerToolStripMenuItem.Name = "reculerToolStripMenuItem";
            this.reculerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.reculerToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.reculerToolStripMenuItem.Text = "Reculer l\'image";
            this.reculerToolStripMenuItem.Click += new System.EventHandler(this.reculerToolStripMenuItem_Click);
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.couperToolStripMenuItem.Text = "Couper";
            this.couperToolStripMenuItem.Click += new System.EventHandler(this.couperToolStripMenuItem_Click);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // supprimerLimageToolStripMenuItem
            // 
            this.supprimerLimageToolStripMenuItem.Name = "supprimerLimageToolStripMenuItem";
            this.supprimerLimageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.supprimerLimageToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.supprimerLimageToolStripMenuItem.Text = "Supprimer l\'image";
            this.supprimerLimageToolStripMenuItem.Click += new System.EventHandler(this.supprimerLimageToolStripMenuItem_Click);
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.annulerToolStripMenuItem.Text = "Annuler";
            this.annulerToolStripMenuItem.Click += new System.EventHandler(this.annulerToolStripMenuItem_Click);
            // 
            // rétablirToolStripMenuItem
            // 
            this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
            this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.rétablirToolStripMenuItem.Text = "Rétablir";
            this.rétablirToolStripMenuItem.Click += new System.EventHandler(this.rétablirToolStripMenuItem_Click);
            // 
            // drawImage1
            // 
            this.drawImage1.BackColor = System.Drawing.Color.White;
            this.drawImage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawImage1.Location = new System.Drawing.Point(0, 24);
            this.drawImage1.Name = "drawImage1";
            this.drawImage1.Size = new System.Drawing.Size(636, 412);
            this.drawImage1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 436);
            this.Controls.Add(this.drawImage1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TP 2016";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private Album drawImage1;
        private System.Windows.Forms.ToolStripMenuItem importerImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avancerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reculerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerLimageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem;
    }
}

