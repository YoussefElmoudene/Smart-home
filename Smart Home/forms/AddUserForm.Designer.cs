namespace Smart_Home.forms
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AnullerButton = new Guna.UI2.WinForms.Guna2Button();
            this.age = new Guna.UI2.WinForms.Guna2TextBox();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.telephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.fullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.role = new System.Windows.Forms.ComboBox();
            this.AddUserButon = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.guna2CircleButton1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.guna2CircleButton1, "guna2CircleButton1");
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Red;
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.AnullerButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.age, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.telephone, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.username, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fullname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.role, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AddUserButon, 1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            resources.ApplyResources(this.AnullerButton, "AnullerButton");
            this.AnullerButton.ForeColor = System.Drawing.Color.Black;
            this.AnullerButton.Name = "AnullerButton";
            this.AnullerButton.Click += new System.EventHandler(this.AnullerButton_Click);
            // 
            // age
            // 
            this.age.Animated = true;
            this.age.BackColor = System.Drawing.SystemColors.Control;
            this.age.BorderColor = System.Drawing.Color.Transparent;
            this.age.BorderRadius = 6;
            this.age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.age.DefaultText = "";
            this.age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.age.FillColor = System.Drawing.SystemColors.Control;
            this.age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.age, "age");
            this.age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.age.Name = "age";
            this.age.PasswordChar = '\0';
            this.age.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.age.PlaceholderText = "Age";
            this.age.SelectedText = "";
            // 
            // password
            // 
            this.password.Animated = true;
            this.password.BackColor = System.Drawing.SystemColors.Control;
            this.password.BorderColor = System.Drawing.Color.Transparent;
            this.password.BorderRadius = 6;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FillColor = System.Drawing.SystemColors.Control;
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.password, "password");
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.password.PlaceholderText = "Password";
            this.password.SelectedText = "";
            this.password.UseSystemPasswordChar = true;
            // 
            // telephone
            // 
            this.telephone.Animated = true;
            this.telephone.BackColor = System.Drawing.SystemColors.Control;
            this.telephone.BorderColor = System.Drawing.Color.Transparent;
            this.telephone.BorderRadius = 6;
            this.telephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telephone.DefaultText = "";
            this.telephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.telephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.telephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.telephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.telephone.FillColor = System.Drawing.SystemColors.Control;
            this.telephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.telephone, "telephone");
            this.telephone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.telephone.Name = "telephone";
            this.telephone.PasswordChar = '\0';
            this.telephone.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.telephone.PlaceholderText = "telephone";
            this.telephone.SelectedText = "";
            // 
            // username
            // 
            this.username.Animated = true;
            this.username.BackColor = System.Drawing.SystemColors.Control;
            this.username.BorderColor = System.Drawing.Color.Transparent;
            this.username.BorderRadius = 6;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FillColor = System.Drawing.SystemColors.Control;
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.username, "username");
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.username.PlaceholderText = "Username";
            this.username.SelectedText = "";
            // 
            // fullname
            // 
            this.fullname.Animated = true;
            this.fullname.BackColor = System.Drawing.SystemColors.Control;
            this.fullname.BorderColor = System.Drawing.Color.Transparent;
            this.fullname.BorderRadius = 6;
            this.fullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullname.DefaultText = "";
            this.fullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullname.FillColor = System.Drawing.SystemColors.Control;
            this.fullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.fullname, "fullname");
            this.fullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullname.Name = "fullname";
            this.fullname.PasswordChar = '\0';
            this.fullname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.fullname.PlaceholderText = "Nom complet";
            this.fullname.SelectedText = "";
            // 
            // role
            // 
            this.role.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.role, "role");
            this.role.FormattingEnabled = true;
            this.role.Name = "role";
            // 
            // AddUserButon
            // 
            this.AddUserButon.AllowDrop = true;
            this.AddUserButon.BorderRadius = 5;
            this.AddUserButon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddUserButon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddUserButon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddUserButon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.AddUserButon, "AddUserButon");
            this.AddUserButon.ForeColor = System.Drawing.Color.White;
            this.AddUserButon.Name = "AddUserButon";
            this.AddUserButon.Click += new System.EventHandler(this.AddUserButon_Click);
            // 
            // AddUserForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox fullname;
        private Guna.UI2.WinForms.Guna2TextBox age;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2TextBox telephone;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Button AnullerButton;
        private Guna.UI2.WinForms.Guna2Button AddUserButon;
    }
}