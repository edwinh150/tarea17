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

            public string CategoriaId { get; set; }

            public string Genero { get; set; }

            public string RutadeImagen { get; set; }

            public string RutadePelicula { get; set; }

        public Peliculas()
            {
                this.Titulo = "";
                this.Descripcion = "";
                this.Ano = 0;
                this.Calificacion = 0;
                this.IMDB = 0;
                this.CategoriaId = "";
                this.Genero = "";
                this.RutadeImagen = "";
                this.RutadePelicula = "";
            }

            public Peliculas(string TituloS, string DescripcionS, int AnoS, int CalificacionS, int IMDBS, string CategoriaIdS, string GeneroS, string RutaI, string RutaP)
            {
                this.Titulo = TituloS;
                this.Descripcion = DescripcionS;
                this.Ano = AnoS;
                this.Calificacion = CalificacionS;
                this.IMDB = IMDBS;
                this.CategoriaId = CategoriaIdS;
                this.Genero = GeneroS;
                this.RutadeImagen = RutaI;
                this.RutadePelicula = RutaP;
            }

            public Peliculas(int peliculaid)
            {
                this.Peliculaid = peliculaid;
            }

        public override bool Insertar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();


            conexion.Ejecutar(string.Format("Insert Into PeliculasT ( Titulo, Descripcion, Ano, Calificacion, IMDB, CategoriaId, Genero, RutadeImagen, RutadePelicula) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.IMDB, this.CategoriaId,this.Genero, this.RutadeImagen, this.RutadePelicula));

            return retorno;
        }

        public override bool Modificar(int id)
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();


            conexion.Ejecutar(string.Format("update PeliculasT set Titulo = '{0}' ,Descripcion = '{1}' ,Ano = '{2}' ,Calificacion = '{3}' ,IMDB = '{4}' ,CategoriaId = '{5}' ,Genero = '{6}', RutadeImagen = '{7}', RutadePelicula = '{8}' where  PeliculaId = '{9}' ", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.IMDB, this.CategoriaId, this.Genero, this.RutadeImagen, this.RutadePelicula, id));

            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();


            conexion.Ejecutar(string.Format("delete from PeliculasT where  PeliculaId = '{0}' ", this.Peliculaid));

            return retorno;
        }

        public override DataTable Buscar(int IdBuscado)
        {
            ConexionDb con = new ConexionDb();

            return con.ObtenerDatos(string.Format("select * from PeliculasT where PeliculaId = {0} ", IdBuscado));
        }

        public override DataTable BuscarPelicula(int IdBuscado)
        {
            ConexionDb con = new ConexionDb();

            return con.ObtenerDatos(string.Format("select * from PeliculasT where PeliculaId = {0}", IdBuscado));
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
