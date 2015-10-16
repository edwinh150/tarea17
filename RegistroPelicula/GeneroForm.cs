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

namespace RegistroPelicula
{
    public partial class GeneroForm : Form
    {
        Generos Genero = new Generos();

        public GeneroForm()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            ConexionDb con = new ConexionDb();
            try
            { 
                Genero.Descripcion = DescripcionGenerotextBox.Text;

                Genero.Insertar();

                MessageBox.Show("Guardado Correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            GenerotextBox.Clear();
            DescripcionGenerotextBox.Clear();

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            GenerotextBox.Clear();
            DescripcionGenerotextBox.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Realmente desea borrarlo?", "Borrarando Archivo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Genero.GeneroId = Convert.ToInt32(GenerotextBox.Text);

                    Genero.Eliminar();

                    MessageBox.Show("Se Borro correctamente");
                    GenerotextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int idP = Convert.ToInt32(GenerotextBox.Text);

            DescripcionGenerotextBox.Text = Genero.Buscar(idP).ToString();
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea Modificarlo?", "Modificando Archivo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(GenerotextBox.Text);

                    Genero.Editar(id);

                    MessageBox.Show("Se Modifico correctamente");
                    GenerotextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
