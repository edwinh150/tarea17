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
using DAL;

namespace RegistroPelicula
{
    public partial class EstudioForm : Form
    {
        Estudios estudio = new Estudios();

        public EstudioForm()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            EstudiosIdtextBox.Clear();
            NombreEstudiotextBox.Clear();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (EstudiosIdtextBox.Text.Length > 0)
            {
                int id = Convert.ToInt32(EstudiosIdtextBox.Text);

                estudio.Buscar(id);
                NombreEstudiotextBox.Text = estudio.NombreEstudio.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese primero un Id");
                EstudiosIdtextBox.Clear();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea borrarlo?", "Borrarando Archivo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    estudio.EstudiosId = Convert.ToInt32(EstudiosIdtextBox.Text);

                    estudio.Eliminar();

                    MessageBox.Show("Se Borro correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            EstudiosIdtextBox.Clear();
            NombreEstudiotextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            ConexionDb con = new ConexionDb();
            if (EstudiosIdtextBox.Text.Length > 0)
            {
                if (MessageBox.Show("Realmente desea Modificarlo?", "Modificando Archivo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(EstudiosIdtextBox.Text);

                        estudio.NombreEstudio = NombreEstudiotextBox.Text;

                        estudio.Editar(id);

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
                    estudio.NombreEstudio = NombreEstudiotextBox.Text;

                    estudio.Insertar();

                    MessageBox.Show("Se Guardo correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            EstudiosIdtextBox.Clear();
            NombreEstudiotextBox.Clear();
        }
    }
}
