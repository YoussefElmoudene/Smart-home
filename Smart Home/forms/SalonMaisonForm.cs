using Smart_Home.Classes;
using Smart_Home.Services;
using System;
using System.Windows.Forms;

namespace Smart_Home.forms
{
    public partial class SalonMaisonForm : UserControl
    {
        public Chambre chambre = new Chambre();
        private ChambreService chambreService = new ChambreService();
        public SalonMaisonForm()
        {
            InitializeComponent();
        }

        public void passChambre(int chambreId)
        {
            this.chambre = chambreService.findById(chambreId);
        }

        private void SalonMaisonForm_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show(e.Data.GetData(DataFormats.Text).ToString());

        }

        private void SalonMaisonForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}
