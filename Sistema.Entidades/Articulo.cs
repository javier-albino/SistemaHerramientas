using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public int Cantidad { get; set; }
        public int PrecioCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public string CodigoBarras { get; set; }
        public bool Estado { get; set; }
        public int IdMarca { get; set; }
    }
}
