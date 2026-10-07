using MySql.Data.MySqlClient;
using projetogrupo.Configs;
using projetogrupo.Models;

namespace projetogrupo.DAO
{
    public class UsuarioDAO
    {
        private readonly Conexao _conexao;

        public UsuarioDAO(Conexao conexao)
        {
            _conexao = conexao;
        }

        public List<Usuario> Listar()
        {
            var lista = new List<Usuario>();

            var comando = _conexao.CreateCommand("SELECT * FROM usuarios;");
            var leitor = (MySqlDataReader)comando.ExecuteReader();

            while (leitor.Read())
            {
                lista.Add(MapearUsuario(leitor));
            }

            return lista;
        }

        private static Usuario MapearUsuario(MySqlDataReader leitor)
        {
            return new Usuario
            {
                Id = leitor.GetInt32("id_usu"),
                Nome = DAOHelper.GetString(leitor, "nome_usu"),
                Email = DAOHelper.GetString(leitor, "email_usu"),
                Senha = DAOHelper.GetString(leitor, "senha_usu"),

            };
        }

        public void Inserir(Usuario usuario)
        {
            try
            {
                using var con = _conexao.GetConnection();
                string sql = @"INSERT INTO usuario (nome_usu, email_usu, senha_usu)
                VALUES (@nome, @email, @senha)";

                using var comando = con.CreateCommand();
                comando.CommandText = sql;
                comando.Parameters.AddWithValue("@nome", usuario.Nome); ;
                comando.Parameters.AddWithValue("@email", usuario.Email);
                comando.Parameters.AddWithValue("@senha", usuario.Senha);

                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
    }
}