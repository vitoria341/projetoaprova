using MySql.Data.MySqlClient;
using projetogrupo.Configs;
using projetogrupo.Models;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projetogrupo.DAO
{
    public class MateriaDAO
    {
        private readonly Conexao _conexao;

        public MateriaDAO(Conexao conexao)
        {
            _conexao = conexao;
        }

        public List<Materia> Listar()
        {
            var lista = new List<Materia>();

            var comando = _conexao.CreateCommand("SELECT * FROM materias;");
            var leitor = (MySqlDataReader)comando.ExecuteReader();

            while (leitor.Read())
            {
                lista.Add(MapearMateria(leitor));
            }

            return lista;
        }

        private static Materia MapearMateria(MySqlDataReader leitor)
        {
            return new Materia
            {
                Id = leitor.GetInt32("id_mat"),
                Nome = DAOHelper.GetString(leitor, "nome_mat"),
                Descricao = DAOHelper.GetString(leitor, "descricao_mat")
            };
        }
    }
}
   