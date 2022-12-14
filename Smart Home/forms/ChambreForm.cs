using Guna.UI2.WinForms;
using Smart_Home.Classes;
using Smart_Home.forms.UserControls;
using Smart_Home.Services;
using System;
using System.Windows.Forms;

namespace Smart_Home.forms
{
    public partial class ChambreForm : UserControl
    {
        public Chambre chambre = new Chambre();
       
        private FurnitureService furnitureService = new FurnitureService();

        public static Guna2ImageButton Guna2ImageButton { get; private set; }
        private ChambreService chambreService = new ChambreService();
        public ChambreForm()
        {
            InitializeComponent();
        }

        public void passChambre(int chambreId)
        {
            this.chambre = chambreService.findById(chambreId);
            loadObjet();
        }

        private void ChambreForm_Load(object sender, EventArgs e)
        {

        }

        public void changeName(string name)
        {
            chambreName.Text = "Bedroom of " + name;
        }

        private void ChambreForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void ChambreForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.Text).ToString() == "LAMB")
            {
                this.furnitureService.addObjet("LAMB", 1, this.chambre);
            }
            else if (e.Data.GetData(DataFormats.Text).ToString() == "AC")
            {

                this.furnitureService.addObjet("AC", 2, this.chambre);

            }
            else if (e.Data.GetData(DataFormats.Text).ToString() == "DOOR")
            {
                this.furnitureService.addObjet("DOOR", 3, this.chambre);
            }
            else if (e.Data.GetData(DataFormats.Text).ToString() == "WINDOW")
            {
                this.furnitureService.addObjet("WINDOW", 4, this.chambre);
            }
            else if (e.Data.GetData(DataFormats.Text).ToString() == "WASHING_MACHINE")
            {
                this.furnitureService.addObjet("WASHING_MACHINE", 5, this.chambre);
            }
            else if (e.Data.GetData(DataFormats.Text).ToString() == "REFRIGERATOR")
            {
                this.furnitureService.addObjet("REFRIGERATOR", 6, this.chambre);
            }
            else if (e.Data.GetData(DataFormats.Text).ToString() == "TV")
            {
                this.furnitureService.addObjet("TV", 7, this.chambre);
            }
            this.loadObjet();


        }

        private void loadObjet()
        {
            chambrePanel.Controls.Clear();
            int i = 0;
            foreach (Furniture f in this.furnitureService.findByChambreId(chambre.Id))
            {

                if (f.Type == "LAMB")
                {


                    LampControl lampControl = new LampControl(f);
                    lampControl.Dock = DockStyle.Fill;
                    chambrePanel.Controls.Add(lampControl);
                    chambrePanel.Controls.SetChildIndex(lampControl, i);
                    i++;

                }
                else if (f.Type == "AC")
                {


                    ACControl aCControl = new ACControl(f);
                    aCControl.Dock = DockStyle.Fill;
                    chambrePanel.Controls.Add(aCControl);
                    chambrePanel.Controls.SetChildIndex(aCControl, i);
                    i++;
                }
                else if (f.Type == "DOOR")
                {

                    DOORControl dOORControl = new DOORControl(f);
                    dOORControl.Dock = DockStyle.Fill;
                    chambrePanel.Controls.Add(dOORControl);
                    chambrePanel.Controls.SetChildIndex(dOORControl, i);
                    i++;
                }
                else if (f.Type == "WINDOW")
                {



                    WIndowControl wIndowControl = new WIndowControl(f);
                    wIndowControl.Dock = DockStyle.Fill;
                    chambrePanel.Controls.Add(wIndowControl);
                    chambrePanel.Controls.SetChildIndex(wIndowControl, i);

                    i++;


                }
                else if (f.Type == "WASHING_MACHINE")
                {


                    WMControl wMControl = new WMControl(f);
                    wMControl.Dock = DockStyle.Fill;
                    chambrePanel.Controls.Add(wMControl);
                    chambrePanel.Controls.SetChildIndex(wMControl, i);

                    i++;

                }
                else if (f.Type == "REFRIGERATOR")
                {


                    REFRIGERATORControl rEFRIGERATORControl = new REFRIGERATORControl(f);
                    rEFRIGERATORControl.Dock = DockStyle.Fill;
                    chambrePanel.Controls.Add(rEFRIGERATORControl);
                    chambrePanel.Controls.SetChildIndex(rEFRIGERATORControl, i);


                    i++;

                }
                else if (f.Type == "TV")
                {


                    TvControl tvControl = new TvControl(f);
                    tvControl.Dock = DockStyle.Fill;
                    chambrePanel.Controls.Add(tvControl);
                    chambrePanel.Controls.SetChildIndex(tvControl, i);

                    i++;
                }

            }

        }
    }
}
