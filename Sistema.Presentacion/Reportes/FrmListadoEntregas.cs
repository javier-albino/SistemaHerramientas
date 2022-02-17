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
    public partial class FrmListadoEntregas : Form
    {
        public FrmListadoEntregas()
        {
            InitializeComponent();
        }
        public string Buscar { get; set; }
        private void FrmListadoEntregas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsPrincipal.EntregaArticuloBuscar' Puede moverla o quitarla según sea necesario.
            this.EntregaArticuloBuscarTableAdapter.Fill(this.DsPrincipal.EntregaArticuloBuscar, Buscar);

            this.reportViewer1.RefreshReport();
        }
    }
}
