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
    public partial class ChambreForm : UserControl
    {
        public ChambreForm()
        {
            InitializeComponent();
        }

        private void ChambreForm_Load(object sender, EventArgs e)
        {

        }

        private void ChambreForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void ChambreForm_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("DROPPED");

        }
    }
}
