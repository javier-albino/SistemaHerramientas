using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NegMarca
    {
        public static DataTable Listar()
        {
            DatMarca Datos = new DatMarca();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DatMarca Datos = new DatMarca();
            return Datos.Buscar(Valor);
        }
        public static DataTable Seleccionar()
        {
            DatMarca Datos = new DatMarca();
            return Datos.Seleccionar();
        }
        public static string Insertar(string Nombre, string Descripcion)
        {
            DatMarca Datos = new DatMarca();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La marca ya existe";
            }
            else
            {
                Marca Obj = new Marca();
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int Id, string NombreAnt, string Nombre, string Descripcion)
        {
            DatMarca Datos = new DatMarca();
            Marca Obj = new Marca();
            if (NombreAnt.Equals(Nombre))
            {
                Obj.IdMarca = Id;
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "La marca ya existe";
                }
                else
                {
                    Obj.IdMarca = Id;
                    Obj.Nombre = Nombre;
                    Obj.Descripcion = Descripcion;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Activar(int Id)
        {
            DatMarca Datos = new DatMarca();
            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            DatMarca Datos = new DatMarca();
            return Datos.Desactivar(Id);
        }
    }
}
