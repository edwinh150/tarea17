using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLLS
{
    public class Autores : ClaseMaestra
    {
        public int AutoreId { get; set; }

        public string NombreAutores { get; set; }

        public Autores()
        {
            AutoreId = 0;
            NombreAutores = "";
        }

        public Autores(int Id, string NombreA)
        {
            AutoreId = Id;
            NombreAutores = NombreA;
        }

        ConexionDb con = new ConexionDb();

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb con = new ConexionDb();
            DataTable dt = new DataTable();

            dt = con.ObtenerDatos(string.Format("select * from Autores where AutoresId = '{0}' ", IdBuscado));
            if (dt.Rows.Count > 0)
            {

                this.NombreAutores = dt.Rows[0]["Nombre"].ToString();

            }

            return dt.Rows.Count > 0;
        }

        public override bool Editar(int id)
        {
            bool retorno = false;

            con.Ejecutar(string.Format("update Autores set Nombre = '{0}' where AutoresId = '{1}'", this.NombreAutores, id));

            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;

            con.Ejecutar(string.Format("delete from Autores where AutoresId = '{0}' ", this.AutoreId));

            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;

            con.Ejecutar(String.Format("Insert into Autores (Nombre) values('{0}')", this.NombreAutores));

            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            return con.ObtenerDatos("select " + Campos + " from Autores where " + Condicion + "  " + Orden);
        }
    }
}
