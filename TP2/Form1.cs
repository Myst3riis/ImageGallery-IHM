using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void ajouterImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void importerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Images Files|*.jpg;*.bmp;*.png|All|*.*";
            openFileDialog1.Title = "Select a Image";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                drawImage1.displayImage(openFileDialog1.FileName);
                drawImage1.Invalidate();
            }

        }

        private void avancerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawImage1.imgUp();
        }

        private void reculerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawImage1.imgDown();
        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void supprimerLimageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawImage1.suppr();
        }
    }
}
