using System.Configuration;
using MySql.Data.MySqlClient;

namespace yoptaKursach {
    public static class DbConnection {
        private static readonly MySqlConnection Connection =
            new MySqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);

        public static MySqlConnection SqlConnection() => Connection;
        }
}