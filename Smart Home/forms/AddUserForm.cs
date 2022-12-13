using Smart_Home.Classes;
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
        }
    }
}
