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
    public partial class FrmEntregaArticulo : Form
    {
        private string NumAnt;
        public FrmEntregaArticulo()
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
            DgvListado.Columns[6].Width = 90;//entrega
            DgvListado.Columns[7].Width = 90;//condicion
            DgvListado.Columns[8].Width = 190;//responsable
            DgvListado.Columns[9].Width = 60;//estado
        }
        private void Limpiar()
        {
            TxtId.Clear();
            TxtSerieEnt.Clear();
            DtpFechaEntrega.Text = "";
            CboCondicionEnt.Text = "";
            CboArticuloEnt.Text = "";
            CboEmpleadoEnt.Text = "";
            CboResponsableEnt.Text = "";
            TxtBuscar.Clear();
            BtnGuardarEnt.Enabled = false;
            BtnEditarEnt.Enabled = false;
            BtnActivarEnt.Enabled = false;
            BtnDesactivarEnt.Enabled = false;
            ErrorIcono.Clear();
        }
        private void ActivarControles()
        {
            TxtSerieEnt.Enabled = true;
            DtpFechaEntrega.Enabled = true;
            CboCondicionEnt.Enabled = true;
            CboArticuloEnt.Enabled = true;
            CboEmpleadoEnt.Enabled = true;
            CboResponsableEnt.Enabled = true;
            BtnGuardarEnt.Enabled = true;
            BtnCancelarEnt.Enabled = true;
            BtnEditarEnt.Enabled = true;
            BtnActivarEnt.Enabled = true;
            BtnDesactivarEnt.Enabled = true;
        }
        private void DesactivarControles()
        {
            TxtSerieEnt.Enabled = false;
            DtpFechaEntrega.Enabled = false;
            CboCondicionEnt.Enabled = false;
            CboArticuloEnt.Enabled = false;
            CboEmpleadoEnt.Enabled = false;
            CboResponsableEnt.Enabled = false;
            BtnGuardarEnt.Enabled = false;
            BtnCancelarEnt.Enabled = true;
            BtnEditarEnt.Enabled = false;
            BtnActivarEnt.Enabled = false;
            BtnDesactivarEnt.Enabled = false;
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
                CboArticuloEnt.DataSource = NegArticulo.SeleccionarNombre();
                CboArticuloEnt.ValueMember = "IdArticulo";
                CboArticuloEnt.DisplayMember = "Nombre";
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
                CboEmpleadoEnt.DataSource = NegEmpleado.Seleccionar();
                CboEmpleadoEnt.ValueMember = "IdEmpleado";
                CboEmpleadoEnt.DisplayMember = "NombreCompleto";
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
                CboResponsableEnt.DataSource = NegUsuario.Seleccionar();
                CboResponsableEnt.ValueMember = "IdUsuario";
                CboResponsableEnt.DisplayMember = "NombreCompleto";
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
                DgvListado.DataSource = NegEntregaArticulo.Listar();
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
                DgvListado.DataSource = NegEntregaArticulo.Buscar(TxtBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void FrmEntregaArticulo_Load(object sender, EventArgs e)
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

        private void BtnNuevaEnt_Click(object sender, EventArgs e)
        {
            this.ActivarControles();
        }

        private void BtnGuardarEnt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea guardar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtSerieEnt.Text == string.Empty || DtpFechaEntrega.Text == string.Empty || CboCondicionEnt.Text == string.Empty
                        || CboArticuloEnt.Text == string.Empty ||  CboEmpleadoEnt.Text == string.Empty
                        || CboResponsableEnt.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtSerieEnt, "Ingrese un nombre");
                        ErrorIcono.SetError(DtpFechaEntrega, "Ingrese una fecha");
                        ErrorIcono.SetError(CboCondicionEnt, "Ingrese un estado del articulo");
                        ErrorIcono.SetError(CboArticuloEnt, "Ingrese un articulo");
                        ErrorIcono.SetError(CboEmpleadoEnt, "Ingrese un empleado");
                    }
                    else
                    {
                        Respuesta = NegEntregaArticulo.Insertar(TxtSerieEnt.Text.Trim(), Convert.ToDateTime(DtpFechaEntrega.Value), Convert.ToString(CboCondicionEnt.Text),
                                                                Convert.ToInt32(CboArticuloEnt.SelectedValue), Convert.ToInt32(CboEmpleadoEnt.SelectedValue), Convert.ToInt32(CboResponsableEnt.SelectedValue));
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

        private void BtnEditarEnt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea guardar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtSerieEnt.Text == string.Empty || DtpFechaEntrega.Text == string.Empty || CboCondicionEnt.Text == string.Empty
                        || CboArticuloEnt.Text == string.Empty || CboEmpleadoEnt.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtSerieEnt, "Ingrese un nombre");
                        ErrorIcono.SetError(DtpFechaEntrega, "Ingrese una fecha");
                        ErrorIcono.SetError(CboCondicionEnt, "Ingrese un estado del articulo");
                        ErrorIcono.SetError(CboArticuloEnt, "Ingrese un articulo");
                        ErrorIcono.SetError(CboEmpleadoEnt, "Ingrese un empleado");
                    }
                    else
                    {
                        Respuesta = NegEntregaArticulo.Actualizar(Convert.ToInt32(TxtId.Text), this.NumAnt, TxtSerieEnt.Text.Trim(), Convert.ToDateTime(DtpFechaEntrega.Value), Convert.ToString(CboCondicionEnt.SelectedText),
                                                                 Convert.ToInt32(CboArticuloEnt.SelectedValue), 
                                                                 Convert.ToInt32(CboEmpleadoEnt.SelectedValue), Convert.ToInt32(CboResponsableEnt.SelectedValue));

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

        private void BtnActivarEnt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea activar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtSerieEnt.Text == string.Empty || TxtId.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtSerieEnt, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegEntregaArticulo.Activar(Convert.ToInt32(TxtId.Text));
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

        private void BtnDesactivarEnt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea desactivar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtSerieEnt.Text == string.Empty || TxtId.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtSerieEnt, "Ingrese un codigo");
                    }
                    else
                    {
                        Respuesta = NegEntregaArticulo.Desactivar(Convert.ToInt32(TxtId.Text));
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

        private void BtnCancelarEnt_Click(object sender, EventArgs e)
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
                BtnNuevaEnt.Enabled = false;
                BtnGuardarEnt.Enabled = false;
                BtnEditarEnt.Enabled = true;
                BtnActivarEnt.Enabled = true;
                BtnDesactivarEnt.Enabled = true;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Id"].Value);
                this.NumAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Serie"].Value);
                TxtSerieEnt.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Serie"].Value);
                DtpFechaEntrega.Value = Convert.ToDateTime(DgvListado.CurrentRow.Cells["Entrega"].Value);
                CboCondicionEnt.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Condicion"].Value);
                CboResponsableEnt.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Responsable"].Value);
                CboArticuloEnt.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Articulo"].Value);
                CboEmpleadoEnt.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Empleado"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "| Error: " + ex.Message);
            }
        }

        private void BtnReporteEnt_Click(object sender, EventArgs e)
        {
            Reportes.FrmListadoEntregas from = new Reportes.FrmListadoEntregas();
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
