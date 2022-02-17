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
    public class NegDevolucionArticulo
    {
        public static DataTable Listar()
        {
            DatDevolucionArticulo Datos = new DatDevolucionArticulo();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DatDevolucionArticulo Datos = new DatDevolucionArticulo();
            return Datos.Buscar(Valor);
        }
        public static string Insertar(string NumSerie, DateTime FechaDevolucion, string MotivoDevolucion, 
                                      int IdArticulo, int IdEmpleado, int IdUsuario)
        {
            DatDevolucionArticulo Datos = new DatDevolucionArticulo();
            string Existe = Datos.Existe(NumSerie);
            if (Existe.Equals("1"))
            {
                return "La devolucion ya existe";
            }
            else
            {
                DevolucionArticulo Obj = new DevolucionArticulo();
                Obj.NumSerie = NumSerie;
                Obj.FechaDevolucion = FechaDevolucion;
                Obj.MotivoDevolucion = MotivoDevolucion;
                Obj.IdArticulo = IdArticulo;
                Obj.IdEmpleado = IdEmpleado;
                Obj.IdUsuario = IdUsuario;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int IdDevolucion, string NumAnt, string NumSerie, DateTime FechaDevolucion, string MotivoDevolucion,
                                        int IdArticulo, int IdEmpleado, int IdUsuario)
        {
            DatDevolucionArticulo Datos = new DatDevolucionArticulo();
            DevolucionArticulo Obj = new DevolucionArticulo();
            if (NumAnt.Equals(NumSerie))
            {
                Obj.IdDevolucion = IdDevolucion;
                Obj.NumSerie = NumSerie;
                Obj.FechaDevolucion = FechaDevolucion;
                Obj.MotivoDevolucion = MotivoDevolucion;
                Obj.IdArticulo = IdArticulo;
                Obj.IdEmpleado = IdEmpleado;
                Obj.IdUsuario = IdUsuario;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(NumSerie);
                if (Existe.Equals("1"))
                {
                    return "La devolucion ya existe";
                }
                else
                {
                    Obj.IdDevolucion = IdDevolucion;
                    Obj.NumSerie = NumSerie;
                    Obj.FechaDevolucion = FechaDevolucion;
                    Obj.MotivoDevolucion = MotivoDevolucion;
                    Obj.IdArticulo = IdArticulo;
                    Obj.IdEmpleado = IdEmpleado;
                    Obj.IdUsuario = IdUsuario;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Activar(int Id)
        {
            DatDevolucionArticulo Datos = new DatDevolucionArticulo();
            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            DatDevolucionArticulo Datos = new DatDevolucionArticulo();
            return Datos.Desactivar(Id);
        }
    }
}
