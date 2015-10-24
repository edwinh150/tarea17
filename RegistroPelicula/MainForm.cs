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
using BLL;

namespace RegistroPelicula
{
    public partial class MainForm : Form
    {
        Peliculas peliculaC = new Peliculas();
        Generos genero = new Generos();
        Actores autor = new Actores();
        Estudios estudio = new Estudios();

        public string ruta;


        public MainForm()
        {
            InitializeComponent();

            ConcomboBox.Text = "Todos";

            for (int i = 0; i < genero.Listado(" * ", "1=1", "").Rows.Count; i++)
            {
                GenerocomboBox.Items.Add(genero.Listado(" * ", "1=1", "").Rows[i]["Descripcion"]);
            }

            for (int i = 0; i < autor.Listado(" * ", "1=1", "").Rows.Count; i++)
            {
                ActorescomboBox.Items.Add(autor.Listado(" * ", "1=1", "").Rows[i]["Nombre"]);
            }

            for (int i = 0; i < estudio.Listado(" * ", "1=1", "").Rows.Count; i++)
            {
                EstudiocomboBox.Items.Add(estudio.Listado(" * ", "1=1", "").Rows[i]["Nombre"]);
            }

        }

        private void limpiar()
        {
            PeliculaIdtextBox.Clear();
            TitulotextBox.Clear();
            DescripciontextBox.Clear();
            AnocomboBox.Text = "";
            CalificaciontextBox.Clear();
            IMDBtextBox.Clear();
            CategoriacomboBox.Text = "";
            RutatextBox.Clear();
            PortadapictureBox.ImageLocation = "";
            GenerocomboBox.Text = "";
            EstudiocomboBox.Text = "";
            ActorescomboBox.Text = "";
            ActoreslistBox.Text = "";
            GenerolistBox.Text = "";
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
                       ResultadodataGridView.DataSource = peli.Listado(" * ", "Categoria = " + ConsultartextBox.Text, "");

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
                       ResultadodataGridView.DataSource = peli.Listado(" * ", "Genero = " + ConsultartextBox.Text, "");

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

                        peliculaC.Categoria = CategoriacomboBox.Text;

                        peliculaC.RutadeImagen = PortadapictureBox.ImageLocation;

                        peliculaC.RutadePelicula = RutatextBox.Text;

                        peliculaC.Estudio = EstudiocomboBox.Text;

                        peliculaC.Editar(id);

                        MessageBox.Show("Se modifico correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    limpiar();
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

                    peliculaC.Categoria = CategoriacomboBox.Text;

                    peliculaC.RutadeImagen = PortadapictureBox.ImageLocation;

                    peliculaC.RutadePelicula = RutatextBox.Text;

                    peliculaC.Estudio = EstudiocomboBox.Text;

                    peliculaC.Insertar();

                    MessageBox.Show("Se guardo correctamente");

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //limpiar();
            }
                      
        }

        private void limpiarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {

            
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
                    peliculaC.PeliculaId = Convert.ToInt32(PeliculaIdtextBox.Text);

                    peliculaC.Eliminar();

                    MessageBox.Show("Se Borro correctamente");
                    limpiar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            limpiar();
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
                CategoriacomboBox.Text = peliculaC.Categoria;
                RutatextBox.Text = peliculaC.RutadePelicula;
                PortadapictureBox.ImageLocation = peliculaC.RutadeImagen;
                EstudiocomboBox.Text = peliculaC.Estudio;
                
            }
            else
            {
                MessageBox.Show("Primero Ingrese un Id");
            }
            
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            limpiar();
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
            int IdG = 0;

            GenerolistBox.Items.Add(GenerocomboBox.Text);

            for (int i = 0; i < genero.Listado(" * ", "1=1", "").Rows.Count; i++)
            {
                IdG = (int)genero.Listado("GeneroId", string.Format("Descripcion = '{0}' ", GenerocomboBox.Text), " ").Rows[0]["GeneroId"];

                peliculaC.AgregarGenero(IdG, GenerolistBox.Text);
            }

            GenerocomboBox.Text = "";
        }

        private void agregarAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutorForm autor = new AutorForm();

            autor.Show();   
        }

        private void agregarEstudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstudioForm estudio = new EstudioForm();

            estudio.Show();
        }

        private void AgregarAutoresbutton_Click(object sender, EventArgs e)
        {
            int Id = 0;

            ActoreslistBox.Items.Add(ActorescomboBox.Text);

            for (int i = 0; i < autor.Listado(" * ", "1=1", "").Rows.Count; i++)
            {
                Id = (int)autor.Listado("AutoresId", string.Format("Nombre = '{0}' ", ActorescomboBox.Text)," ").Rows[0]["AutoresId"];

                peliculaC.AgregarActor(Id,ActoreslistBox.Text);
            }
            
            ActorescomboBox.Text = "";
        }
    }
}
