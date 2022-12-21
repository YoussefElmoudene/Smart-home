using Smart_Home.Classes;
using Smart_Home.forms.UserControls;
using Smart_Home.Services;
using System;
using System.Windows.Forms;

namespace Smart_Home.forms
{
    public partial class SalonMaisonForm : UserControl
    {
        public Chambre chambre = new Chambre();
        private ChambreService chambreService = new ChambreService();
        private FurnitureService furnitureService = new FurnitureService();
        public SalonMaisonForm()
        {
            InitializeComponent();
        }

        public void passChambre(int chambreId)
        {
            this.chambre = chambreService.findById(chambreId);
            loadObjet();
        }

        private void SalonMaisonForm_DragDrop(object sender, DragEventArgs e)
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

        private void SalonMaisonForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void loadObjet()
        {
            SalonPanel.Controls.Clear();
            int i = 0;
            foreach (Furniture f in this.furnitureService.findByChambreId(chambre.Id))
            {

                if (f.Type == "LAMB")
                {


                    LampControl lampControl = new LampControl(f);
                    lampControl.Dock = DockStyle.Fill;
                    SalonPanel.Controls.Add(lampControl);
                    SalonPanel.Controls.SetChildIndex(lampControl, i);
                    i++;

                }
                else if (f.Type == "AC")
                {


                    ACControl aCControl = new ACControl(f);
                    aCControl.Dock = DockStyle.Fill;
                    SalonPanel.Controls.Add(aCControl);
                    SalonPanel.Controls.SetChildIndex(aCControl, i);
                    i++;
                }
                else if (f.Type == "DOOR")
                {

                    DOORControl dOORControl = new DOORControl(f);
                    dOORControl.Dock = DockStyle.Fill;
                    SalonPanel.Controls.Add(dOORControl);
                    SalonPanel.Controls.SetChildIndex(dOORControl, i);
                    i++;
                }
                else if (f.Type == "WINDOW")
                {



                    WIndowControl wIndowControl = new WIndowControl(f);
                    wIndowControl.Dock = DockStyle.Fill;
                    SalonPanel.Controls.Add(wIndowControl);
                    SalonPanel.Controls.SetChildIndex(wIndowControl, i);

                    i++;


                }
                else if (f.Type == "WASHING_MACHINE")
                {


                    WMControl wMControl = new WMControl(f);
                    wMControl.Dock = DockStyle.Fill;
                    SalonPanel.Controls.Add(wMControl);
                    SalonPanel.Controls.SetChildIndex(wMControl, i);

                    i++;

                }
                else if (f.Type == "REFRIGERATOR")
                {


                    REFRIGERATORControl rEFRIGERATORControl = new REFRIGERATORControl(f);
                    rEFRIGERATORControl.Dock = DockStyle.Fill;
                    SalonPanel.Controls.Add(rEFRIGERATORControl);
                    SalonPanel.Controls.SetChildIndex(rEFRIGERATORControl, i);


                    i++;

                }
                else if (f.Type == "TV")
                {


                    TvControl tvControl = new TvControl(f);
                    tvControl.Dock = DockStyle.Fill;
                    SalonPanel.Controls.Add(tvControl);
                    SalonPanel.Controls.SetChildIndex(tvControl, i);

                    i++;
                }

            }

        }
    }
}
