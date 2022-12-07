using MySqlConnector;
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
    public partial class LoginForm : Form
    {
        private string username;
        private string password;
        private DataTable dt = new DataTable();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            username = guna2TextBox1.Text;
            password = guna2TextBox2.Text;
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();
            cmd.CommandText = "SELECT *  FROM user WHERE username='" + username + "' AND password='" + password + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        //MessageBox.Show(item.ToString());
                    }
                }

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            } else
            {
                this.errorMessage.Visible = true;
                this.guna2TextBox2.BorderColor = Color.Red;
                this.guna2TextBox1.BorderColor = Color.Red;
            }
        }

        private void errorMessage_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.errorMessage.Visible = false;
            this.guna2TextBox2.BorderColor = Color.FromArgb(25, 150, 243);
            this.guna2TextBox1.BorderColor = Color.FromArgb(25, 150, 243); ;

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            this.errorMessage.Visible = false;
            this.guna2TextBox2.BorderColor = Color.FromArgb(25, 150, 243);
            this.guna2TextBox1.BorderColor = Color.FromArgb(25, 150, 243);

        }
    }
}
