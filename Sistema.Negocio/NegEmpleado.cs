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
    public class NegEmpleado
    {
        public static DataTable Listar()
        {
            DatEmpleado Datos = new DatEmpleado();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DatEmpleado Datos = new DatEmpleado();
            return Datos.Buscar(Valor);
        }
        public static DataTable Seleccionar()
        {
            DatEmpleado Datos = new DatEmpleado();
            return Datos.Seleccionar();
        }
        public static string Insertar(string Rut, string Nombres, string Apellidos, 
                                      int IdDepartamento, int IdPuesto)
        {
            DatEmpleado Datos = new DatEmpleado();
            string Existe = Datos.Existe(Rut);
            if (Existe.Equals("1"))
            {
                return "El empleado ya existe";
            }
            else
            {
                Empleado Obj = new Empleado();
                Obj.Rut = Rut;
                Obj.Nombres = Nombres;
                Obj.Apellidos = Apellidos;
                Obj.IdPuesto = IdPuesto;
                Obj.IdDepartamento = IdDepartamento;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int IdEmpleado, string RutAnt, string Rut, string Nombres,
                                        string Apellidos, int IdDepartamento, int IdPuesto)
        {
            DatEmpleado Datos = new DatEmpleado();
            Empleado Obj = new Empleado();
            if (RutAnt.Equals(Rut))
            {
                Obj.IdEmpleado = IdEmpleado;
                Obj.Rut = Rut;
                Obj.Nombres = Nombres;
                Obj.Apellidos = Apellidos;
                Obj.IdPuesto = IdPuesto;
                Obj.IdDepartamento = IdDepartamento;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Rut);
                if (Existe.Equals("1"))
                {
                    return "El empleado ya existe";
                }
                else
                {
                    Obj.IdEmpleado = IdEmpleado;
                    Obj.Rut = Rut;
                    Obj.Nombres = Nombres;
                    Obj.Apellidos = Apellidos;
                    Obj.IdPuesto = IdPuesto;
                    Obj.IdDepartamento = IdDepartamento;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Activar(int Id)
        {
            DatEmpleado Datos = new DatEmpleado();
            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            DatEmpleado Datos = new DatEmpleado();
            return Datos.Desactivar(Id);
        }
    }
}
