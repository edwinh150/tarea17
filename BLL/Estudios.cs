using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLLS
{
   public class Estudios : ClaseMaestra
    {
        public int EstudioId { get; set; }

        public string NombreEstudio { get; set; }

        public Estudios()
        {
            this.EstudioId = 0;
            this.NombreEstudio = "";
        }

        public Estudios(int id, string nombreE)
        {
            this.EstudioId = id;
            this.NombreEstudio = nombreE;
        }

        ConexionDb con = new ConexionDb();
        DataTable dt = new DataTable();

        public override bool Buscar(int IdBuscado)
        {
            dt = con.ObtenerDatos(string.Format("select * from Estudios where EstudiosId = '{0}' ", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.NombreEstudio = dt.Rows[0]["Nombre"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override bool Editar(int id)
        {
            bool retorno = false;

            retorno = con.Ejecutar(string.Format("update Estudios set Nombre = '{0}' where EstudiosId = '{1}' ", this.NombreEstudio, id));

            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;

            retorno = con.Ejecutar(string.Format("delete from Estudios where EstudiosId = '{0}' ", this.EstudioId));

            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;

            retorno = con.Ejecutar(string.Format("insert into Estudios (Nombre) values ('{0}') ", this.NombreEstudio));

            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            return con.ObtenerDatos("select " + Campos + " from Estudios where " + Condicion + "  " + Orden);
        }
    }
}
