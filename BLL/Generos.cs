using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Generos : ClaseMaestra
    {
        public int GeneroId { get; set; }

        public string Descripcion { get; set; }

        public Generos()
        {
            this.GeneroId = 0;
            this.Descripcion = "";
        }

        public Generos(int GeneroId, string descripcion)
        {
            this.GeneroId = GeneroId;
            this.Descripcion = descripcion;
        }

        public override bool Insertar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();

            retorno = conexion.Ejecutar(string.Format("Insert Into Generos (Descripcion) Values ('{0}')", this.Descripcion));

            return retorno;
        }

        public override bool Editar(int id)
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();

            retorno = conexion.Ejecutar(string.Format("update Generos set Descripcion = '{0}' where GeneroId = '{1}' ", this.Descripcion, id));

            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();

            retorno = conexion.Ejecutar(string.Format("delete from Generos where GeneroId = '{0}' ", this.GeneroId));

            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb con = new ConexionDb();
            DataTable dt = new DataTable();

            dt = con.ObtenerDatos(string.Format("select * from Generos where GeneroId = '{0}' ", IdBuscado));
            if (dt.Rows.Count > 0)
            {

                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();

            }

            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb con = new ConexionDb();

            return con.ObtenerDatos("select " + Campos + "  from Generos where " + Condicion + " " + Orden);
        }
    }
}
