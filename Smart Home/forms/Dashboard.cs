using Guna.UI2.WinForms;
using MySqlConnector;
using Smart_Home.Classes;
using Smart_Home.Connextion;
using Smart_Home.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Smart_Home.forms
{
    public partial class Dashboard : Form
    {
        public User user = new User();
        public UserService userService = new UserService();
        public AppartementService appartementService = new AppartementService();
        public Appartement appartement = new Appartement();
        public int selectedAdminId;
        public Dashboard(User user)
        {
            this.user = user;
            InitializeComponent();
            this.onInit();
        }

        private void onInit()
        {
            adminLabel.Text = user.Fullname;
            if (this.user.Role.Equals("TECHNICIEN"))
            {
                AddApartement.Visible = true;
                AddChambre.Visible = true;
                AddUser.Visible = true;
            } else if (this.user.Role.Equals("ADMIN"))
            {
                this.appartement = this.appartementService.findByAdminId(this.user.Id);
                this.getAppartementChambre();
                nomApartement.Visible = true;
                contacterTechnicienLabel.Visible = true;
                allowTechnicien.Visible = true;
                allowTechnicien.Checked = false;
                nomApartement.Text = this.appartement.Name;
                this.appartementService.allowTechnicien(false, this.appartement.Id);
            } else if (this.user.Role.Equals("UTILISATEUR"))
            {
                this.getChambreOfUser();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }



        private void guna2ImageButton1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void guna2ImageButton1_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2ImageButton g = (Guna2ImageButton)sender;
            g.Select();
            g.DoDragDrop(g.Name, DragDropEffects.Copy);
        }



        private void guna2ImageButton3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void guna2ImageButton3_MouseDown_1(object sender, MouseEventArgs e)
        {
            Guna2ImageButton g1 = (Guna2ImageButton)sender;
            g1.Select();
            g1.DoDragDrop(g1.Name, DragDropEffects.Copy);
        }

        private void guna2ImageButton4_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2ImageButton g1 = (Guna2ImageButton)sender;
            g1.Select();
            g1.DoDragDrop(g1.Name, DragDropEffects.Copy);
        }

        private void guna2ImageButton4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void guna2ImageButton5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void guna2ImageButton5_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2ImageButton g1 = (Guna2ImageButton)sender;
            g1.Select();
            g1.DoDragDrop(g1.Name, DragDropEffects.Copy);
        }

        private void guna2ImageButton6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void guna2ImageButton6_MouseDown(object sender, MouseEventArgs e)
        {

            Guna2ImageButton g1 = (Guna2ImageButton)sender;
            g1.Select();
            g1.DoDragDrop(g1.Name, DragDropEffects.Copy);
        }

        private void guna2ImageButton7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void guna2ImageButton7_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2ImageButton g1 = (Guna2ImageButton)sender;
            g1.Select();
            g1.DoDragDrop(g1.Name, DragDropEffects.Copy);
        }

        private void guna2ImageButton8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void guna2ImageButton8_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2ImageButton g1 = (Guna2ImageButton)sender;
            g1.Select();
            g1.DoDragDrop(g1.Name, DragDropEffects.Copy);
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void AddChambre_Click(object sender, EventArgs e)
        {
            AddChambreForm addChambreForm = new AddChambreForm(this.appartement);
            addChambreForm.FormClosing += new FormClosingEventHandler(this.AddChambreForm_FormClosing);
            addChambreForm.Show();
        }

        private void AddApartement_Click(object sender, EventArgs e)
        {
            AddApartementForm addApartementForm = new AddApartementForm();
            addApartementForm.technicien = this.user;
            addApartementForm.FormClosing += new FormClosingEventHandler(this.AddApartementForm_FormClosing);
            addApartementForm.Show();
        }

        private void AddChambreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.getAppartementChambre();

        }

        private void getChambreOfUser()
        {
            DataTable dt = new DataTable();

            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();
            cmd.CommandText = "SELECT id,  `type`, `userId` FROM `chambre` WHERE userId = " + this.user.Id;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            List<string> data = new List<string>();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DashbordPanel.Controls.Clear();
                int i = 0;
                foreach (DataRow dataRow in dt.Rows)
                {

                    if (dataRow[1].ToString() == "SALON")
                    {
                        SalonMaisonForm salonMaisonForm = new SalonMaisonForm();
                        salonMaisonForm.passChambre(Convert.ToInt16(dataRow[0]));
                        salonMaisonForm.Dock = DockStyle.Fill;

                        DashbordPanel.Controls.Add(salonMaisonForm);
                        DashbordPanel.Controls.SetChildIndex(salonMaisonForm, i);
                        i++;
                    }
                    else if (dataRow[1].ToString() == "KITCHEN")
                    {
                        ApartementForm apartementForm = new ApartementForm();
                        apartementForm.Dock = DockStyle.Fill;
                        apartementForm.passChambre(Convert.ToInt16(dataRow[0]));
                        DashbordPanel.Controls.Add(apartementForm);
                        DashbordPanel.Controls.SetChildIndex(apartementForm, i);
                        i++;
                    }
                    else if (dataRow[1].ToString() == "BEDROOM")
                    {
                        ChambreForm chambreForm = new ChambreForm();
                        chambreForm.Dock = DockStyle.Fill;
                        chambreForm.passChambre(Convert.ToInt16(dataRow[0]));
                        chambreForm.changeName(this.userService.findById(Convert.ToInt16(dataRow[2])).Fullname);
                        DashbordPanel.Controls.Add(chambreForm);
                        DashbordPanel.Controls.SetChildIndex(chambreForm, i);
                        i++;
                    }
                    else if (dataRow[1].ToString() == "BATHROOM")
                    {
                        ToiletteForm toiletteControl = new ToiletteForm();
                        toiletteControl.Dock = DockStyle.Fill;
                        toiletteControl.passChambre(Convert.ToInt16(dataRow[0]));
                        DashbordPanel.Controls.Add(toiletteControl);
                        DashbordPanel.Controls.SetChildIndex(toiletteControl, i);
                        i++;
                    }
                }
            }

        }
        private void getAppartementChambre()
        {
            DataTable dt = new DataTable();

            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();
            cmd.CommandText = "SELECT id,  `type`, `userId` FROM `chambre` WHERE appartementId = " + this.appartement.Id;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            List<string> data = new List<string>();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DashbordPanel.Controls.Clear();
                int i = 0;
                foreach (DataRow dataRow in dt.Rows)
                {

                    if (dataRow[1].ToString() == "SALON")
                    {
                        SalonMaisonForm salonMaisonForm = new SalonMaisonForm();
                        salonMaisonForm.passChambre(Convert.ToInt16(dataRow[0]));
                        salonMaisonForm.Dock = DockStyle.Fill;

                        DashbordPanel.Controls.Add(salonMaisonForm);
                        DashbordPanel.Controls.SetChildIndex(salonMaisonForm, i);
                        i++;
                    }
                    else if (dataRow[1].ToString() == "KITCHEN")
                    {
                        ApartementForm apartementForm = new ApartementForm();
                        apartementForm.Dock = DockStyle.Fill;
                        apartementForm.passChambre(Convert.ToInt16(dataRow[0]));
                        DashbordPanel.Controls.Add(apartementForm);
                        DashbordPanel.Controls.SetChildIndex(apartementForm, i);
                        i++;
                    }
                    else if (dataRow[1].ToString() == "BEDROOM")
                    {
                        ChambreForm chambreForm = new ChambreForm();
                        chambreForm.Dock = DockStyle.Fill;
                        chambreForm.passChambre(Convert.ToInt16(dataRow[0]));
                        chambreForm.changeName(this.userService.findById(Convert.ToInt16(dataRow[2])).Fullname);
                        DashbordPanel.Controls.Add(chambreForm);
                        DashbordPanel.Controls.SetChildIndex(chambreForm, i);
                        i++;
                    }
                    else if (dataRow[1].ToString() == "BATHROOM")
                    {
                        
                        ToiletteForm toiletteControl = new ToiletteForm();
                        toiletteControl.Dock = DockStyle.Fill;
                        toiletteControl.passChambre(Convert.ToInt16(dataRow[0]));
                        DashbordPanel.Controls.Add(toiletteControl);
                        DashbordPanel.Controls.SetChildIndex(toiletteControl, i);
                        i++;
                    }
                }
            }

        }

        private void AddApartementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataTable dt = new DataTable();

            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();
            cmd.CommandText = "SELECT * FROM `appartement` order by id desc limit 1;";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            List<string> data = new List<string>();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                {
                    if (dataRow[6].ToString() == "True")
                    {
                        nomApartement.Text = dataRow[1].ToString();
                        nomApartement.Visible = true;
                        newApartementPanel.Visible = false;
                        this.appartement = new Appartement(Convert.ToInt32(dataRow[0]),
                            dataRow[1].ToString(), Convert.ToDouble(dataRow[2]),
                            Convert.ToDouble(dataRow[3]),
                            userService.findById(Convert.ToInt16(dataRow[4])),
                            userService.findById(this.user.Id),
                          Convert.ToBoolean(dataRow[6]),
                          Convert.ToDouble(dataRow[7])
                            );
                       

                    }
                }
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void allowTechnicien_CheckedChanged(object sender, EventArgs e)
        {
            if (allowTechnicien.Checked)
            {
                appartementService.allowTechnicien(true, this.appartement.Id);
            } else
            {
                appartementService.allowTechnicien(false, this.appartement.Id);
            }
        }


      

        private void guna2ImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }
    }
}

