using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion.Reportes
{
    public partial class FrmListadoDevolucion : Form
    {
        public FrmListadoDevolucion()
        {
            InitializeComponent();
        }
        public string Buscar { get; set; }
        private void FrmListadoDevolucion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsPrincipal.DevolucionArticuloBuscar' Puede moverla o quitarla según sea necesario.
            this.DevolucionArticuloBuscarTableAdapter.Fill(this.DsPrincipal.DevolucionArticuloBuscar,Buscar);

            this.reportViewer1.RefreshReport();
        }
    }
}
