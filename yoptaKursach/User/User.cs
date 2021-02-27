namespace yoptaKursach.User {
    public enum UserRole {
        Administrator,
        Manager,
        Consumer
    }

    public class User {
        public User() {
            //TODO: Make a query to DB
        }

        public int Id { get; }

        public UserRole Role { get; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string DocumentNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string Sex { get; set; }
    }
}