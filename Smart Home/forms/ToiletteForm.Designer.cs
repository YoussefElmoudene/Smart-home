namespace Smart_Home.forms
{
    partial class ToiletteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToiletteForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toiletteName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToilettePanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.toiletteName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 67);
            this.panel1.TabIndex = 1;
            // 
            // toiletteName
            // 
            this.toiletteName.AutoSize = true;
            this.toiletteName.Dock = System.Windows.Forms.DockStyle.Top;
            this.toiletteName.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toiletteName.ForeColor = System.Drawing.Color.White;
            this.toiletteName.Location = new System.Drawing.Point(0, 24);
            this.toiletteName.Name = "toiletteName";
            this.toiletteName.Size = new System.Drawing.Size(147, 30);
            this.toiletteName.TabIndex = 1;
            this.toiletteName.Text = "BathRoom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controlling";
            // 
            // ToilettePanel
            // 
            this.ToilettePanel.BackColor = System.Drawing.Color.Transparent;
            this.ToilettePanel.ColumnCount = 4;
            this.ToilettePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ToilettePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ToilettePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ToilettePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ToilettePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToilettePanel.Location = new System.Drawing.Point(0, 67);
            this.ToilettePanel.Name = "ToilettePanel";
            this.ToilettePanel.RowCount = 2;
            this.ToilettePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ToilettePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ToilettePanel.Size = new System.Drawing.Size(687, 369);
            this.ToilettePanel.TabIndex = 4;
            // 
            // ToiletteForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.ToilettePanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ToiletteForm";
            this.Size = new System.Drawing.Size(687, 436);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ToiletteControl_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ToiletteControl_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label toiletteName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel ToilettePanel;
    }
}
