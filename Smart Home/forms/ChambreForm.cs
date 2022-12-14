using Guna.UI2.WinForms;
using Smart_Home.Classes;
using Smart_Home.Services;
using System;
using System.Windows.Forms;

namespace Smart_Home.forms
{
    public partial class ChambreForm : UserControl
    {
        public Chambre chambre = new Chambre();

        public static Guna2ImageButton Guna2ImageButton { get; private set; }
        private ChambreService chambreService = new ChambreService();
        public ChambreForm()
        {
            InitializeComponent();
        }

        public void passChambre(int chambreId)
        {
            this.chambre = chambreService.findById(chambreId);
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
            MessageBox.Show(e.Data.GetData(DataFormats.Text).ToString());


        }
    }
}
