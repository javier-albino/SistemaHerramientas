using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;
        public int IdUsuario;
        public string Nombre;
        public string Rol;
        public bool Estado;
        public int IdRol;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        //private void FrmPrincipal_Load(object sender, EventArgs e)
        //{
        //    StBarraInferior.Text = "Desarrollado por Informatica Glover, Usuario: " + this.Nombre;
        //    MessageBox.Show("Bienvenido: " + this.Nombre, "Sistema Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    if (this.Rol.Equals("Administrador"))
        //    {
        //        MenuBodega.Enabled = true;
        //        MenuColaborador.Enabled = true;
        //        MenuEntregas.Enabled = true;
        //        MenuAccesos.Enabled = true;
        //    }
        //    else
        //    {
        //        if (this.Rol.Equals("Empleado"))
        //        {
        //            MenuBodega.Enabled = true;
        //            MenuColaborador.Enabled = true;
        //            MenuEntregas.Enabled = true;
        //            MenuAccesos.Enabled = false;
        //        }
        //        else
        //        {

        //            MenuBodega.Enabled = false;
        //            MenuColaborador.Enabled = false;
        //            MenuEntregas.Enabled = false;
        //            MenuAccesos.Enabled = false;

        //        }
        //    }
        //}
        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca form = new FrmMarca();
            form.MdiParent = this;
            form.Show();
            PanelInicial.Visible = false;
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticulo form = new FrmArticulo();
            form.MdiParent = this;
            form.Show();
            PanelInicial.Visible = false;
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartamento form = new FrmDepartamento();
            form.MdiParent = this;
            form.Show();
            PanelInicial.Visible = false;
        }

        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPuesto form = new FrmPuesto();
            form.MdiParent = this;
            form.Show();
            PanelInicial.Visible = false;
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleado form = new FrmEmpleado();
            form.MdiParent = this;
            form.Show();
            PanelInicial.Visible = false;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario form = new FrmUsuario();
            form.MdiParent = this;
            form.Show();
            PanelInicial.Visible = false;
        }

        private void entregasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEntregaArticulo form = new FrmEntregaArticulo();
            form.MdiParent = this;
            form.Show();
            PanelInicial.Visible = false;
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDevolucionArticulo form = new FrmDevolucionArticulo();
            form.MdiParent = this;
            form.Show();
            PanelInicial.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Desea salir del sistema?", "Sistema Inventario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
