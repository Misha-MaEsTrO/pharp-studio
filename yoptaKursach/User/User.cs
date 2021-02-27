using System.Windows;
using MySql.Data.MySqlClient;

namespace yoptaKursach {
    public enum UserRole {
        Administrator = 0,
        Manager = 1,
        Consumer = 2
    }

    public class User {
        
        public int Id { get; }

        public UserRole Role { get; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string DocumentNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string Sex { get; set; }
        
        
        public User() {
            using (MySqlConnection connection = DbConnection.SqlConnection()) {
                connection.Open();
                var reader = new MySqlCommand("select id from users where login = 'admin'", connection).ExecuteScalar();
                MessageBox.Show($"{reader}");
                
            }
        }
        
    }
}