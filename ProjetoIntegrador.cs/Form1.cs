using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void drEmanuelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaEmanuel consultaEmanuel = new consultaEmanuel();
            consultaEmanuel.ShowDialog();
        }

        private void draAnnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drAnna drAnna = new drAnna();
            drAnna.ShowDialog();
        }
    }
}
