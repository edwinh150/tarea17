using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLLS
{
        // Capa de negocio ya creada
        public class Peliculas : ClaseMaestra
        {
            public int Peliculaid { get; set; }

            public string Titulo { get; set; }

            public string Descripcion { get; set; }

            public int Ano { get; set; }

            public int Calificacion { get; set; }

            public int IMDB { get; set; }

            public string Categoria { get; set; }

            public string Genero { get; set; }

            public string RutadeImagen { get; set; }

            public string RutadePelicula { get; set; }

            public string Autor { get; set; }

            public string Estudio { get; set; }

        public Peliculas()
            {
                this.Titulo = "";
                this.Descripcion = "";
                this.Ano = 0;
                this.Calificacion = 0;
                this.IMDB = 0;
                this.Categoria = "";
                this.Genero = "";
                this.RutadeImagen = "";
                this.RutadePelicula = "";
                this.Autor = "";
                this.Estudio = "";
            }

            public Peliculas(string TituloS, string DescripcionS, int AnoS, int CalificacionS, int IMDBS, string CategoriaIdS, string GeneroS, string RutaI, string RutaP, string AutorS, string EstudioS)
            {
                this.Titulo = TituloS;
                this.Descripcion = DescripcionS;
                this.Ano = AnoS;
                this.Calificacion = CalificacionS;
                this.IMDB = IMDBS;
                this.Categoria = CategoriaIdS;
                this.Genero = GeneroS;
                this.RutadeImagen = RutaI;
                this.RutadePelicula = RutaP;
                this.Autor = AutorS;
                this.Estudio = EstudioS;
            }

            public Peliculas(int peliculaid)
            {
                this.Peliculaid = peliculaid;
            }

        public override bool Insertar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();


            conexion.Ejecutar(string.Format("Insert Into PeliculasT ( Titulo, Descripcion, Ano, Calificacion, IMDB, CategoriaId, Genero, RutadeImagen, RutadePelicula, Autor, Estudio) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.IMDB, this.Categoria,this.Genero, this.RutadeImagen, this.RutadePelicula, this.Autor, this.Estudio));

            return retorno;
        }

        public override bool Editar(int id)
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();


            conexion.Ejecutar(string.Format("update PeliculasT set Titulo = '{0}' ,Descripcion = '{1}' ,Ano = '{2}' ,Calificacion = '{3}' ,IMDB = '{4}' ,CategoriaId = '{5}' ,Genero = '{6}', RutadeImagen = '{7}', RutadePelicula = '{8}', Autor = '{9}', Estudio = '{10}' where  PeliculaId = '{9}' ", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.IMDB, this.Categoria, this.Genero, this.RutadeImagen, this.RutadePelicula, this.Autor, this.Estudio, id));

            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();


            conexion.Ejecutar(string.Format("delete from PeliculasT where  PeliculaId = '{0}' ", this.Peliculaid));

            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb con = new ConexionDb();
            DataTable dt = new DataTable();

            dt = con.ObtenerDatos(string.Format("select * from PeliculasT where PeliculaId = {0} ", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.Titulo = dt.Rows[0]["Titulo"].ToString();
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                this.Ano = (int)dt.Rows[0]["Ano"];
                this.Calificacion = (int)dt.Rows[0]["Calificacion"];
                this.IMDB = (int)dt.Rows[0]["IMDB"];
                this.Categoria = dt.Rows[0]["CategoriaId"].ToString();
                this.Genero = dt.Rows[0]["Genero"].ToString();
                this.RutadePelicula = dt.Rows[0]["RutadePelicula"].ToString();
                this.RutadeImagen = dt.Rows[0]["RutadeImagen"].ToString();
                this.Autor = dt.Rows[0]["Autor"].ToString();
                this.Estudio = dt.Rows[0]["Estudio"].ToString();
            }

            return dt.Rows.Count > 0;

        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb con = new ConexionDb();

            return con.ObtenerDatos("select " + Campos + " from PeliculasT where " + Condicion + "  " + Orden);
        }
    }
}
