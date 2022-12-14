using Smart_Home.Classes;
using Smart_Home.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Home.forms.UserControls
{
   
    public partial class WIndowControl : UserControl
    {
        private Furniture furniture;
        private FurnitureService furnitureService = new FurnitureService();
        public WIndowControl(Furniture Furniture)
        {
            this.furniture = Furniture;
              
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
                windowLabel.ForeColor = Color.White;
                onOffLabel.ForeColor = Color.White;
                onOffLabel.Text = "ON";
                this.furnitureService.changeStatus(true, furniture.Id);
                if (!windowStatus.Checked)
                {
                    windowStatus.Checked = true;
                }
            }
            else
            {
                this.BackColor = Color.White;
                guna2GradientPanel4.FillColor = Color.White;
                guna2GradientPanel4.FillColor2 = Color.White;
                windowLabel.ForeColor = Color.Black;
                onOffLabel.ForeColor = Color.Black;
                onOffLabel.Text = "OFF";
                this.furnitureService.changeStatus(false, furniture.Id);
                if (windowStatus.Checked)
                {
                    windowStatus.Checked = false;
                }

            }
        }

        private void windowStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.verifyStatus(windowStatus.Checked);
        }
    }
}
