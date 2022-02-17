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
    public class NegEntregaArticulo
    {
        public static DataTable Listar()
        {
            DatEntregaArticulo Datos = new DatEntregaArticulo();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DatEntregaArticulo Datos = new DatEntregaArticulo();
            return Datos.Buscar(Valor);
        }
        public static string Insertar(string NumSerie, DateTime FechaEntrega, string Condicion, 
                                      int IdArticulo, int IdEmpleado, int IdUsuario)
        {
            DatEntregaArticulo Datos = new DatEntregaArticulo();
            string Existe = Datos.Existe(NumSerie);
            if (Existe.Equals("1"))
            {
                return "La entrega ya existe";
            }
            else
            {
                EntregaArticulo Obj = new EntregaArticulo();
                Obj.NumSerie = NumSerie;
                Obj.FechaEntrega = FechaEntrega;
                Obj.Condicion = Condicion;
                Obj.IdArticulo = IdArticulo;
                 Obj.IdEmpleado = IdEmpleado;
                Obj.IdUsuario = IdUsuario;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int IdEntrega, string NumAnt, string NumSerie, DateTime FechaEntrega, 
                                       string Condicion, int IdArticulo, int IdEmpleado, int IdUsuario)
        {
            DatEntregaArticulo Datos = new DatEntregaArticulo();
            EntregaArticulo Obj = new EntregaArticulo();
            if (NumAnt.Equals(NumSerie))
            {
                Obj.IdEntrega = IdEntrega;
                Obj.NumSerie = NumSerie;
                Obj.FechaEntrega = FechaEntrega;
                Obj.Condicion = Condicion;
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
                    return "La entrega ya existe";
                }
                else
                {
                    Obj.IdEntrega = IdEntrega;
                    Obj.NumSerie = NumSerie;
                    Obj.FechaEntrega = FechaEntrega;
                    Obj.Condicion = Condicion;
                    Obj.IdArticulo = IdArticulo;
                    Obj.IdEmpleado = IdEmpleado;
                    Obj.IdUsuario = IdUsuario;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Activar(int Id)
        {
            DatEntregaArticulo Datos = new DatEntregaArticulo();
            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            DatEntregaArticulo Datos = new DatEntregaArticulo();
            return Datos.Desactivar(Id);
        }
    }
}
