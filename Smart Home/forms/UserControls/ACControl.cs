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
    
    public partial class ACControl : UserControl
    {
        private Furniture furniture;
        private FurnitureService furnitureService = new FurnitureService();
        public ACControl(Furniture Furniture)
        {
            this.furniture = Furniture;
            InitializeComponent();
            this.verifyStatus(this.furniture.Active);
        }

        private void verifyStatus(bool status)
        {
            if (status)
            {
                this.BackColor = Color.FromArgb(94, 148, 255);
                guna2GradientPanel4.FillColor = Color.FromArgb(94, 148, 255);
                guna2GradientPanel4.FillColor2 = Color.FromArgb(94, 148, 255);
                acLabel.ForeColor = Color.White;
                acOnOffLabel.ForeColor = Color.White;
                acOnOffLabel.Text = "ON";
                this.furnitureService.changeStatus(true, furniture.Id);
                if (!acStatus.Checked)
                {
                    acStatus.Checked = true;
                }
            }
            else
            {
                this.BackColor = Color.White;
                guna2GradientPanel4.FillColor = Color.White;
                guna2GradientPanel4.FillColor2 = Color.White;
                acLabel.ForeColor = Color.Black;
                acOnOffLabel.ForeColor = Color.Black;
                acOnOffLabel.Text = "OFF";
                this.furnitureService.changeStatus(false, furniture.Id);
                if (acStatus.Checked)
                {
                    acStatus.Checked = false;
                }

            }
        }

        private void acStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.verifyStatus(acStatus.Checked);
        }
    }
}
