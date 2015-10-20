using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLS
{
    public abstract class ClaseMaestra
    {

            public abstract bool Insertar();

            public abstract bool Editar(int id);

            public abstract bool Eliminar();

            public abstract bool Buscar(int IdBuscado);

            public abstract DataTable Listado(string Campos, string Condicion, string Orden);

    }
}

