using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGD_testePaschoallotto.arquivos
{
    public partial class NomeTabelaDialog : Form
    {
       

        public string NomeTabela { get; set; }
        public NomeTabelaDialog()
        {
            InitializeComponent();
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            NomeTabela = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
