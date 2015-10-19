﻿using System;
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
    public partial class MainForm : Form
    {
        Peliculas peliculaC = new Peliculas();
        Generos genero = new Generos();
        public string ruta;


        public MainForm()
        {
            InitializeComponent();
            ConcomboBox.Text = "Todos";
            for (int i = 0; i < genero.Listado(" * ", "1=1", "").Rows.Count; i++)
            {
                GenerocomboBox.Items.Add(genero.Listado(" * ", "1=1", "").Rows[i]["Descripcion"]);
            }
            
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            ConexionDb con = new ConexionDb();

            Peliculas peli = new Peliculas();

            ReproducirForm rp = new ReproducirForm();

            if (ConcomboBox.Text == "Todos")
            {
                ConsultartextBox.Clear();
                try
                {
                    ResultadodataGridView.DataSource = con.ObtenerDatos("Select * from PeliculasT");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (ConsultartextBox.Text.Length == 0 && ConcomboBox.Text != "Todos")
            {
                MessageBox.Show("Ingrese un campo para poder consultar!!!!","Error");
            }
            else
            { 
                if (ConcomboBox.Text == "Id")
                {
                    try
                    {
                        ResultadodataGridView.DataSource = peli.Listado(" * ", "PeliculaId = " + ConsultartextBox.Text, "");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (ConcomboBox.Text == "Titulo")
                {
                    try
                    {
                        ResultadodataGridView.DataSource = peli.Listado(" * ","Titulo = " + ConsultartextBox.Text, "");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (ConcomboBox.Text == "Categoria")
                {
                    try
                    {
                       // ResultadodataGridView.DataSource = peli.Listado(ConsultartextBox.Text, "CategoriaId");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (ConcomboBox.Text == "Genero")
                {
                    try
                    {
                        //ResultadodataGridView.DataSource = peli.Listado(ConsultartextBox.Text, "Genero");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (ConcomboBox.Text == "Ano")
                {
                    try
                    {
                       // ResultadodataGridView.DataSource = peli.Listado(ConsultartextBox.Text, "Ano");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            ConexionDb con = new ConexionDb();

            if (PeliculaIdtextBox.Text.Length > 0)
            {
                if (MessageBox.Show("Realmente desea Modificar La Pelicula con el Id: "+ PeliculaIdtextBox.Text +" ?", "Modificando Archivo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(PeliculaIdtextBox.Text);

                        peliculaC.Titulo = TitulotextBox.Text;

                        peliculaC.Descripcion = DescripciontextBox.Text;

                        peliculaC.Ano = Convert.ToInt32(AnocomboBox.Text);

                        peliculaC.Calificacion = Convert.ToInt32(CalificaciontextBox.Text);

                        peliculaC.IMDB = Convert.ToInt32(IMDBtextBox.Text);

                        peliculaC.CategoriaId = CategoriacomboBox.Text;

                        peliculaC.RutadeImagen = PortadapictureBox.ImageLocation;

                        peliculaC.RutadePelicula = RutatextBox.Text;

                        peliculaC.Genero = GenerolistBox.Text;

                        peliculaC.Estudio = EstudiotextBox.Text;

                        peliculaC.Autor = AutoreslistBox.Text;

                        peliculaC.Editar(id);

                        MessageBox.Show("Se modifico correctamente");

                        TitulotextBox.Clear();
                        DescripciontextBox.Clear();
                        AnocomboBox.Text = "";
                        CalificaciontextBox.Clear();
                        IMDBtextBox.Clear();
                        CategoriacomboBox.Text = "";
                        RutatextBox.Clear();
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
                    peliculaC.Titulo = TitulotextBox.Text;

                    peliculaC.Descripcion = DescripciontextBox.Text;

                    peliculaC.Ano = Convert.ToInt32(AnocomboBox.Text);

                    peliculaC.Calificacion = Convert.ToInt32(CalificaciontextBox.Text);

                    peliculaC.IMDB = Convert.ToInt32(IMDBtextBox.Text);

                    peliculaC.CategoriaId = CategoriacomboBox.Text;

                    peliculaC.RutadeImagen = PortadapictureBox.ImageLocation;

                    peliculaC.RutadePelicula = RutatextBox.Text;

                    peliculaC.Genero = GenerolistBox.Text;

                    peliculaC.Estudio = EstudiotextBox.Text;

                    peliculaC.Autor = AutoreslistBox.Text;

                    peliculaC.Insertar();

                    MessageBox.Show("Se guardo correctamente");

                    TitulotextBox.Clear();
                    DescripciontextBox.Clear();
                    AnocomboBox.Text = "";
                    CalificaciontextBox.Clear();
                    IMDBtextBox.Clear();
                    CategoriacomboBox.Text = "";
                    RutatextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }           
        }

        private void limpiarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            ConexionDb con = new ConexionDb();

            
        }

        private void PeliculaIdtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PortadapictureBox_Click(object sender, EventArgs e)
        {
            openFileDialogImagen.ShowDialog();
            PortadapictureBox.ImageLocation = openFileDialogImagen.FileName;
        }

        private void RutatextBox_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Rutabutton_Click(object sender, EventArgs e)
        {
            openFileDialogPeliculaV.ShowDialog();
            RutatextBox.Text = openFileDialogPeliculaV.FileName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea borrarlo?", "Borrarando Archivo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    peliculaC.Peliculaid = Convert.ToInt32(PeliculaIdtextBox.Text);

                    peliculaC.Eliminar();

                    MessageBox.Show("Se Borro correctamente");
                    PeliculaIdtextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (PeliculaIdtextBox.Text.Length > 0)
            {
                int idP = Convert.ToInt32(PeliculaIdtextBox.Text);

                peliculaC.Buscar(idP);
                TitulotextBox.Text = peliculaC.Titulo;
                DescripciontextBox.Text = peliculaC.Descripcion;
                AnocomboBox.Text = peliculaC.Ano.ToString();
                CalificaciontextBox.Text = peliculaC.Calificacion.ToString();
                IMDBtextBox.Text = peliculaC.IMDB.ToString();
                CategoriacomboBox.Text = peliculaC.CategoriaId;
                RutatextBox.Text = peliculaC.RutadePelicula;
                PortadapictureBox.ImageLocation = peliculaC.RutadeImagen;
                GenerolistBox.Items.Add(peliculaC.Genero);
                EstudiotextBox.Text = peliculaC.Estudio;
                AutoreslistBox.Items.Add(peliculaC.Autor);
                
            }
            else
            {
                MessageBox.Show("Ingrese Id");
            }
            
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            TitulotextBox.Clear();
            DescripciontextBox.Clear();
            AnocomboBox.Text = "";
            CalificaciontextBox.Clear();
            IMDBtextBox.Clear();
            CategoriacomboBox.Text = "";
            RutatextBox.Clear();
            GenerolistBox.Text = "";
        }

        private void Reproducirbutton_Click(object sender, EventArgs e)
        {
            ReproducirForm Rp = new ReproducirForm();
            ruta = ResultadodataGridView.CurrentRow.Cells["RutadePelicula"].Value.ToString();
            Rp.Show();
        }

        private void Limpiarbutton_Click_1(object sender, EventArgs e)
        {
            ResultadodataGridView.DataBindings.Clear();
            ConsultartextBox.Clear();
        }

        private void agregarGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneroForm Genero = new GeneroForm();
            
            Genero.Show();
        }

        private void AgregarGenerobutton_Click(object sender, EventArgs e)
        {
            GenerolistBox.Items.Add(GenerocomboBox.Text);
            GenerocomboBox.Text = "";
        }
    }
}
