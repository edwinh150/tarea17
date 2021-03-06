﻿using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace RegistroPelicula
{
    public partial class ActorForm : Form
    {
        Actores Autor = new Actores();

        public ActorForm()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            ConexionDb con = new ConexionDb();
            if (AutoresIdtextBox.Text.Length > 0)
            {
                if (MessageBox.Show("Realmente desea Modificarlo?", "Modificando Archivo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(AutoresIdtextBox.Text);

                        Autor.NombreAutores = NombreAutorestextBox.Text;

                        Autor.Editar(id);

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
                    Autor.NombreAutores = NombreAutorestextBox.Text;

                    Autor.Insertar();

                    MessageBox.Show("Se Guardo correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            AutoresIdtextBox.Clear();
            NombreAutorestextBox.Clear();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            AutoresIdtextBox.Clear();
            NombreAutorestextBox.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea borrarlo?", "Borrarando Archivo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Autor.ActoreId = Convert.ToInt32(AutoresIdtextBox.Text);

                    Autor.Eliminar();

                    MessageBox.Show("Se Borro correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            AutoresIdtextBox.Clear();
            NombreAutorestextBox.Clear();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (AutoresIdtextBox.Text.Length > 0)
            {
                int idP = Convert.ToInt32(AutoresIdtextBox.Text);

                Autor.Buscar(idP);
                NombreAutorestextBox.Text = Autor.NombreAutores.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese primero un Id");
                AutoresIdtextBox.Clear();
            }

        }
    }
}
