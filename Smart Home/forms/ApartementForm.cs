using MySqlConnector;
using Smart_Home.Classes;
using Smart_Home.Connextion;
using Smart_Home.Services;
using System;
using System.Windows.Forms;

namespace Smart_Home.forms
{
    public partial class ApartementForm : UserControl
    {
        public Chambre chambre = new Chambre();
        private ChambreService chambreService = new ChambreService();
        public ApartementForm()
        {
            InitializeComponent();
            loadObjet();
        }


        public void passChambre(int chambreId)
        {
            this.chambre = chambreService.findById(chambreId);
        }

        private void ApartementForm_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show(e.Data.GetData(DataFormats.Text).ToString());
        }

        private void ApartementForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void ApartementForm_Load(object sender, EventArgs e)
        {

        }


        private void loadObjet()
        {
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();
            cmd.CommandText = "SELECT *  FROM user WHERE username";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

        }
    }
}
