using Guna.UI2.WinForms;
using MySqlConnector;
using Smart_Home.Classes;
using Smart_Home.Connextion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Smart_Home.forms
{
    public partial class AddApartementForm : Form
    {
        public User technicien = new User();
        private DataTable dt = new DataTable();
        private Dictionary<string, int> admins = new Dictionary<string, int>();
        public AddApartementForm()
        {
            InitializeComponent();
            this.loadAdmins();
        }

        private void loadAdmins()
        {
            dt = new DataTable();
          
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();
            cmd.CommandText = "SELECT `id`, `fullname` FROM `user` WHERE role='ADMIN';";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            List<string> data = new List<string>();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                {
                    this.admins.Add(dataRow.ItemArray[1].ToString(), Convert.ToInt16(dataRow.ItemArray[0]));
                    adminCombo.Items.Add(dataRow.ItemArray[1].ToString());
                }
            }
        }

        private void AjouterButton_Click(object sender, EventArgs e)
        {
            int adminId = admins[adminCombo.SelectedItem.ToString()];
            int lg = Convert.ToInt32(largeur.Text);
            int ht = Convert.ToInt32(hauteur.Text);
            int surface = lg * ht;
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();

            cmd.CommandText = "INSERT INTO `appartement`(`id`, `name`, `largeur`, `hauteur`, `adminId`, `technicianId`, `allowTechnicien`, `surface`) " +
                "VALUES(@id, @name,@largeur,@hauteur,@adminId,@technicianId,true, @surface)";
            cmd.Parameters.AddWithValue("@id", null);
            cmd.Parameters.AddWithValue("@name", nom.Text);
            cmd.Parameters.AddWithValue("@largeur", largeur.Text);
            cmd.Parameters.AddWithValue("@hauteur", hauteur.Text);
            cmd.Parameters.AddWithValue("@adminId", adminId);
            cmd.Parameters.AddWithValue("@technicianId", technicien.Id);
            cmd.Parameters.AddWithValue("@surface", surface);
            cmd.ExecuteNonQuery();
            nom.Text = "";
            largeur.Text = "";
            hauteur.Text = "";
            adminCombo.SelectedItem = "";

           
            this.Close();

        }

        private void AnullerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
