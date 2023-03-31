using OfficeOpenXml;//Bibl que contem classes para trab com arquivos excel
using Npgsql;//Biblioteca pra trabalhar com postgreSQL
using System;
using System.Data;
using System.IO;//E/S
using System.Windows.Forms;



namespace SGD_testePaschoallotto.arquivos
{
    public partial class exportarDados : Form
    {
        Conexao con = new Conexao();
        public exportarDados()
        {
            InitializeComponent();
        }

        private void exportarDados_Load(object sender, EventArgs e)
        {
           
            // instância que esta criando uma conexão com o banco de dados
             con.AbrirConexao();

                // Consulta para listar todas as tabelas do banco de dados com os nomes personalizados
                var sql = @"SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' AND table_type = 'BASE TABLE';";

                //faz adaptador de dados para executar a consulta
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            // conexão com o banco de dados
            con.AbrirConexao();

            // recebe o nome da tabela selecionada no DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var nomeTabela = dataGridView1.SelectedRows[0].Cells["table_name"].Value.ToString();
                

                //consulta para selecionar todos os dados da tabela
                var sql = $"SELECT * FROM {nomeTabela};";

                // adaptação de dads para a consulta
                using (var cmd = new NpgsqlDataAdapter(sql, con.con))
                {
                    // DataTable(TABELA DE DADOS) armazena os resultados da consulta
                    var dataTable = new DataTable();

                    // Preenchimento do DataTable com os dados retornados 
                    cmd.Fill(dataTable);

                    
                    // Abre diálogo para salvar no pc
                    var saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Arquivos Excel (*.xlsx)|*.xlsx",
                        Title = "Salvar arquivo",
                        FileName = $"{nomeTabela}.xlsx"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //salva o arquivo no caminho escolhido
                        var caminho = saveFileDialog.FileName;

                        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;//IMPORTANTE!!! definido para atender aos requisitos da Microsoft para o uso da biblioteca Open XML SDK para Excel em aplicativos não comerciais
                        using (var fluxoArqv = new MemoryStream())
                        using (var formato = new ExcelPackage(fluxoArqv))
                        {
                            var worksheet = formato.Workbook.Worksheets.Add(nomeTabela);//cria uma nova planilha e armazena na variável
                            worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);//carrega os dados da tabela especificada na célula "A1" da planilha criada
                            formato.Save();//Salva no formato .xlsx

                            File.WriteAllBytes(caminho, fluxoArqv.ToArray());//grava os bytes do arquivo em um stream e escreve em um arquivo com o caminho especificado.

                        }
                        var res = MessageBox.Show("Arquivo exportado para o computador", "Esportar Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)//Fecha a tela de importar dados
                        {
                            Close();
                        }

                    }
                    
                }
                   
            }

            
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //Verif se existe alguma linha selecionada na tabela
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Habilita o botão de exportar quando clicado na tabela escolhida corretamente
                btnExport.Enabled = true;
            }
            else
            {
                //Desabilita o botão de exportar quando clicado fora do local especificado
                btnExport.Enabled = false;
            }
        }
    }
}
