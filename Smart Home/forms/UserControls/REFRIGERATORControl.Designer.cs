namespace Smart_Home.forms.UserControls
{
    partial class REFRIGERATORControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REFRIGERATORControl));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.onOffFridge = new System.Windows.Forms.Label();
            this.fridgeStatus = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fridgeLabel = new System.Windows.Forms.Label();
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
            this.pictureBox4.Size = new System.Drawing.Size(139, 91);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.onOffFridge);
            this.panel1.Controls.Add(this.fridgeStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 40);
            this.panel1.TabIndex = 5;
            // 
            // onOffFridge
            // 
            this.onOffFridge.AutoSize = true;
            this.onOffFridge.BackColor = System.Drawing.Color.Transparent;
            this.onOffFridge.Dock = System.Windows.Forms.DockStyle.Left;
            this.onOffFridge.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onOffFridge.ForeColor = System.Drawing.Color.Black;
            this.onOffFridge.Location = new System.Drawing.Point(0, 0);
            this.onOffFridge.Name = "onOffFridge";
            this.onOffFridge.Size = new System.Drawing.Size(54, 22);
            this.onOffFridge.TabIndex = 4;
            this.onOffFridge.Text = "OFF";
            // 
            // fridgeStatus
            // 
            this.fridgeStatus.BackColor = System.Drawing.Color.Transparent;
            this.fridgeStatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fridgeStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fridgeStatus.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.fridgeStatus.CheckedState.InnerColor = System.Drawing.Color.White;
            this.fridgeStatus.Location = new System.Drawing.Point(80, 2);
            this.fridgeStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fridgeStatus.Name = "fridgeStatus";
            this.fridgeStatus.Size = new System.Drawing.Size(41, 20);
            this.fridgeStatus.TabIndex = 3;
            this.fridgeStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.fridgeStatus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.fridgeStatus.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.fridgeStatus.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.fridgeStatus.CheckedChanged += new System.EventHandler(this.fridgeStatus_CheckedChanged);
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel4.Controls.Add(this.panel2);
            this.guna2GradientPanel4.Controls.Add(this.panel1);
            this.guna2GradientPanel4.Controls.Add(this.fridgeLabel);
            this.guna2GradientPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel4.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientPanel4.Location = new System.Drawing.Point(5, 5);
            this.guna2GradientPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Size = new System.Drawing.Size(153, 168);
            this.guna2GradientPanel4.TabIndex = 14;
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
            // fridgeLabel
            // 
            this.fridgeLabel.AutoSize = true;
            this.fridgeLabel.BackColor = System.Drawing.Color.Transparent;
            this.fridgeLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fridgeLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fridgeLabel.ForeColor = System.Drawing.Color.Black;
            this.fridgeLabel.Location = new System.Drawing.Point(0, 145);
            this.fridgeLabel.Name = "fridgeLabel";
            this.fridgeLabel.Size = new System.Drawing.Size(68, 23);
            this.fridgeLabel.TabIndex = 4;
            this.fridgeLabel.Text = "FRIDGE";
            // 
            // REFRIGERATORControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2GradientPanel4);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "REFRIGERATORControl";
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
        private System.Windows.Forms.Label onOffFridge;
        private Guna.UI2.WinForms.Guna2ToggleSwitch fridgeStatus;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label fridgeLabel;
    }
}
