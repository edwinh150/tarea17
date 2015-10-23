using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Actores : ClaseMaestra
    {
        public int ActoreId { get; set; }

        public string NombreAutores { get; set; }

        public Actores()
        {
            ActoreId = 0;
            NombreAutores = "";
        }

        public Actores(int Id, string NombreA)
        {
            ActoreId = Id;
            NombreAutores = NombreA;
        }

        ConexionDb con = new ConexionDb();

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb con = new ConexionDb();
            DataTable dt = new DataTable();

            dt = con.ObtenerDatos(string.Format("select * from Actores where AutoresId = '{0}' ", IdBuscado));
            if (dt.Rows.Count > 0)
            {

                this.NombreAutores = dt.Rows[0]["Nombre"].ToString();

            }

            return dt.Rows.Count > 0;
        }

        public override bool Editar(int id)
        {
            bool retorno = false;

            retorno = con.Ejecutar(string.Format("update Actores set Nombre = '{0}' where AutoresId = '{1}'", this.NombreAutores, id));

            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;

            retorno = con.Ejecutar(string.Format("delete from Actores where AutoresId = '{0}' ", this.ActoreId));

            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;

            retorno = con.Ejecutar(String.Format("Insert into Actores (Nombre) values('{0}')", this.NombreAutores));

            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            return con.ObtenerDatos("select " + Campos + " from Actores where " + Condicion + "  " + Orden);
        }
    }
}
