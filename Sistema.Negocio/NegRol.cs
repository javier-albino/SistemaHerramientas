using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;

namespace Sistema.Negocio
{
    public class NegRol
    {
        public static DataTable Listar()
        {
            DatRol Datos = new DatRol();
            return Datos.Listar();
        }
        public static DataTable Seleccionar()
        {
            DatRol Datos = new DatRol();
            return Datos.Seleccionar();
        }
    }
}
