using MySql.Data.MySqlClient;
using projetogrupo.Configs;
using projetogrupo.Models;
using System.Diagnostics;

namespace projetogrupo.DAO
{
    public class TopicoDAO
    {
        private readonly Conexao _conexao;

        public TopicoDAO(Conexao conexao)
        {
            _conexao = conexao;
        }

        public List <Topico> Listar()
        {
            var lista = new List<Topico>();

            var comando = _conexao.CreateCommand("SELECT * FROM topicos;");
            var leitor = (MySqlDataReader)comando.ExecuteReader();

            while (leitor.Read())
            {
                lista.Add(MapearTopico(leitor));
            }

            return lista;
        }

        private static Topico MapearTopico(MySqlDataReader leitor)
        {
            return new Topico
            {
                Id = leitor.GetInt32("id_top"),
                Nome = DAOHelper.GetString(leitor, "nome_top"),
              
            };
        }

        public void Inserir(Topico topico)
        {
            try
            {
                using var con = _conexao.GetConnection();
                string sql = @"INSERT INTO topico (nome_top) 
                VALUES (@nome)";

                using var comando = con.CreateCommand();
                comando.CommandText = sql;
                comando.Parameters.AddWithValue("@nome", topico.Nome); ;

                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
    }
}
