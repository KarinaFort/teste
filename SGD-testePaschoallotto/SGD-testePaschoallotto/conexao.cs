using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGD_testePaschoallotto
{
    class Conexao
    {
        //Faz a conexão do banco de dados
        public string conect = "SERVER=localhost; PORT=5432; DATABASE=SGD-teste; UID=postgres ; PWD=02102022;";
        public NpgsqlConnection con = null;

        //metodo
        public void AbrirConexao()
        {

            con = new NpgsqlConnection(conect);
            con.Open();
        }

        public void FecharConexao()
        {
            con = new NpgsqlConnection(conect);
            con.Close();
            con.Dispose();//Derruba Conexões abertas
            con.CloseAsync(); //Limpar
        }
    }
}
