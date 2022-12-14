namespace Smart_Home.forms
{
    partial class AddApartementForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AnullerButton = new Guna.UI2.WinForms.Guna2Button();
            this.nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.largeur = new Guna.UI2.WinForms.Guna2TextBox();
            this.hauteur = new Guna.UI2.WinForms.Guna2TextBox();
            this.adminCombo = new System.Windows.Forms.ComboBox();
            this.AjouterButton = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AnullerButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.largeur, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.hauteur, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.adminCombo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AjouterButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 466);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AnullerButton
            // 
            this.AnullerButton.AllowDrop = true;
            this.AnullerButton.BorderRadius = 5;
            this.AnullerButton.BorderThickness = 1;
            this.AnullerButton.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AnullerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AnullerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AnullerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AnullerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AnullerButton.FillColor = System.Drawing.SystemColors.Control;
            this.AnullerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AnullerButton.ForeColor = System.Drawing.Color.Black;
            this.AnullerButton.Location = new System.Drawing.Point(3, 312);
            this.AnullerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnullerButton.Name = "AnullerButton";
            this.AnullerButton.Size = new System.Drawing.Size(208, 46);
            this.AnullerButton.TabIndex = 10;
            this.AnullerButton.Text = "Anuller";
            this.AnullerButton.Click += new System.EventHandler(this.AnullerButton_Click);
            // 
            // nom
            // 
            this.nom.Animated = true;
            this.nom.BackColor = System.Drawing.SystemColors.Control;
            this.nom.BorderColor = System.Drawing.Color.Transparent;
            this.nom.BorderRadius = 6;
            this.nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom.DefaultText = "";
            this.nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.FillColor = System.Drawing.SystemColors.Control;
            this.nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.Location = new System.Drawing.Point(4, 4);
            this.nom.Margin = new System.Windows.Forms.Padding(4);
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.nom.PlaceholderText = "Nom d\'appartement";
            this.nom.SelectedText = "";
            this.nom.Size = new System.Drawing.Size(335, 44);
            this.nom.TabIndex = 3;
            // 
            // largeur
            // 
            this.largeur.Animated = true;
            this.largeur.BackColor = System.Drawing.SystemColors.Control;
            this.largeur.BorderColor = System.Drawing.Color.Transparent;
            this.largeur.BorderRadius = 6;
            this.largeur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.largeur.DefaultText = "";
            this.largeur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.largeur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.largeur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.largeur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.largeur.FillColor = System.Drawing.SystemColors.Control;
            this.largeur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.largeur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.largeur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.largeur.Location = new System.Drawing.Point(417, 4);
            this.largeur.Margin = new System.Windows.Forms.Padding(4);
            this.largeur.Name = "largeur";
            this.largeur.PasswordChar = '\0';
            this.largeur.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.largeur.PlaceholderText = "Largeur";
            this.largeur.SelectedText = "";
            this.largeur.Size = new System.Drawing.Size(335, 44);
            this.largeur.TabIndex = 4;
            // 
            // hauteur
            // 
            this.hauteur.Animated = true;
            this.hauteur.BackColor = System.Drawing.SystemColors.Control;
            this.hauteur.BorderColor = System.Drawing.Color.Transparent;
            this.hauteur.BorderRadius = 6;
            this.hauteur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hauteur.DefaultText = "";
            this.hauteur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hauteur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hauteur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hauteur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hauteur.FillColor = System.Drawing.SystemColors.Control;
            this.hauteur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hauteur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hauteur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hauteur.Location = new System.Drawing.Point(4, 159);
            this.hauteur.Margin = new System.Windows.Forms.Padding(4);
            this.hauteur.Name = "hauteur";
            this.hauteur.PasswordChar = '\0';
            this.hauteur.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.hauteur.PlaceholderText = "Hauteur";
            this.hauteur.SelectedText = "";
            this.hauteur.Size = new System.Drawing.Size(335, 44);
            this.hauteur.TabIndex = 5;
            // 
            // adminCombo
            // 
            this.adminCombo.BackColor = System.Drawing.SystemColors.Control;
            this.adminCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.adminCombo.FormattingEnabled = true;
            this.adminCombo.Location = new System.Drawing.Point(416, 158);
            this.adminCombo.Name = "adminCombo";
            this.adminCombo.Size = new System.Drawing.Size(318, 28);
            this.adminCombo.TabIndex = 8;
            // 
            // AjouterButton
            // 
            this.AjouterButton.AllowDrop = true;
            this.AjouterButton.BorderRadius = 5;
            this.AjouterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AjouterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AjouterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AjouterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AjouterButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AjouterButton.ForeColor = System.Drawing.Color.White;
            this.AjouterButton.Location = new System.Drawing.Point(416, 312);
            this.AjouterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AjouterButton.Name = "AjouterButton";
            this.AjouterButton.Size = new System.Drawing.Size(208, 46);
            this.AjouterButton.TabIndex = 11;
            this.AjouterButton.Text = "Ajouter";
            this.AjouterButton.Click += new System.EventHandler(this.AjouterButton_Click);
            // 
            // AddApartementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 476);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddApartementForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter appartement";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox nom;
        private Guna.UI2.WinForms.Guna2TextBox largeur;
        private Guna.UI2.WinForms.Guna2TextBox hauteur;
        private System.Windows.Forms.ComboBox adminCombo;
        private Guna.UI2.WinForms.Guna2Button AnullerButton;
        private Guna.UI2.WinForms.Guna2Button AjouterButton;
    }
}