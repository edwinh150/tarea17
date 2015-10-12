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
        public ReproducirForm()
        {
            InitializeComponent();
        }

        private void Playbutton_Click(object sender, EventArgs e)
        {
            PeliculasaxWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void Pausebutton_Click(object sender, EventArgs e)
        {
            PeliculasaxWindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            PeliculasaxWindowsMediaPlayer.Ctlcontrols.stop();
        }
    }
}
