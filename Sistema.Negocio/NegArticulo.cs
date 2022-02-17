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
    public class NegArticulo
    {
        public static DataTable Listar()
        {
            DatArticulo Datos = new DatArticulo();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DatArticulo Datos = new DatArticulo();
            return Datos.Buscar(Valor);
        }
        public static DataTable SeleccionarNombre()
        {
            DatArticulo Datos = new DatArticulo();
            return Datos.SeleccionarNombre();
        }
        public static string Insertar(string Nombre, string Modelo, int Cantidad, int PrecioCompra,
                                       DateTime FechaCompra, string CodigoBarras, int IdMarca)
        {
            DatArticulo Datos = new DatArticulo();
            string Existe = Datos.Existe(CodigoBarras);
            if (Existe.Equals("1"))
            {
                return "El articulo ya existe";
            }
            else
            {
                Articulo Obj = new Articulo();
                Obj.Nombre = Nombre;
                Obj.Modelo = Modelo;
                Obj.Cantidad = Cantidad;
                Obj.PrecioCompra = PrecioCompra;
                Obj.FechaCompra = FechaCompra;
                Obj.CodigoBarras = CodigoBarras;
                Obj.IdMarca = IdMarca;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int IdArticulo, string Nombre, string Modelo, string NumAnt, int Cantidad,
                                        int PrecioCompra, DateTime FechaCompra, string CodigoBarras, int IdMarca)
        {
            DatArticulo Datos = new DatArticulo();
            Articulo Obj = new Articulo();
            if (NumAnt.Equals(CodigoBarras))
            {
                Obj.IdArticulo = IdArticulo;
                Obj.Nombre = Nombre;
                Obj.Modelo = Modelo;
                Obj.Cantidad = Cantidad;
                Obj.PrecioCompra = PrecioCompra;
                Obj.FechaCompra = FechaCompra;
                Obj.CodigoBarras = CodigoBarras;
                Obj.IdMarca = IdMarca;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(CodigoBarras);
                if (Existe.Equals("1"))
                {
                    return "El articulo ya existe";
                }
                else
                {
                    Obj.IdArticulo = IdArticulo;
                    Obj.Nombre = Nombre;
                    Obj.Modelo = Modelo;
                    Obj.Cantidad = Cantidad;
                    Obj.PrecioCompra = PrecioCompra;
                    Obj.FechaCompra = FechaCompra;
                    Obj.CodigoBarras = CodigoBarras;
                    Obj.IdMarca = IdMarca;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Activar(int Id)
        {
            DatArticulo Datos = new DatArticulo();
            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            DatArticulo Datos = new DatArticulo();
            return Datos.Desactivar(Id);
        }
    }
}
