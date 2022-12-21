using Smart_Home.Classes;
using Smart_Home.forms.UserControls;
using Smart_Home.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Home.forms
{
    public partial class ToiletteForm : UserControl
    {

        public Chambre chambre = new Chambre();
        private ChambreService chambreService = new ChambreService();
        private FurnitureService furnitureService = new FurnitureService();
        public ToiletteForm()
        {
            InitializeComponent();

        }

        public void passChambre(int chambreId)
        {
            this.chambre = chambreService.findById(chambreId);
            loadObjet();
        }

        private void ToiletteControl_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void ToiletteControl_DragDrop(object sender, DragEventArgs e)
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

        public void changeName(string name)
        {
            toiletteName.Text = "Bathroom of " + name;
        }

        private void loadObjet()
        {
            ToilettePanel.Controls.Clear();
            int i = 0;
            foreach (Furniture f in this.furnitureService.findByChambreId(chambre.Id))
            {

                if (f.Type == "LAMB")
                {


                    LampControl lampControl = new LampControl(f);
                    lampControl.Dock = DockStyle.Fill;
                    ToilettePanel.Controls.Add(lampControl);
                    ToilettePanel.Controls.SetChildIndex(lampControl, i);
                    i++;

                }
                else if (f.Type == "AC")
                {


                    ACControl aCControl = new ACControl(f);
                    aCControl.Dock = DockStyle.Fill;
                    ToilettePanel.Controls.Add(aCControl);
                    ToilettePanel.Controls.SetChildIndex(aCControl, i);
                    i++;
                }
                else if (f.Type == "DOOR")
                {

                    DOORControl dOORControl = new DOORControl(f);
                    dOORControl.Dock = DockStyle.Fill;
                    ToilettePanel.Controls.Add(dOORControl);
                    ToilettePanel.Controls.SetChildIndex(dOORControl, i);
                    i++;
                }
                else if (f.Type == "WINDOW")
                {



                    WIndowControl wIndowControl = new WIndowControl(f);
                    wIndowControl.Dock = DockStyle.Fill;
                    ToilettePanel.Controls.Add(wIndowControl);
                    ToilettePanel.Controls.SetChildIndex(wIndowControl, i);

                    i++;


                }
                else if (f.Type == "WASHING_MACHINE")
                {


                    WMControl wMControl = new WMControl(f);
                    wMControl.Dock = DockStyle.Fill;
                    ToilettePanel.Controls.Add(wMControl);
                    ToilettePanel.Controls.SetChildIndex(wMControl, i);

                    i++;

                }
                else if (f.Type == "REFRIGERATOR")
                {


                    REFRIGERATORControl rEFRIGERATORControl = new REFRIGERATORControl(f);
                    rEFRIGERATORControl.Dock = DockStyle.Fill;
                    ToilettePanel.Controls.Add(rEFRIGERATORControl);
                    ToilettePanel.Controls.SetChildIndex(rEFRIGERATORControl, i);


                    i++;

                }
                else if (f.Type == "TV")
                {


                    TvControl tvControl = new TvControl(f);
                    tvControl.Dock = DockStyle.Fill;
                    ToilettePanel.Controls.Add(tvControl);
                    ToilettePanel.Controls.SetChildIndex(tvControl, i);

                    i++;
                }

            }

        }
    }
}
