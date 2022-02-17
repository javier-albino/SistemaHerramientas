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
    public class NegUsuario
    {
        public static DataTable Listar()
        {
            DatUsuario Datos = new DatUsuario();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DatUsuario Datos = new DatUsuario();
            return Datos.Buscar(Valor);
        }
        public static DataTable Seleccionar()
        {
            DatUsuario Datos = new DatUsuario();
            return Datos.Seleccionar();
        }
        public static DataTable Login(string Email, string Clave)
        {
            DatUsuario Datos = new DatUsuario();
            return Datos.Login(Email, Clave);
        }
        public static string Insertar(string Rut, string Nombres, string Apellidos, string Telefono,
                                      string Email, string Clave, int IdRol)
        {
            DatUsuario Datos = new DatUsuario();
            string Existe = Datos.Existe(Rut);
            if (Existe.Equals("1"))
            {
                return "El usuario ya existe";
            }
            else
            {
                Usuario Obj = new Usuario();
                Obj.Rut = Rut;
                Obj.Nombres = Nombres;
                Obj.Apellidos = Apellidos;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                Obj.Clave = Clave;
                Obj.IdRol = IdRol;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int IdUsuario, string RutAnt, string Rut, string Nombres, string Apellidos,
                                        string Telefono, string Email, string Clave, int IdRol)
        {
            DatUsuario Datos = new DatUsuario();
            Usuario Obj = new Usuario();
            if (RutAnt.Equals(Rut))
            {
                Obj.IdUsuario = IdUsuario;
                Obj.Rut = Rut;
                Obj.Nombres = Nombres;
                Obj.Apellidos = Apellidos;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                Obj.Clave = Clave;
                Obj.IdRol = IdRol;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Rut);
                if (Existe.Equals("1"))
                {
                    return "El usuario ya existe";
                }
                else
                {
                    Obj.IdUsuario = IdUsuario;
                    Obj.Rut = Rut;
                    Obj.Nombres = Nombres;
                    Obj.Apellidos = Apellidos;
                    Obj.Telefono = Telefono;
                    Obj.Email = Email;
                    Obj.Clave = Clave;
                    Obj.IdRol = IdRol;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Activar(int Id)
        {
            DatUsuario Datos = new DatUsuario();
            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            DatUsuario Datos = new DatUsuario();
            return Datos.Desactivar(Id);
        }
    }
}
