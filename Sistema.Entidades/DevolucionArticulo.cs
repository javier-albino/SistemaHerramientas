using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class DevolucionArticulo
    {
        public int IdDevolucion { get; set; }
        public string NumSerie { get; set; }
        public string MotivoDevolucion { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public bool Estado { get; set; }
        public int IdArticulo { get; set; }
        public int IdEmpleado { get; set; }
        public int IdUsuario { get; set; }
    }
}
