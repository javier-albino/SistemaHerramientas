using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;


namespace Sistema.Presentacion
{
    public partial class FrmDepartamento : Form
    {
        private string NombreAnt;
        public FrmDepartamento()
        {
            InitializeComponent();
        }
        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 280;
            DgvListado.Columns[3].Width = 400;
            DgvListado.Columns[3].HeaderText = "Descripción";
            DgvListado.Columns[4].Width = 100;
        }
        private void Limpiar()
        {
            TxtId.Clear();
            TxtNombreDep.Clear();
            TxtDescripcionDep.Clear();
            TxtBuscar.Clear();
            BtnGuardarDep.Enabled = false;
            BtnEditarDep.Enabled = false;
            BtnActivarDep.Enabled = false;
            BtnDesactivarDep.Enabled = false;
            BtnActivarDep.Enabled = false;
            BtnDesactivarDep.Enabled = false;
            ErrorIcono.Clear();
        }
        private void ActivarControles()
        {
            TxtNombreDep.Enabled = true;
            TxtDescripcionDep.Enabled = true;
            BtnGuardarDep.Enabled = true;
            BtnCancelarDep.Enabled = true;
            BtnEditarDep.Enabled = true;
            BtnActivarDep.Enabled = true;
            BtnDesactivarDep.Enabled = true;
        }
        private void DesactivarControles()
        {
            TxtNombreDep.Enabled = false;
            TxtDescripcionDep.Enabled = false;
            BtnGuardarDep.Enabled = false;
            BtnCancelarDep.Enabled = true;
            BtnEditarDep.Enabled = false;
            BtnActivarDep.Enabled = false;
            BtnDesactivarDep.Enabled = false;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeAceptado(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NegDepartamento.Listar();
                this.Formato();
                this.Limpiar();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NegDepartamento.Buscar(TxtBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.DesactivarControles();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnNuevoDep_Click(object sender, EventArgs e)
        {
            this.ActivarControles();
        }

        private void BtnGuardarDep_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea guardar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtNombreDep.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtNombreDep, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegDepartamento.Insertar(TxtNombreDep.Text.Trim(), TxtDescripcionDep.Text.Trim());
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se guardo su registro");
                            this.Limpiar();
                            this.Listar();
                        }
                        else
                        {
                            this.MensajeError(Respuesta);
                        }
                    }
                    this.DesactivarControles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnEditarDep_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea actualizar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtNombreDep.Text == string.Empty || TxtId.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtNombreDep, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegDepartamento.Actualizar(Convert.ToInt32(TxtId.Text), this.NombreAnt, TxtNombreDep.Text.Trim(), TxtDescripcionDep.Text.Trim());
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se actualizo su registro: " + TxtNombreDep.Text);
                            this.Limpiar();
                            this.Listar();
                        }
                        else
                        {
                            this.MensajeError(Respuesta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnActivarDep_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea activar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtNombreDep.Text == string.Empty || TxtId.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtNombreDep, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegDepartamento.Activar(Convert.ToInt32(TxtId.Text));
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se activo su registro: " + TxtNombreDep.Text);
                            this.Limpiar();
                            this.Listar();
                        }
                        else
                        {
                            this.MensajeError(Respuesta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnDesactivarDep_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea desactivar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtNombreDep.Text == string.Empty || TxtId.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtNombreDep, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegDepartamento.Desactivar(Convert.ToInt32(TxtId.Text));
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se desactivo su registro: " + TxtNombreDep.Text);
                            this.Limpiar();
                            this.Listar();
                        }
                        else
                        {
                            this.MensajeError(Respuesta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCancelarDep_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.ActivarControles();
            TabGeneral.SelectedIndex = 0;
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                this.ActivarControles();
                BtnNuevoDep.Enabled = false;
                BtnGuardarDep.Enabled = false;
                BtnEditarDep.Enabled = true;
                BtnActivarDep.Enabled = true;
                BtnDesactivarDep.Enabled = true;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Id"].Value);
                this.NombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtNombreDep.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtDescripcionDep.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "| Error: " + ex.Message);
            }
        }
    }
}
