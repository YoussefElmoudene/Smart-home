using MySqlConnector;
using Smart_Home.Classes;
using Smart_Home.Connextion;
using Smart_Home.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Home.forms
{
    public partial class AddChambreForm : Form
    {
        private Dictionary<string, int> users = new Dictionary<string, int>();
        private Appartement appartement = new Appartement();
        private AppartementService appartementService = new AppartementService();

        public AddChambreForm(Appartement appartement)
        {
            this.appartement = appartement;
            InitializeComponent();
            typeComboBox.Items.Add("SALON");
            typeComboBox.Items.Add("KITCHEN");
            typeComboBox.Items.Add("BEDROOM");
            typeComboBox.Items.Add("BATHROOM");
            this.loadUsers();
        }

        private void loadUsers()
        {
            DataTable dt = new DataTable();

            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();
            cmd.CommandText = "SELECT `id`, `fullname` FROM `user` WHERE role='UTILISATEUR';";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            List<string> data = new List<string>();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                {
                    this.users.Add(dataRow.ItemArray[1].ToString(), Convert.ToInt16(dataRow.ItemArray[0]));
                    userComboBox.Items.Add(dataRow.ItemArray[1].ToString());
                }
            }
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {

            int userId = 0;
            if (userComboBox.SelectedIndex != -1)
            {
                 userId = users[userComboBox.SelectedItem.ToString()];
            }
            int lg = Convert.ToInt32(largeurInput.Text);
            int ht = Convert.ToInt32(hauteurInput.Text);
            int surface = lg * ht;
            if(this.appartement.Surface < surface)
            {
                MessageBox.Show("Espace insuffisant.");
                return;
            }
            this.appartement = this.appartementService.updateSurface(this.appartement.Surface - surface, this.appartement.Id);
           
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();

            cmd.CommandText = "INSERT INTO `chambre`(`id`, `largeur`, `hauteur`, `type`, `appartementId`, `userId`, `surface`) " +
                "VALUES(@id , @largeur , @hauteur , @type , @appartementId , @userId , @surface)";
            cmd.Parameters.AddWithValue("@id", null);
            cmd.Parameters.AddWithValue("@largeur", largeurInput.Text);
            cmd.Parameters.AddWithValue("@hauteur", hauteurInput.Text);
            cmd.Parameters.AddWithValue("@type", typeComboBox.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@appartementId", this.appartement.Id);
            if(userId ==0) cmd.Parameters.AddWithValue("@userId", this.appartement.Admin.Id);
            if(userId !=0) cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@surface", surface);
            cmd.ExecuteNonQuery();
            this.Close();
        }

        private void AnullerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
