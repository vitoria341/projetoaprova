using MySql.Data.MySqlClient;
using MySqlConnector;

namespace projetogrupo.Configs
{
    public class DAOHelper
    {
        public static string GetString(MySql.Data.MySqlClient.MySqlDataReader reader, string column_name)
        {
            string text = string.Empty;
            if (!reader.IsDBNull(reader.GetOrdinal(column_name)))
                text = reader.GetString(column_name);
            return text;
        }
        // Lê um double; se a coluna for NULL, devolve 0.0
        public static double GetDouble(MySql.Data.MySqlClient.MySqlDataReader reader, string column_name)
        {
            double value = 0.0;
            if (!reader.IsDBNull(reader.GetOrdinal(column_name)))
                value = reader.GetDouble(column_name);
            return value;
        }
        // Lê uma data; se a coluna for NULL, devolve null
        public static DateTime? GetDateTime(MySql.Data.MySqlClient.MySqlDataReader reader, string column_name)
        {
            DateTime? value = null;
            if (!reader.IsDBNull(reader.GetOrdinal(column_name)))
                value = reader.GetDateTime(column_name);
            return value;
        }
        // Indica se uma coluna está NULL
        public static bool IsNull(MySql.Data.MySqlClient.MySqlDataReader reader, string column_name)
        {
            return reader.IsDBNull(reader.GetOrdinal(column_name));
        }
    }
}
