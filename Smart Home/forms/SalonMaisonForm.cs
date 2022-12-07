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
    public partial class SalonMaisonForm : UserControl
    {
        public SalonMaisonForm()
        {
            InitializeComponent();
        }

        private void SalonMaisonForm_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("DROPED");

        }

        private void SalonMaisonForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}
