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
    public class NegPuesto
    {
        public static DataTable Listar()
        {
            DatPuesto Datos = new DatPuesto();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DatPuesto Datos = new DatPuesto();
            return Datos.Buscar(Valor);
        }
        public static DataTable Seleccionar()
        {
            DatPuesto Datos = new DatPuesto();
            return Datos.Seleccionar();
        }
        public static string Insertar(string Nombre, string Descripcion)
        {
            DatPuesto Datos = new DatPuesto();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "El puesto ya existe";
            }
            else
            {
                Puesto Obj = new Puesto();
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int Id, string NombreAnt, string Nombre, string Descripcion)
        {
            DatPuesto Datos = new DatPuesto();
            Puesto Obj = new Puesto();
            if (NombreAnt.Equals(Nombre))
            {
                Obj.IdPuesto = Id;
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "El puesto ya existe";
                }
                else
                {
                    Obj.IdPuesto = Id;
                    Obj.Nombre = Nombre;
                    Obj.Descripcion = Descripcion;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Activar(int Id)
        {
            DatPuesto Datos = new DatPuesto();
            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            DatPuesto Datos = new DatPuesto();
            return Datos.Desactivar(Id);
        }
    }
}
