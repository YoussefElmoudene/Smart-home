using Smart_Home.Classes;
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

namespace Smart_Home.forms.UserControls
{
    public partial class DOORControl : UserControl
    {
        public Furniture furniture = new Furniture();
        private FurnitureService furnitureService = new FurnitureService();
        public DOORControl(Furniture furniture)
        {
            this.furniture = furniture;
            InitializeComponent();
            verifyStatus(this.furniture.Active);

        }

        private void verifyStatus(bool status)
        {
            if (status)
            {
                this.BackColor = Color.FromArgb(94, 148, 255);
                guna2GradientPanel4.FillColor = Color.FromArgb(94, 148, 255);
                guna2GradientPanel4.FillColor2 = Color.FromArgb(94, 148, 255);
                doorLabel.ForeColor = Color.White;
                onOffLabel.ForeColor = Color.White;
                onOffLabel.Text = "ON";
                this.furnitureService.changeStatus(true, furniture.Id);
                if (!doorStatus.Checked)
                {
                    doorStatus.Checked = true;
                }
            }
            else
            {
                this.BackColor = Color.White;
                guna2GradientPanel4.FillColor = Color.White;
                guna2GradientPanel4.FillColor2 = Color.White;
                doorLabel.ForeColor = Color.Black;
                onOffLabel.ForeColor = Color.Black;
                onOffLabel.Text = "OFF";
                this.furnitureService.changeStatus(false, furniture.Id);
                if (doorStatus.Checked)
                {
                    doorStatus.Checked = false;
                }

            }
        }

        private void doorStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.verifyStatus(doorStatus.Checked);
        }
    }
}
