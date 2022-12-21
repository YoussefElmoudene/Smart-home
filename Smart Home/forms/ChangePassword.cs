using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Smart_Home.Connextion;

using MySqlConnector;
using Guna.UI2.WinForms;
using Smart_Home.Classes;

namespace Smart_Home.forms
{
    public partial class ChangePassword : Form
    {

        private string username;
        private string password;
        private LoginForm loginForm;
        public User user = new User();
        private DataTable dt = new DataTable();
        public ChangePassword(User user)
        {
            this.user = user;
            InitializeComponent();
            
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            dt = new DataTable();
            password = oldPassword.Text;
           
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();
            cmd.CommandText = "SELECT *  FROM user WHERE username= '"+ username + "'AND password='" + password + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
           

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            password = NewPassword.Text;
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();
            cmd.CommandText = "UPDATE user set password='" + password + "',`firstcon`=true WHERE username= '" + user.Username + "';";
            cmd.ExecuteNonQuery();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            MessageBox.Show("Your password has been changed");
           
            Dashboard dashboard = new Dashboard(user);
            dashboard.Show();
            this.Close();
        }
    }
}
