using Guna.UI2.WinForms;
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
    public partial class Dashboard : Form
    {
        public User user = new User();
        public Dashboard(User user)
        {
            this.user = user;
            InitializeComponent();
            this.onInit();
        }

        private void onInit()
        {
            adminLabel.Text = user.Fullname;
            if(this.user.Role.Equals("TECHNICIEN"))
            {
                AddApartement.Visible = false;
                AddChambre.Visible = false;
                AddUser.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

  

        private void guna2ImageButton1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            } else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void guna2ImageButton1_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2ImageButton g = (Guna2ImageButton)sender;
            g.Select();
            g.DoDragDrop(g.Name,DragDropEffects.Copy);
        }

      

        private void guna2ImageButton3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void guna2ImageButton3_MouseDown_1(object sender, MouseEventArgs e)
        {
            Guna2ImageButton g1 = (Guna2ImageButton)sender;
            g1.Select();
            g1.DoDragDrop(g1.Name, DragDropEffects.Copy);
        }

        private void guna2ImageButton4_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2ImageButton g1 = (Guna2ImageButton)sender;
            g1.Select();
            g1.DoDragDrop(g1.Name, DragDropEffects.Copy);
        }

        private void guna2ImageButton4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void guna2ImageButton5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void guna2ImageButton5_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2ImageButton g1 = (Guna2ImageButton)sender;
            g1.Select();
            g1.DoDragDrop(g1.Name, DragDropEffects.Copy);
        }

        private void guna2ImageButton6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void guna2ImageButton6_MouseDown(object sender, MouseEventArgs e)
        {

            Guna2ImageButton g1 = (Guna2ImageButton)sender;
            g1.Select();
            g1.DoDragDrop(g1.Name, DragDropEffects.Copy);
        }   

        private void guna2ImageButton7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void guna2ImageButton7_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2ImageButton g1 = (Guna2ImageButton)sender;
            g1.Select();
            g1.DoDragDrop(g1.Name, DragDropEffects.Copy);
        }

        private void guna2ImageButton8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void guna2ImageButton8_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2ImageButton g1 = (Guna2ImageButton)sender;
            g1.Select();
            g1.DoDragDrop(g1.Name, DragDropEffects.Copy);
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void AddChambre_Click(object sender, EventArgs e)
        {

        }

        private void AddApartement_Click(object sender, EventArgs e)
        {

        }
    }
    }

