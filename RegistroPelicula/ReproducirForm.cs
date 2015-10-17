using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroPelicula
{
    public partial class ReproducirForm : Form
    {
        MainForm mn = new MainForm();

        public ReproducirForm()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            ReproductoraxWindowsMediaPlayer.URL = mn.ruta;
        }
    }
}
