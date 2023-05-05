namespace HabitTracker.Entities
{
    class User
    {
        private string email;
        private string name;
        private string password;

        public string Email { get { return email; } set { email = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Password { get { return password; } set { password = value; } }

        public User()
        {
            name = null;
            email = null;
            password = null;
        }
        public User(string t_email, string t_name, string t_password)
        {
            email = t_email;
            name = t_name;   
            password = t_password;
        }

    }
}
