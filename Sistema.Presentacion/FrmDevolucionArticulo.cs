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
    public partial class FrmDevolucionArticulo : Form
    {
        private string NumAnt;
        public FrmDevolucionArticulo()
        {
            InitializeComponent();
        }
        public void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 150;//articulo
            DgvListado.Columns[3].Width = 90;//modelo
            DgvListado.Columns[4].Width = 190;//empleado
            DgvListado.Columns[5].Width = 90;//serie
            DgvListado.Columns[6].Width = 90;//devolucion
            DgvListado.Columns[7].Width = 90;//motivo
            DgvListado.Columns[8].Width = 190;//responsable
            DgvListado.Columns[9].Width = 60;//estado
        }
        private void Limpiar()
        {
            TxtId.Clear();
            TxtSerieDev.Clear();
            DtpFechaDevolucion.Text = "";
            CboMotivoDev.Text = "";
            CboArticuloDev.Text = "";
            CboEmpleadoDev.Text = "";
            CboResponsableDev.Text = "";
            TxtBuscar.Clear();
            BtnGuardarDev.Enabled = false;
            BtnEditarDev.Enabled = false;
            BtnActivarDev.Enabled = false;
            BtnDesactivarDev.Enabled = false;
            ErrorIcono.Clear();
        }
        private void ActivarControles()
        {
            TxtSerieDev.Enabled = true;
            DtpFechaDevolucion.Enabled = true;
            CboMotivoDev.Enabled = true;
            CboArticuloDev.Enabled = true;
            CboEmpleadoDev.Enabled = true;
            CboResponsableDev.Enabled = true;
            BtnGuardarDev.Enabled = true;
            BtnCancelarDev.Enabled = true;
            BtnEditarDev.Enabled = true;
            BtnActivarDev.Enabled = true;
            BtnDesactivarDev.Enabled = true;
        }
        private void DesactivarControles()
        {
            TxtSerieDev.Enabled = false;
            DtpFechaDevolucion.Enabled = false;
            CboMotivoDev.Enabled = false;
            CboArticuloDev.Enabled = false;
            CboEmpleadoDev.Enabled = false;
            CboResponsableDev.Enabled = false;
            BtnGuardarDev.Enabled = false;
            BtnCancelarDev.Enabled = true;
            BtnEditarDev.Enabled = false;
            BtnActivarDev.Enabled = false;
            BtnDesactivarDev.Enabled = false;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeAceptado(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CargarArticulo()
        {
            try
            {
                CboArticuloDev.DataSource = NegArticulo.SeleccionarNombre();
                CboArticuloDev.ValueMember = "IdArticulo";
                CboArticuloDev.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void CargarEmpleado()
        {
            try
            {
                CboEmpleadoDev.DataSource = NegEmpleado.Seleccionar();
                CboEmpleadoDev.ValueMember = "IdEmpleado";
                CboEmpleadoDev.DisplayMember = "NombreCompleto";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void CargarResponsable()
        {
            try
            {
                CboResponsableDev.DataSource = NegUsuario.Seleccionar();
                CboResponsableDev.ValueMember = "IdUsuario";
                CboResponsableDev.DisplayMember = "NombreCompleto";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NegDevolucionArticulo.Listar();
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
                DgvListado.DataSource = NegDevolucionArticulo.Buscar(TxtBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmDevolucionArticulo_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.DesactivarControles();
            this.CargarArticulo();
            this.CargarEmpleado();
            this.CargarResponsable();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnNuevaDev_Click(object sender, EventArgs e)
        {
            this.ActivarControles();
        }

        private void BtnGuardarDev_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea guardar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtSerieDev.Text == string.Empty || DtpFechaDevolucion.Text == string.Empty || CboMotivoDev.Text == string.Empty
                        || CboArticuloDev.Text == string.Empty ||  CboEmpleadoDev.Text == string.Empty || CboResponsableDev.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtSerieDev, "Ingrese un numero de serie");
                        ErrorIcono.SetError(DtpFechaDevolucion, "Ingrese una fecha");
                        ErrorIcono.SetError(CboMotivoDev, "Ingrese un motivo");
                        ErrorIcono.SetError(CboArticuloDev, "Ingrese un articulo");
                        ErrorIcono.SetError(CboEmpleadoDev, "Ingrese un empleado");
                        ErrorIcono.SetError(CboResponsableDev, "Ingrese un responsable");
                    }
                    else
                    {
                        Respuesta = NegDevolucionArticulo.Insertar(TxtSerieDev.Text.Trim(), Convert.ToDateTime(DtpFechaDevolucion.Value), 
                                                                   Convert.ToString(CboMotivoDev.Text), Convert.ToInt32(CboArticuloDev.SelectedValue), 
                                                                   Convert.ToInt32(CboEmpleadoDev.SelectedValue), Convert.ToInt32(CboResponsableDev.SelectedValue));
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

        private void BtnEditarDev_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea guardar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtSerieDev.Text == string.Empty || DtpFechaDevolucion.Text == string.Empty || CboMotivoDev.Text == string.Empty
                        || CboArticuloDev.Text == string.Empty || CboEmpleadoDev.Text == string.Empty || CboResponsableDev.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtSerieDev, "Ingrese un numero de serie");
                        ErrorIcono.SetError(DtpFechaDevolucion, "Ingrese una fecha");
                        ErrorIcono.SetError(CboMotivoDev, "Ingrese un motivo");
                        ErrorIcono.SetError(CboArticuloDev, "Ingrese un articulo");
                        ErrorIcono.SetError(CboEmpleadoDev, "Ingrese un empleado");
                        ErrorIcono.SetError(CboResponsableDev, "Ingrese un responsable");
                    }
                    else
                    {
                        Respuesta = NegDevolucionArticulo.Actualizar(Convert.ToInt32(TxtId.Text), this.NumAnt, TxtSerieDev.Text.Trim(), Convert.ToDateTime(DtpFechaDevolucion.Value),
                                                                     Convert.ToString(CboMotivoDev.Text), Convert.ToInt32(CboArticuloDev.SelectedValue), 
                                                                     Convert.ToInt32(CboEmpleadoDev.SelectedValue), Convert.ToInt32(CboResponsableDev.SelectedValue));
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se actualizo su registro");
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

        private void BtnActivarDev_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea activar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtSerieDev.Text == string.Empty || TxtId.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtSerieDev, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegDevolucionArticulo.Activar(Convert.ToInt32(TxtId.Text));
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se activo su registro");
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

        private void BtnDesactivarDev_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea desactivar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtSerieDev.Text == string.Empty || TxtId.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtSerieDev, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegDevolucionArticulo.Desactivar(Convert.ToInt32(TxtId.Text));
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se desactivo su registro");
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

        private void BtnCancelarDev_Click(object sender, EventArgs e)
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
                BtnNuevaDev.Enabled = false;
                BtnGuardarDev.Enabled = false;
                BtnEditarDev.Enabled = true;
                BtnActivarDev.Enabled = true;
                BtnDesactivarDev.Enabled = true;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Id"].Value);
                this.NumAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Serie"].Value);
                TxtSerieDev.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Serie"].Value);
                DtpFechaDevolucion.Value = Convert.ToDateTime(DgvListado.CurrentRow.Cells["Devolucion"].Value);
                CboMotivoDev.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Motivo"].Value);
                CboResponsableDev.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Responsable"].Value);
                CboArticuloDev.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Articulo"].Value);
                CboEmpleadoDev.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Empleado"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "| Error: " + ex.Message);
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.FrmListadoDevolucion from = new Reportes.FrmListadoDevolucion();
            from.Buscar = TxtBuscar.Text;
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea imprimir infome?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    from.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
