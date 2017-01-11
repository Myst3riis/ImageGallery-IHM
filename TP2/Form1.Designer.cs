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
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.supprimerLimageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispositionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.avancerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reculerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.album1 = new TP2.Album();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.dispositionToolStripMenuItem1});
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
            this.importerImageToolStripMenuItem.Image = global::TP2.Properties.Resources.open;
            this.importerImageToolStripMenuItem.Name = "importerImageToolStripMenuItem";
            this.importerImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.importerImageToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.importerImageToolStripMenuItem.Text = "Importer une image";
            this.importerImageToolStripMenuItem.Click += new System.EventHandler(this.importerImageToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annulerToolStripMenuItem,
            this.rétablirToolStripMenuItem,
            this.toolStripSeparator2,
            this.couperToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.toolStripSeparator1,
            this.supprimerLimageToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            this.editionToolStripMenuItem.Click += new System.EventHandler(this.editionToolStripMenuItem_Click);
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Enabled = false;
            this.annulerToolStripMenuItem.Image = global::TP2.Properties.Resources.undo;
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.annulerToolStripMenuItem.Text = "Annuler";
            this.annulerToolStripMenuItem.Click += new System.EventHandler(this.annulerToolStripMenuItem_Click);
            // 
            // rétablirToolStripMenuItem
            // 
            this.rétablirToolStripMenuItem.Enabled = false;
            this.rétablirToolStripMenuItem.Image = global::TP2.Properties.Resources.redo;
            this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
            this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.rétablirToolStripMenuItem.Text = "Rétablir";
            this.rétablirToolStripMenuItem.Click += new System.EventHandler(this.rétablirToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Enabled = false;
            this.couperToolStripMenuItem.Image = global::TP2.Properties.Resources.cut;
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.couperToolStripMenuItem.Text = "Couper";
            this.couperToolStripMenuItem.Click += new System.EventHandler(this.couperToolStripMenuItem_Click);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Enabled = false;
            this.copierToolStripMenuItem.Image = global::TP2.Properties.Resources.copy;
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Image = global::TP2.Properties.Resources.paste;
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // supprimerLimageToolStripMenuItem
            // 
            this.supprimerLimageToolStripMenuItem.Enabled = false;
            this.supprimerLimageToolStripMenuItem.Name = "supprimerLimageToolStripMenuItem";
            this.supprimerLimageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.supprimerLimageToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.supprimerLimageToolStripMenuItem.Text = "Supprimer l\'image";
            this.supprimerLimageToolStripMenuItem.Click += new System.EventHandler(this.supprimerLimageToolStripMenuItem_Click);
            // 
            // dispositionToolStripMenuItem1
            // 
            this.dispositionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avancerToolStripMenuItem1,
            this.reculerToolStripMenuItem1});
            this.dispositionToolStripMenuItem1.Name = "dispositionToolStripMenuItem1";
            this.dispositionToolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.dispositionToolStripMenuItem1.Text = "Disposition";
            // 
            // avancerToolStripMenuItem1
            // 
            this.avancerToolStripMenuItem1.Enabled = false;
            this.avancerToolStripMenuItem1.Name = "avancerToolStripMenuItem1";
            this.avancerToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.avancerToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.avancerToolStripMenuItem1.Text = "Avancer";
            this.avancerToolStripMenuItem1.Click += new System.EventHandler(this.avancerToolStripMenuItem1_Click);
            // 
            // reculerToolStripMenuItem1
            // 
            this.reculerToolStripMenuItem1.Enabled = false;
            this.reculerToolStripMenuItem1.Name = "reculerToolStripMenuItem1";
            this.reculerToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.reculerToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.reculerToolStripMenuItem1.Text = "Reculer";
            this.reculerToolStripMenuItem1.Click += new System.EventHandler(this.reculerToolStripMenuItem1_Click);
            // 
            // album1
            // 
            this.album1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.album1.Location = new System.Drawing.Point(0, 24);
            this.album1.Name = "album1";
            this.album1.Size = new System.Drawing.Size(636, 412);
            this.album1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 436);
            this.Controls.Add(this.album1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Galerie photo";
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
        private System.Windows.Forms.ToolStripMenuItem importerImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerLimageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispositionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem avancerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reculerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Album album1;
    }
}

