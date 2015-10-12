﻿using System;
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

            public abstract bool Modificar(int id);

            public abstract bool Eliminar();

            public abstract DataTable Buscar(int IdBuscado);

            public abstract DataTable BuscarPelicula(int IdBuscado);

            public abstract DataTable Listado(string Campos, string Condicion, string Orden);
    }
}

