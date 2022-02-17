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
    public partial class FrmPuesto : Form
    {
        private string NombreAnt;
        public FrmPuesto()
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
            TxtNombrePue.Clear();
            TxtDescripcionPue.Clear();
            TxtBuscar.Clear();
            BtnGuardarPue.Enabled = false;
            BtnEditarPue.Enabled = false;
            BtnActivarPue.Enabled = false;
            BtnDesactivarPue.Enabled = false;
            ErrorIcono.Clear();
        }
        private void ActivarControles()
        {
            TxtNombrePue.Enabled = true;
            TxtDescripcionPue.Enabled = true;
            BtnGuardarPue.Enabled = true;
            BtnCancelarPue.Enabled = true;
            BtnEditarPue.Enabled = true;
            BtnActivarPue.Enabled = true;
            BtnDesactivarPue.Enabled = true;
        }
        private void DesactivarControles()
        {
            TxtNombrePue.Enabled = false;
            TxtDescripcionPue.Enabled = false;
            BtnGuardarPue.Enabled = false;
            BtnCancelarPue.Enabled = true;
            BtnEditarPue.Enabled = false;
            BtnActivarPue.Enabled = false;
            BtnDesactivarPue.Enabled = false;
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
                DgvListado.DataSource = NegPuesto.Listar();
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
                DgvListado.DataSource = NegPuesto.Buscar(TxtBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmPuesto_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.DesactivarControles();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnNuevoPue_Click(object sender, EventArgs e)
        {
            this.ActivarControles();
        }

        private void BtnGuardarPue_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea guardar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtNombrePue.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtNombrePue, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegPuesto.Insertar(TxtNombrePue.Text.Trim(), TxtDescripcionPue.Text.Trim());
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

        private void BtnEditarPue_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea actualizar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtNombrePue.Text == string.Empty || TxtId.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtNombrePue, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegPuesto.Actualizar(Convert.ToInt32(TxtId.Text), this.NombreAnt, TxtNombrePue.Text.Trim(), TxtDescripcionPue.Text.Trim());
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se actualizo su registro: " + TxtNombrePue.Text);
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

        private void BtnActivarPue_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea activar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtNombrePue.Text == string.Empty || TxtId.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtNombrePue, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegPuesto.Activar(Convert.ToInt32(TxtId.Text));
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se activo su registro: " + TxtNombrePue.Text);
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

        private void BtnDesactivarPue_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea desactivar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtNombrePue.Text == string.Empty || TxtId.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtNombrePue, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegPuesto.Desactivar(Convert.ToInt32(TxtId.Text));
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se desactivo su registro: " + TxtNombrePue.Text);
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

        private void BtnCancelarPue_Click(object sender, EventArgs e)
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
                BtnNuevoPue.Enabled = false;
                BtnGuardarPue.Enabled = false;
                BtnEditarPue.Enabled = true;
                BtnActivarPue.Enabled = true;
                BtnDesactivarPue.Enabled = true;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Id"].Value);
                this.NombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtNombrePue.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtDescripcionPue.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "| Error: " + ex.Message);
            }
        }
    }
}
