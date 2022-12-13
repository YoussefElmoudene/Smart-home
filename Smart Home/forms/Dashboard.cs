using Guna.UI2.WinForms;
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
        bool mouseDown;
        public Dashboard()
        {
            InitializeComponent();
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
            g.DoDragDrop(g,DragDropEffects.Copy);
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

    

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void apartementForm1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_MouseDown_1(object sender, MouseEventArgs e)
        {
            Guna2ImageButton g1 = (Guna2ImageButton)sender;
            g1.Select();
            g1.DoDragDrop(g1, DragDropEffects.Copy);
        }
    }
}
