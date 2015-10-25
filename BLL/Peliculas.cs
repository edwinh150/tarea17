using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
        // Capa de negocio ya creada
        public class Peliculas : ClaseMaestra
        {
            public int PeliculaId { get; set; }

            public string Titulo { get; set; }

            public string Descripcion { get; set; }

            public int Ano { get; set; }

            public int Calificacion { get; set; }

            public int IMDB { get; set; }

            public string Categoria { get; set; }

            public string RutadeImagen { get; set; }

            public string RutadePelicula { get; set; }

            public string Estudio { get; set; }

            public List<Actores> Actores { get; set; }

            public List<Generos> Generos { get; set; }

        public Peliculas()
            {
                this.Titulo = "";
                this.Descripcion = "";
                this.Ano = 0;
                this.Calificacion = 0;
                this.IMDB = 0;
                this.Categoria = "";
                this.RutadeImagen = "";
                this.RutadePelicula = "";
                this.Estudio = "";

                Actores = new List<Actores>();
                Generos = new List<Generos>();
            }

            public Peliculas(string TituloS, string DescripcionS, int AnoS, int CalificacionS, int IMDBS, string CategoriaIdS, string RutaI, string RutaP, string EstudioS)
            {
                this.Titulo = TituloS;
                this.Descripcion = DescripcionS;
                this.Ano = AnoS;
                this.Calificacion = CalificacionS;
                this.IMDB = IMDBS;
                this.Categoria = CategoriaIdS;
                this.RutadeImagen = RutaI;
                this.RutadePelicula = RutaP;
                this.Estudio = EstudioS;
            }

            public void AgregarActor(int ActorId, string NombreActores)
            {
                this.Actores.Add(new Actores(ActorId, NombreActores));
            }

            public void AgregarGenero(int GeneroId, string NombreGenero)
            {
                this.Generos.Add(new Generos(GeneroId, NombreGenero));
            }


        public Peliculas(int peliculaid)
            {
                this.PeliculaId = peliculaid;
            }

        public override bool Insertar()
        {
            bool retorno = false;
            StringBuilder Comando = new StringBuilder();

            ConexionDb conexion = new ConexionDb();

            retorno = conexion.Ejecutar(string.Format("Insert Into PeliculasT ( Titulo, Descripcion, Ano, Calificacion, IMDB, CategoriaId, RutadeImagen, RutadePelicula, Estudio) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.IMDB, this.Categoria, this.RutadeImagen, this.RutadePelicula, this.Estudio));
            if (retorno)
            {
                this.PeliculaId = (int)conexion.ObtenerDatos("Select Max(PeliculaId) as PeliculaId from PeliculasT").Rows[0]["PeliculaId"];

                foreach (var autor in this.Actores)
                {
                    Comando.AppendLine(String.Format("Insert into PeliculasActores (PeliculaId,ActorId) Values({0},{1});", this.PeliculaId, autor.ActoreId));

                }
            }

            if (retorno)
            {
                this.PeliculaId = (int)conexion.ObtenerDatos("Select Max(PeliculaId) as PeliculaId from PeliculasT").Rows[0]["PeliculaId"];

                foreach (var genero in this.Generos)
                {
                    Comando.AppendLine(String.Format("Insert into PeliculasGeneros (PeliculaId,GeneroId) Values({0},{1});", this.PeliculaId, genero.GeneroId));

                }

                retorno = conexion.Ejecutar(Comando.ToString());
            }

            return retorno;
        }

        public override bool Editar(int id)
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();
            StringBuilder Comando = new StringBuilder();

            retorno = conexion.Ejecutar(string.Format("update PeliculasT set Titulo = '{0}' ,Descripcion = '{1}' ,Ano = '{2}' ,Calificacion = '{3}' ,IMDB = '{4}' ,CategoriaId = '{5}' , RutadeImagen = '{6}', RutadePelicula = '{7}', Estudio = '{8}' where  PeliculaId = '{9}' ", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.IMDB, this.Categoria, this.RutadeImagen, this.RutadePelicula, this.Estudio, id));

            if (retorno)
            {
                conexion.Ejecutar("Delete From PeliculasActores Where PeliculaId = " + this.PeliculaId);

                foreach (var autor in this.Actores)
                {
                    Comando.AppendLine(String.Format("insert into PeliculasActores (PeliculaId,ActorId) Values({0},{1});", this.PeliculaId, autor.ActoreId));

                }

                retorno = conexion.Ejecutar(Comando.ToString());
            }

            if (retorno)
            {
                conexion.Ejecutar("Delete From PeliculasEstudios Where PeliculaId =" + this.PeliculaId);

                foreach (var genero in this.Generos)
                {
                    Comando.AppendLine(String.Format("Insert into PeliculasGeneros (PeliculaId,GeneroId) Values({0},{1});", this.PeliculaId, genero.GeneroId));

                }

                retorno = conexion.Ejecutar(Comando.ToString());
            }

            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();


            retorno = conexion.Ejecutar(string.Format("delete from PeliculasT where  PeliculaId = '{0}' ", this.PeliculaId + "; " +
                                            "Delete From PeliculasActores Where PeliculaId =" + this.PeliculaId + "; " +
                                            "Delete From PeliculasGeneros Where PeliculaId =" + this.PeliculaId));

            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb con = new ConexionDb();
            DataTable dt = new DataTable();
            DataTable dtActores = new DataTable();
            DataTable dtEstudio = new DataTable();

            dt = con.ObtenerDatos(string.Format("select * from PeliculasT where PeliculaId = {0} ", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.Titulo = dt.Rows[0]["Titulo"].ToString();
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                this.Ano = (int)dt.Rows[0]["Ano"];
                this.Calificacion = (int)dt.Rows[0]["Calificacion"];
                this.IMDB = (int)dt.Rows[0]["IMDB"];
                this.Categoria = dt.Rows[0]["CategoriaId"].ToString();
                this.Estudio = dt.Rows[0]["Estudio"].ToString();
                this.RutadePelicula = dt.Rows[0]["RutadePelicula"].ToString();
                this.RutadeImagen = dt.Rows[0]["RutadeImagen"].ToString();
                dtActores = con.ObtenerDatos("Select p.ActorId,a.Nombre " +
                                                    "From PeliculasActores p " +
                                                    "Inner Join Actores a On p.ActorId=a.ActorId" +
                                                    "Where p.PeliculaId=" + this.PeliculaId);

                dtEstudio = con.ObtenerDatos("Select p.GeneroId,e.Nombre " +
                                                    "From PeliculasGeneros p " +
                                                    "Inner Join Generos a On p.GeneroId=e.GeneroId" +
                                                    "Where p.PeliculaId=" + this.PeliculaId);
            }

            return dt.Rows.Count > 0;

        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb con = new ConexionDb();
            string ordenFinal = ""; //!orden.Equals("") ? " orden by  " + orden : "";
            if (!Orden.Equals(""))
                ordenFinal = " orden by  " + Orden;

            return con.ObtenerDatos("select " + Campos + " from PeliculasT where " + Condicion + "  " + ordenFinal);
        }
    }
}
