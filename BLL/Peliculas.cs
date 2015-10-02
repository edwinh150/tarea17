using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Peliculas
    {
        public int PeliculaId { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public int Ano { get; set; }

        public int Calificacion { get; set; }

        public int IMDB { get; set; }

        public int CategoriaId { get; set; }

        public Peliculas()
        {
            this.PeliculaId = 0;
            this.Titulo = "";
            this.Descripcion = "";
            this.Ano = 0;
            this.Calificacion = 0;
            this.IMDB = 0;
            this.CategoriaId = 0;
        }

        public Peliculas(int PeliculaIdS, string TituloS, string DescripcionS, int AnoS, int CalificacionS, int IMDBS, int CategoriaIdS)
        {
            this.PeliculaId = PeliculaIdS;
            this.Titulo = TituloS;
            this.Descripcion = DescripcionS;
            this.Ano = AnoS;
            this.Calificacion = CalificacionS;
            this.IMDB = IMDBS;
            this.CategoriaId = CategoriaIdS;
        }

        public bool Insertar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();

            conexion.Ejecutar(String.Format("Insert Into Peliculas (PeliculaId, Titulo, Descripcion, Ano, Calificacion, IMDB, CategoriaId) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",this.PeliculaId,this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.IMDB, this. CategoriaId));

            return retorno;

        }
    }
}
