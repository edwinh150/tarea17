using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLS;

namespace RegistroPelicula.RegistrosPelicula
{
    public partial class EliminarForm : Form
    {
        public EliminarForm()
        {
            InitializeComponent();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Peliculas peliculaC = new Peliculas();
            try
            {
                peliculaC.Peliculaid = Convert.ToInt32(BuscarEtextBox.Text);

                peliculaC.Eliminar();

                MessageBox.Show("Se Borro correctamente");

                BuscarEtextBox.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
