using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGD_testePaschoallotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void importarUmArquivoCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arquivos.importarDados ipd = new arquivos.importarDados();
            ipd.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arquivos.exportarDados epd = new arquivos.exportarDados();
            epd.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            arquivos.importarDados ipd = new arquivos.importarDados();
            ipd.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            arquivos.exportarDados epd = new arquivos.exportarDados();
            epd.ShowDialog();
        }

        private void btnVerSalvos_Click(object sender, EventArgs e)
        {
            arquivos.VisualizarDados vd = new arquivos.VisualizarDados();
            vd.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
