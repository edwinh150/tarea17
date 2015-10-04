using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLLS;


namespace RegistroPelicula.RegistrosPelicula
{
    public partial class ConsultarForm : Form
    {
        public ConsultarForm()
        {
            InitializeComponent();
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            ConexionDb con = new ConexionDb();

            try
            {
                ResultadodataGridView.DataSource = con.ObtenerDatos("Select * from PeliculasT");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            ConexionDb con = new ConexionDb();

            try
            {
                ResultadodataGridView.DataSource = con.ObtenerDatos("select Titulo, Descripcion, Ano, Calificacion, IMDB, CategoriaId from PeliculasT where  PeliculaId = " + Convert.ToInt32(ConsultartextBox.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
