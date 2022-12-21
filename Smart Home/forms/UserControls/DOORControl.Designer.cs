namespace Smart_Home.forms.UserControls
{
    partial class DOORControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DOORControl));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.onOffLabel = new System.Windows.Forms.Label();
            this.doorStatus = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.doorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.guna2GradientPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(5, 6);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(104, 73);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel4.Controls.Add(this.panel2);
            this.guna2GradientPanel4.Controls.Add(this.panel1);
            this.guna2GradientPanel4.Controls.Add(this.doorLabel);
            this.guna2GradientPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel4.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientPanel4.Location = new System.Drawing.Point(4, 4);
            this.guna2GradientPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Size = new System.Drawing.Size(114, 137);
            this.guna2GradientPanel4.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Size = new System.Drawing.Size(114, 85);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.onOffLabel);
            this.panel1.Controls.Add(this.doorStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 32);
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
            this.onOffLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.onOffLabel.Name = "onOffLabel";
            this.onOffLabel.Size = new System.Drawing.Size(46, 18);
            this.onOffLabel.TabIndex = 4;
            this.onOffLabel.Text = "OFF";
            // 
            // doorStatus
            // 
            this.doorStatus.BackColor = System.Drawing.Color.Transparent;
            this.doorStatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.doorStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.doorStatus.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.doorStatus.CheckedState.InnerColor = System.Drawing.Color.White;
            this.doorStatus.Location = new System.Drawing.Point(62, 2);
            this.doorStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doorStatus.Name = "doorStatus";
            this.doorStatus.Size = new System.Drawing.Size(31, 16);
            this.doorStatus.TabIndex = 3;
            this.doorStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.doorStatus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.doorStatus.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.doorStatus.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.doorStatus.CheckedChanged += new System.EventHandler(this.doorStatus_CheckedChanged);
            // 
            // doorLabel
            // 
            this.doorLabel.AutoSize = true;
            this.doorLabel.BackColor = System.Drawing.Color.Transparent;
            this.doorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.doorLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doorLabel.ForeColor = System.Drawing.Color.Black;
            this.doorLabel.Location = new System.Drawing.Point(0, 117);
            this.doorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doorLabel.Name = "doorLabel";
            this.doorLabel.Size = new System.Drawing.Size(47, 20);
            this.doorLabel.TabIndex = 4;
            this.doorLabel.Text = "DOOR";
            // 
            // DOORControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2GradientPanel4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DOORControl";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Size = new System.Drawing.Size(122, 145);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.guna2GradientPanel4.ResumeLayout(false);
            this.guna2GradientPanel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label onOffLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch doorStatus;
        private System.Windows.Forms.Label doorLabel;
    }
}
