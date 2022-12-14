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
    public partial class REFRIGERATORControl : UserControl
    {
        private Furniture furniture;
        private FurnitureService furnitureService = new FurnitureService();

        public REFRIGERATORControl(Furniture Furniture)
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
                fridgeLabel.ForeColor = Color.White;
                onOffFridge.ForeColor = Color.White;
                onOffFridge.Text = "ON";
                this.furnitureService.changeStatus(true, furniture.Id);
                if (!fridgeStatus.Checked)
                {
                    fridgeStatus.Checked = true;
                }
            }
            else
            {
                this.BackColor = Color.White;
                guna2GradientPanel4.FillColor = Color.White;
                guna2GradientPanel4.FillColor2 = Color.White;
                fridgeLabel.ForeColor = Color.Black;
                onOffFridge.ForeColor = Color.Black;
                onOffFridge.Text = "OFF";
                this.furnitureService.changeStatus(false, furniture.Id);
                if (fridgeStatus.Checked)
                {
                    fridgeStatus.Checked = false;
                }

            }
        }

        private void fridgeStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.verifyStatus(fridgeStatus.Checked);
        }
    }
}
