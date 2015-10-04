using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPelicula.RegistrosPelicula;

namespace RegistroPelicula
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarForm agre = new AgregarForm();
            agre.MdiParent = this;
            agre.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarForm consul = new ConsultarForm();
            consul.MdiParent = this;
            consul.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarForm mod = new ModificarForm();
            mod.MdiParent = this;
            mod.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarForm eli = new EliminarForm();
            eli.MdiParent = this;
            eli.Show();
        }
    }
}
