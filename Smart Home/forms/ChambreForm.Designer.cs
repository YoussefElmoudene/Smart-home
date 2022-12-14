namespace Smart_Home.forms
{
    partial class ChambreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChambreForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chambreName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chmabrePanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.chambreName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 69);
            this.panel1.TabIndex = 1;
            // 
            // chambreName
            // 
            this.chambreName.AutoSize = true;
            this.chambreName.Dock = System.Windows.Forms.DockStyle.Top;
            this.chambreName.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chambreName.ForeColor = System.Drawing.Color.White;
            this.chambreName.Location = new System.Drawing.Point(0, 20);
            this.chambreName.Name = "chambreName";
            this.chambreName.Size = new System.Drawing.Size(126, 30);
            this.chambreName.TabIndex = 1;
            this.chambreName.Text = "Bedroom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controlling";
            // 
            // chmabrePanel
            // 
            this.chmabrePanel.BackColor = System.Drawing.Color.Transparent;
            this.chmabrePanel.ColumnCount = 4;
            this.chmabrePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.chmabrePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.chmabrePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.chmabrePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.chmabrePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chmabrePanel.Location = new System.Drawing.Point(0, 69);
            this.chmabrePanel.Name = "chmabrePanel";
            this.chmabrePanel.RowCount = 2;
            this.chmabrePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chmabrePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chmabrePanel.Size = new System.Drawing.Size(645, 465);
            this.chmabrePanel.TabIndex = 4;
            // 
            // ChambreForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.chmabrePanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ChambreForm";
            this.Size = new System.Drawing.Size(645, 534);
            this.Load += new System.EventHandler(this.ChambreForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChambreForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ChambreForm_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label chambreName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel chmabrePanel;
    }
}
