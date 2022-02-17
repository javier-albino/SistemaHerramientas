using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Entidades;
using Sistema.Datos;

namespace Sistema.Negocio
{
    public class NegDepartamento
    {
        public static DataTable Listar()
        {
            DatDepartamento Datos = new DatDepartamento();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DatDepartamento Datos = new DatDepartamento();
            return Datos.Buscar(Valor);
        }
        public static DataTable Seleccionar()
        {
            DatDepartamento Datos = new DatDepartamento();
            return Datos.Seleccionar();
        }
        public static string Insertar(string Nombre, string Descripcion)
        {
            DatDepartamento Datos = new DatDepartamento();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "El departamento ya existe";
            }
            else
            {
                Departamento Obj = new Departamento();
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int Id, string NombreAnt, string Nombre, string Descripcion)
        {
            DatDepartamento Datos = new DatDepartamento();
            Departamento Obj = new Departamento();
            if (NombreAnt.Equals(Nombre))
            {
                Obj.IdDepartamento = Id;
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "El departamento ya existe";
                }
                else
                {
                    Obj.IdDepartamento = Id;
                    Obj.Nombre = Nombre;
                    Obj.Descripcion = Descripcion;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Activar(int Id)
        {
            DatDepartamento Datos = new DatDepartamento();
            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            DatDepartamento Datos = new DatDepartamento();
            return Datos.Desactivar(Id);
        }
    }
}
