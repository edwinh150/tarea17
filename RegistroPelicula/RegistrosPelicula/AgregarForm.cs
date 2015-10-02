using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroPelicula.RegistrosPelicula
{
    public partial class AgregarForm : Form
    {
        public AgregarForm()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Peliculas peliculaC = new Peliculas();

            PeliculaIdtextBox.Text = Convert.ToString(peliculaC.PeliculaId);

            peliculaC.Titulo = TitulotextBox.Text;

            peliculaC.Descripcion = DescripciontextBox.Text;

            peliculaC.Ano = Convert.ToInt32(AnotextBox.Text);

            peliculaC.Calificacion = Convert.ToInt32(CalificaciontextBox.Text);

            peliculaC.IMDB = Convert.ToInt32(IMDBtextBox.Text);

            peliculaC.CategoriaId = Convert.ToInt32(CategoriaIdtextBox.Text);

            peliculaC.Insertar();
        }
    }
}
