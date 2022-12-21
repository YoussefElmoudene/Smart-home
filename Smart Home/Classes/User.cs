namespace Smart_Home.Classes
{
    public class User
    {
        private int id;
        private string fullname;
        private string telephone;
        private string username;
        private string password;
        private int age;
        private string role;
        private bool firstcon;

        public User(int id, string fullname, string telephone, string username, string password, int age, string role, bool firstcon)
        {
            this.Id = id;
            this.Fullname = fullname;
            this.Telephone = telephone;
            this.Username = username;
            this.Password = password;
            this.Age = age;
            this.Role = role;
            this.Firstcon = firstcon;
        }

        public User()
        {
        }

        public override string ToString()
        {
            return "Id: " + id + ", FullName: " + fullname + ",  Tele: " + telephone + ",  Username: " + username + ", pass: " + password + ", age: " + age + ", Role: " + role;
        }

        public int Id { get => id; set => id = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Age { get => age; set => age = value; }
        public string Role { get => role; set => role = value; }
        public bool Firstcon { get => firstcon; set => firstcon = value; }
    }
}
