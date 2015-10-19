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
            if (GeneroIdtextBox.Text.Length > 0)
            {
                if (MessageBox.Show("Realmente desea Modificarlo?", "Modificando Archivo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(GeneroIdtextBox.Text);

                        Genero.Descripcion = DescripcionGenerotextBox.Text;

                        Genero.Editar(id);

                        MessageBox.Show("Se Modifico correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
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
            }

            GeneroIdtextBox.Clear();
            DescripcionGenerotextBox.Clear();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            GeneroIdtextBox.Clear();
            DescripcionGenerotextBox.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Realmente desea borrarlo?", "Borrarando Archivo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Genero.GeneroId = Convert.ToInt32(GeneroIdtextBox.Text);

                    Genero.Eliminar();

                    MessageBox.Show("Se Borro correctamente");
                    GeneroIdtextBox.Clear();
                    DescripcionGenerotextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (GeneroIdtextBox.Text.Length > 0)
            {
                int idP = Convert.ToInt32(GeneroIdtextBox.Text);

                Genero.Buscar(idP);
                DescripcionGenerotextBox.Text = Genero.Descripcion.ToString();
            }
            else
            {
                MessageBox.Show("Primero ingrese un Id");
                GeneroIdtextBox.Clear();
            }

        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {

            
        }
    }
}
