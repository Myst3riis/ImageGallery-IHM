using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2015;

namespace TP2
{
    public partial class Form1 : Form
    {
        private UndoRedoHistory hist;

        public Form1()
        {
            hist = new UndoRedoHistory();
            InitializeComponent();
            album1.form = this;
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void importerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Images Files|*.jpg;*.bmp;*.png|All|*.*";
            openFileDialog1.Title = "Select a Image";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                album1.displayImage(openFileDialog1.FileName);
                album1.Invalidate();

                annulerToolStripMenuItem.Enabled = true;
                rétablirToolStripMenuItem.Enabled = true;

            }

        }

        private void avancerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            album1.imgUp();
        }

        private void reculerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            album1.imgDown();
        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            album1.cut();
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            album1.copy();
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            album1.paste();
        }

        private void supprimerLimageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            album1.delete();
        }

        private void annulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hist.CanUndo())
                hist.Undo();
        }

        private void rétablirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hist.CanRedo())
                hist.Redo();
        }

        private void avancerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            album1.imgUp();
        }

        private void reculerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            album1.imgDown();
        }

        public void enableEditButtons()
        {
            couperToolStripMenuItem.Enabled = true;
            copierToolStripMenuItem.Enabled = true;
            supprimerLimageToolStripMenuItem.Enabled = true;
        }

        public void disableEditButtons()
        {
            couperToolStripMenuItem.Enabled = false;
            copierToolStripMenuItem.Enabled = false;
            supprimerLimageToolStripMenuItem.Enabled = false;
        }


        public void enableAvancer()
        {
            avancerToolStripMenuItem1.Enabled = true;
        }

        public void disableAvancer()
        {
            avancerToolStripMenuItem1.Enabled = false;
        }
        public void enableReculer()
        {
            reculerToolStripMenuItem1.Enabled = true;
        }

        public void disableReculer()
        {
            reculerToolStripMenuItem1.Enabled = false;
        }
    }
}
