namespace Smart_Home.forms
{
    partial class SalonMaisonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalonMaisonForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.salonName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.salonName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 51);
            this.panel1.TabIndex = 2;
            // 
            // salonName
            // 
            this.salonName.AutoSize = true;
            this.salonName.Dock = System.Windows.Forms.DockStyle.Top;
            this.salonName.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salonName.ForeColor = System.Drawing.Color.White;
            this.salonName.Location = new System.Drawing.Point(0, 18);
            this.salonName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salonName.Name = "salonName";
            this.salonName.Size = new System.Drawing.Size(70, 25);
            this.salonName.TabIndex = 1;
            this.salonName.Text = "Salon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controlling";
            // 
            // SalonPanel
            // 
            this.SalonPanel.BackColor = System.Drawing.Color.Transparent;
            this.SalonPanel.ColumnCount = 4;
            this.SalonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SalonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SalonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SalonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SalonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalonPanel.Location = new System.Drawing.Point(0, 51);
            this.SalonPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SalonPanel.Name = "SalonPanel";
            this.SalonPanel.RowCount = 2;
            this.SalonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SalonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SalonPanel.Size = new System.Drawing.Size(484, 383);
            this.SalonPanel.TabIndex = 3;
            // 
            // SalonMaisonForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.SalonPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SalonMaisonForm";
            this.Size = new System.Drawing.Size(484, 434);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SalonMaisonForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SalonMaisonForm_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label salonName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel SalonPanel;
    }
}
