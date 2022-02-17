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
    public partial class FrmListadoArticulos : Form
    {
        public FrmListadoArticulos()
        {
            InitializeComponent();
        }
        public string Buscar { get; set; }
        private void FrmListadoArticulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsPrincipal.ArticuloBuscar' Puede moverla o quitarla según sea necesario.
            this.ArticuloBuscarTableAdapter.Fill(this.DsPrincipal.ArticuloBuscar, Buscar);

            this.reportViewer1.RefreshReport();
        }
    }
}
