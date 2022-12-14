namespace Smart_Home.forms
{
    partial class ApartementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApartementForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kitchenName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kitchenPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.kitchenName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 58);
            this.panel1.TabIndex = 0;
            // 
            // kitchenName
            // 
            this.kitchenName.AutoSize = true;
            this.kitchenName.Dock = System.Windows.Forms.DockStyle.Top;
            this.kitchenName.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitchenName.ForeColor = System.Drawing.Color.White;
            this.kitchenName.Location = new System.Drawing.Point(0, 20);
            this.kitchenName.Name = "kitchenName";
            this.kitchenName.Size = new System.Drawing.Size(112, 30);
            this.kitchenName.TabIndex = 1;
            this.kitchenName.Text = "Kitchen";
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
            // kitchenPanel
            // 
            this.kitchenPanel.BackColor = System.Drawing.Color.Transparent;
            this.kitchenPanel.ColumnCount = 4;
            this.kitchenPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kitchenPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kitchenPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kitchenPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kitchenPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.kitchenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kitchenPanel.Location = new System.Drawing.Point(0, 58);
            this.kitchenPanel.Name = "kitchenPanel";
            this.kitchenPanel.Padding = new System.Windows.Forms.Padding(5);
            this.kitchenPanel.RowCount = 2;
            this.kitchenPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kitchenPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kitchenPanel.Size = new System.Drawing.Size(645, 476);
            this.kitchenPanel.TabIndex = 5;
            // 
            // ApartementForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.kitchenPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ApartementForm";
            this.Size = new System.Drawing.Size(645, 534);
            this.Load += new System.EventHandler(this.ApartementForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ApartementForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ApartementForm_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label kitchenName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel kitchenPanel;
    }
}
