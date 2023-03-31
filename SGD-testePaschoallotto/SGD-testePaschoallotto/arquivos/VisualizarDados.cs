using Npgsql;
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
    public partial class VisualizarDados : Form
    {
        Conexao con = new Conexao();
        public VisualizarDados()
        {
            InitializeComponent();
        }

        private void VisualizarDados_Load(object sender, EventArgs e)
        {
            con.AbrirConexao();
            // Cria uma consulta para listar todas as tabelas do banco de dados
            var sql = @"SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' AND table_type = 'BASE TABLE';";

            // Cria um adaptador de dados para executar a consulta
            using (var cmd = new NpgsqlDataAdapter(sql, con.con))
            {
                // Cria um DataTable para armazenar os resultados da consulta
                var dataTable = new DataTable();

                // Preenche o DataTable com os dados retornados pela consulta
                cmd.Fill(dataTable);

                // Define o DataTable como a fonte de dados do DataGridView
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
