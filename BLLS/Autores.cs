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
        public int AutoresId { get; set; }

        public string NombreAutores { get; set; }

        public Autores()
        {
            AutoresId = 0;
            NombreAutores = "";
        }

        public Autores(int Id, string NombreA)
        {
            AutoresId = Id;
            NombreAutores = NombreA;
        }

        ConexionDb con = new ConexionDb();

        public override bool Buscar(int IdBuscado)
        {
            bool retorno = false;

            con.Ejecutar(string.Format("update Autores set Nombre = '{0}' where AutoresId = '{1}'", this.NombreAutores, IdBuscado));

            return retorno;
        }

        public override bool Editar(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            bool retorno = false;

            con.Ejecutar(string.Format("delete from Autores where AutoresId = '{0}' ", this.AutoresId));

            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;

            con.Ejecutar(String.Format("Insert into Autores (Nombre) values('{0}')", this.NombreAutores));

            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion)
        {
            return con.ObtenerDatos("select * from Autores where " + Condicion + " = " + Campos);
        }
    }
}
