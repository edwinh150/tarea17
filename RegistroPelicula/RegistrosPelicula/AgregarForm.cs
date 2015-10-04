using BLL;
using DAL;
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
            ConexionDb con = new ConexionDb();

            try
            {
                //PeliculaIdtextBox.Text = con.ObtenerDatos("Select * from PeliculasT");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Peliculas peliculaC = new Peliculas();
            try
            { 
                peliculaC.Titulo = TitulotextBox.Text;

                peliculaC.Descripcion = DescripciontextBox.Text;

                peliculaC.Ano = Convert.ToInt32(AnotextBox.Text);

                peliculaC.Calificacion = Convert.ToInt32(CalificaciontextBox.Text);

                peliculaC.IMDB = Convert.ToInt32(IMDBtextBox.Text);

                peliculaC.CategoriaId = Convert.ToInt32(CategoriaIdtextBox.Text);

                peliculaC.Insertar();

                MessageBox.Show("Se guardo correctamente");

                TitulotextBox.Clear();
                DescripciontextBox.Clear();
                AnotextBox.Clear();
                CalificaciontextBox.Clear();
                IMDBtextBox.Clear();
                CategoriaIdtextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limpiarbutton_Click(object sender, EventArgs e)
        {
            TitulotextBox.Clear();
            DescripciontextBox.Clear();
            AnotextBox.Clear();
            CalificaciontextBox.Clear();
            IMDBtextBox.Clear();
            CategoriaIdtextBox.Clear();
        }
    }
}
