using MySqlConnector;
using System.Data;

namespace Smart_Home.Connextion
{
    internal class MyConnextion
    {
        private MySqlConnection connexion;

        public MyConnextion()
        {
            this.connexion = new MySqlConnection($"datasource=localhost;port=3306;username=root;password=root;database=smart_home"); ;
        }

        public void open()
        {
            if (this.connexion.State != ConnectionState.Open)
            {
                this.connexion.Open();
            }
        }

        public MySqlConnection getConnextion()
        {
            return this.connexion;
        }
    }
}
