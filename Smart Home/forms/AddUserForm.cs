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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Smart_Home.forms
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
            role.Items.Add("TECHNICIEN");
            role.Items.Add("ADMIN");
            role.Items.Add("UTILISATEUR");
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AnullerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddUserButon_Click(object sender, EventArgs e)
        {
            User user = new User(0,fullname.Text,telephone.Text,username.Text,password.Text, Convert.ToInt32(age.Text),role.SelectedItem.ToString());
            MessageBox.Show(user.ToString());
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();

            cmd.CommandText = "INSERT INTO `user`(`id`, `fullname`, `telephone`, `username`, `password`, `age`, `role`) VALUES" +
                "VALUES(@id, @fullname,@telephone,@username,@password,@age,@role)";
            cmd.Parameters.AddWithValue("@id", null);
            cmd.Parameters.AddWithValue("@fullname", user.Fullname);
            cmd.Parameters.AddWithValue("@telephone", user.Telephone);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@age", user.Age);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.ExecuteNonQuery();

            cmd.ExecuteNonQuery();
        }
    }
}
