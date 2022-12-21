namespace Smart_Home.forms.UserControls
{
    partial class TvControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TvControl));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.onOffLabel = new System.Windows.Forms.Label();
            this.tvStatus = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2GradientPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.pictureBox4.Size = new System.Drawing.Size(129, 81);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.onOffLabel);
            this.panel1.Controls.Add(this.tvStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 40);
            this.panel1.TabIndex = 5;
            // 
            // onOffLabel
            // 
            this.onOffLabel.AutoSize = true;
            this.onOffLabel.BackColor = System.Drawing.Color.Transparent;
            this.onOffLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.onOffLabel.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onOffLabel.ForeColor = System.Drawing.Color.Black;
            this.onOffLabel.Location = new System.Drawing.Point(0, 0);
            this.onOffLabel.Name = "onOffLabel";
            this.onOffLabel.Size = new System.Drawing.Size(54, 22);
            this.onOffLabel.TabIndex = 4;
            this.onOffLabel.Text = "OFF";
            // 
            // tvStatus
            // 
            this.tvStatus.BackColor = System.Drawing.Color.Transparent;
            this.tvStatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tvStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tvStatus.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tvStatus.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tvStatus.Location = new System.Drawing.Point(74, 2);
            this.tvStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvStatus.Name = "tvStatus";
            this.tvStatus.Size = new System.Drawing.Size(41, 20);
            this.tvStatus.TabIndex = 3;
            this.tvStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tvStatus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tvStatus.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tvStatus.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tvStatus.CheckedChanged += new System.EventHandler(this.tvStatus_CheckedChanged);
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel4.Controls.Add(this.panel2);
            this.guna2GradientPanel4.Controls.Add(this.panel1);
            this.guna2GradientPanel4.Controls.Add(this.tvLabel);
            this.guna2GradientPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel4.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientPanel4.Location = new System.Drawing.Point(5, 5);
            this.guna2GradientPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Padding = new System.Windows.Forms.Padding(5);
            this.guna2GradientPanel4.Size = new System.Drawing.Size(153, 168);
            this.guna2GradientPanel4.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 45);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7);
            this.panel2.Size = new System.Drawing.Size(143, 95);
            this.panel2.TabIndex = 6;
            // 
            // tvLabel
            // 
            this.tvLabel.AutoSize = true;
            this.tvLabel.BackColor = System.Drawing.Color.Transparent;
            this.tvLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tvLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvLabel.ForeColor = System.Drawing.Color.Black;
            this.tvLabel.Location = new System.Drawing.Point(5, 140);
            this.tvLabel.Name = "tvLabel";
            this.tvLabel.Size = new System.Drawing.Size(30, 23);
            this.tvLabel.TabIndex = 4;
            this.tvLabel.Text = "TV";
            // 
            // TvControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2GradientPanel4);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TvControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(163, 178);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2GradientPanel4.ResumeLayout(false);
            this.guna2GradientPanel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label onOffLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tvStatus;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label tvLabel;
    }
}
