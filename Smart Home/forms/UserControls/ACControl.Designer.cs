namespace Smart_Home.forms.UserControls
{
    partial class ACControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.acOnOffLabel = new System.Windows.Forms.Label();
            this.acStatus = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.acLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.guna2GradientPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.acOnOffLabel);
            this.panel1.Controls.Add(this.acStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 40);
            this.panel1.TabIndex = 5;
            // 
            // acOnOffLabel
            // 
            this.acOnOffLabel.AutoSize = true;
            this.acOnOffLabel.BackColor = System.Drawing.Color.Transparent;
            this.acOnOffLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.acOnOffLabel.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acOnOffLabel.ForeColor = System.Drawing.Color.Black;
            this.acOnOffLabel.Location = new System.Drawing.Point(0, 0);
            this.acOnOffLabel.Name = "acOnOffLabel";
            this.acOnOffLabel.Size = new System.Drawing.Size(54, 22);
            this.acOnOffLabel.TabIndex = 4;
            this.acOnOffLabel.Text = "OFF";
            // 
            // acStatus
            // 
            this.acStatus.BackColor = System.Drawing.Color.Transparent;
            this.acStatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.acStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.acStatus.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.acStatus.CheckedState.InnerColor = System.Drawing.Color.White;
            this.acStatus.Location = new System.Drawing.Point(82, 2);
            this.acStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acStatus.Name = "acStatus";
            this.acStatus.Size = new System.Drawing.Size(41, 20);
            this.acStatus.TabIndex = 3;
            this.acStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.acStatus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.acStatus.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.acStatus.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.acStatus.CheckedChanged += new System.EventHandler(this.acStatus_CheckedChanged);
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel4.Controls.Add(this.panel2);
            this.guna2GradientPanel4.Controls.Add(this.panel1);
            this.guna2GradientPanel4.Controls.Add(this.acLabel);
            this.guna2GradientPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel4.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientPanel4.Location = new System.Drawing.Point(5, 5);
            this.guna2GradientPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Size = new System.Drawing.Size(153, 168);
            this.guna2GradientPanel4.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7);
            this.panel2.Size = new System.Drawing.Size(153, 105);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(7, 7);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(139, 91);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // acLabel
            // 
            this.acLabel.AutoSize = true;
            this.acLabel.BackColor = System.Drawing.Color.Transparent;
            this.acLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.acLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acLabel.ForeColor = System.Drawing.Color.Black;
            this.acLabel.Location = new System.Drawing.Point(0, 145);
            this.acLabel.Name = "acLabel";
            this.acLabel.Size = new System.Drawing.Size(32, 23);
            this.acLabel.TabIndex = 4;
            this.acLabel.Text = "AC";
            // 
            // ACControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2GradientPanel4);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ACControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(163, 178);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2GradientPanel4.ResumeLayout(false);
            this.guna2GradientPanel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label acOnOffLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch acStatus;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label acLabel;
    }
}
