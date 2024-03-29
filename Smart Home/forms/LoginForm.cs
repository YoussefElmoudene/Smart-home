﻿using MySqlConnector;
using Smart_Home.Classes;
using Smart_Home.Connextion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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
            List<string> data = new List<string>();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        data.Add(item.ToString());
                    }
                }

                User user = new User(Convert.ToInt32(data[0]), data[1], data[2], data[3], data[4], Convert.ToInt32(data[5]), data[6], Convert.ToBoolean(data[7]));
                if (user.Firstcon || user.Role == "TECHNICIEN")
                {
                    Dashboard dashboard = new Dashboard(user);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    ChangePassword ch = new ChangePassword(user);
                    ch.Show();
                    this.Hide();
                }
                // Dashboard dashboard = new Dashboard(user);
                //dashboard.Show();
                //this.Hide();

               



            }
            else
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

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
