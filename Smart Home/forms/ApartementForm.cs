using MySqlConnector;
using Smart_Home.Connextion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Smart_Home.forms
{
    public partial class ApartementForm : UserControl
    {
        public ApartementForm()
        {
            InitializeComponent();
            loadObjet();
        }

        private void ApartementForm_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("DROPED");
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
