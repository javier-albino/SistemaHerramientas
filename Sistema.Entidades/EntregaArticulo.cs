using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class EntregaArticulo
    {
        public int IdEntrega { get; set; }
        public string NumSerie { get; set; }
        public string Condicion { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int IdArticulo { get; set; }
        public int IdEmpleado { get; set; }
        public int IdUsuario { get; set; }
    }
}
