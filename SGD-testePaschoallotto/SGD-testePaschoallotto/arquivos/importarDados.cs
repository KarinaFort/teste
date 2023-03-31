using System;//bibl padrão
using System.Collections.Generic;//biblioteca que contém classes genéricas como List e Dictionary
using System.ComponentModel;//que contém class para implemetar a funcionalidade de vinculação de dados
using System.Data;//contém classes para trabalhar com dados
using System.Linq;//biblioteca que contém classes para realizar consultas em coleções
using System.Threading.Tasks;//ontém classes para trabalhar com tarefas assíncronas
using System.Windows.Forms;//implementa a interface grfica
using System.IO;// bibl que tem classes pra trab com entrada e saida de dads
using CsvHelper;// tem classes para trabalharee com csv
using ExcelDataReader;// contemn classes pra fazer a leitura de arquivos em excel 

using Npgsql;//Biblioteca pra trabalhar com postgreSQL


namespace SGD_testePaschoallotto.arquivos
{
    public partial class importarDados : Form
    {
        Conexao con = new Conexao();
        string arquivo;

        public importarDados()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            PegarDadosExcel();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Vê se o DataGridView está preenchido com as informações da tabela
            if (dataGridView1.DataSource != null)
            {
                // Abre uma caixa de diálogo para o usuário digitar o nome da tabela
                string tabela = "";
                using (var form = new NomeTabelaDialog())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        tabela = form.NomeTabela;
                    }
                }

                if (string.IsNullOrEmpty(tabela))
                {
                    // o usuário não inseriu um nome de tabela, então exiba uma mensagem de aviso
                    MessageBox.Show("Insira um nome para a tabela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // recebe o DataTable com os dados do DataGridView
                DataTable dataTable = (DataTable)dataGridView1.DataSource;

                // Salva a tabela no banco de dados
                SalvarTabela(dataTable, tabela);

                //Mensagem de confirmação para o uruário identificar o nome da tabela
                var res = MessageBox.Show("Arquivo " + tabela + " salvo com Sucesso no banco De dados!", "Importar dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)//Fecha a tela de importar dados caso confirme
                {
                    Close();
                }
            }
            else
            {
                //Previnir que o usuário esqueça de importar os dados antes de salvar, o sistema não vai criar uma tabela vazia
                MessageBox.Show("Importe um arquivo antes de salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        //MÉTODOS   
        private static void SalvarTabela(DataTable dataTable, string tabela) //Método que estabelece a conexão
        {
            //Se conecta ao banco de dados
            Conexao con = new Conexao();
            con.AbrirConexao();

            //definição da lista de colunas e tipos de dados
            var colunas = new List<string>();
            var tipos = new List<string>();
            foreach (DataColumn coluna in dataTable.Columns)
            {
                colunas.Add(coluna.ColumnName);//Definindo o nome da coluna e logo abaixo ele descobre o tipo do dado armazenado
                tipos.Add(coluna.DataType == typeof(string) ? "text" : "numeric" );
            }

            // Cria a tabela no banco de dados com o nome definido com letras e numeros lá em cima no btnSalvar_Click
            using (var cmd = new NpgsqlCommand($"CREATE TABLE {tabela} ({string.Join(",", colunas.Zip(tipos, (c, t) => $"{c} {t}"))})", con.con))
            {
                cmd.ExecuteNonQuery();
            }

            // Insere os dados coletados de cada linha na tabela
            foreach (DataRow row in dataTable.Rows)
            {
                var values = new List<string>();
                foreach (var item in row.ItemArray)
                {
                    values.Add(item.ToString());
                }
                using (var cmd = new NpgsqlCommand($"INSERT INTO {tabela} ({string.Join(",", colunas)}) VALUES ({string.Join(",", values.Select(v => $"'{v.Replace("'", "''")}'"))})", con.con))
                {
                    for (int i = 0; i < values.Count; i++)
                    {
                        cmd.Parameters.AddWithValue($"@p{i}", values[i]);
                    }
                    cmd.ExecuteNonQuery();
                }

                
            }

        }


        private void PegarDadosExcel()
        {
            // Abre caixa de diálogo para selecionar arquivo .xlsx desejado
            OpenFileDialog dialog = new OpenFileDialog();
            arquivo = dialog.FileName.ToString();
            dialog.Filter = "Arquivos(*.xlsx;) | *.xlsx;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Carrega todos os dados do arquivo selecionado em um DataTable
                DataTable dataTable = new DataTable();
                string file = dialog.FileName;
                string extension = Path.GetExtension(file);
                using (var stream = new FileStream(file, FileMode.Open, FileAccess.Read))

                
                    using (var excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                    {
                        var dataSet = excelReader.AsDataSet();//asDataSet faz a leitura do arquivo e armazena na variavel de conjuntos de dados 
                        dataTable = dataSet.Tables[0].AsEnumerable().Skip(1).CopyToDataTable();//pulando a primeira linha que é de nomes das colunas

                    for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            //Pegando a primeira linha e as transformando em nome de colunas
                            dataTable.Columns[i].ColumnName = dataSet.Tables[0].Rows[0][i].ToString();
                        }
                    }
                // Faz a exibição dos dados do DataTable no DataGridView
                dataGridView1.DataSource = dataTable;
            }
                
            
        }

        
    }
    

}
