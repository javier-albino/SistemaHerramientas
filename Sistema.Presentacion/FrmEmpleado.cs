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
    public partial class FrmEmpleado : Form
    {
        private string RutAnt;
        public FrmEmpleado()
        {
            InitializeComponent();
        }
        public void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 130;//departamento
            DgvListado.Columns[3].Width = 130;//puesto
            DgvListado.Columns[4].Width = 90;//rut
            DgvListado.Columns[5].Width = 130;//nombre
            DgvListado.Columns[6].Width = 130;//apellido
            DgvListado.Columns[7].Width = 60;//estado
        }
        private void Limpiar()
        {
            TxtId.Clear();
            TxtNombreEmp.Clear();
            TxtApellidoEmp.Clear();
            TxtRutEmp.Clear();
            CboPuestoEmp.Text = "";
            CboDepartamentoEmp.Text = "";
            TxtBuscar.Clear();
            BtnGuardarEmp.Enabled = false;
            BtnEditarEmp.Enabled = false;
            BtnActivarEmp.Enabled = false;
            BtnDesactivarEmp.Enabled = false;
            ErrorIcono.Clear();
        }
        private void ActivarControles()
        {
            TxtNombreEmp.Enabled = true;
            TxtApellidoEmp.Enabled = true;
            TxtRutEmp.Enabled = true;
            CboPuestoEmp.Enabled = true;
            CboDepartamentoEmp.Enabled = true;
            BtnGuardarEmp.Enabled = true;
            BtnCancelarEmp.Enabled = true;
            BtnEditarEmp.Enabled = true;
            BtnActivarEmp.Enabled = true;
            BtnDesactivarEmp.Enabled = true;
        }
        private void DesactivarControles()
        {
            TxtNombreEmp.Enabled = false;
            TxtApellidoEmp.Enabled = false;
            TxtRutEmp.Enabled = false;
            CboPuestoEmp.Enabled = false;
            CboDepartamentoEmp.Enabled = false;
            BtnGuardarEmp.Enabled = false;
            BtnCancelarEmp.Enabled = true;
            BtnEditarEmp.Enabled = false;
            BtnActivarEmp.Enabled = false;
            BtnDesactivarEmp.Enabled = false;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeAceptado(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CargarPuesto()
        {
            try
            {
                CboPuestoEmp.DataSource = NegPuesto.Seleccionar();
                CboPuestoEmp.ValueMember = "IdPuesto";
                CboPuestoEmp.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void CargarDepartamento()
        {
            try
            {
                CboDepartamentoEmp.DataSource = NegDepartamento.Seleccionar();
                CboDepartamentoEmp.ValueMember = "IdDepartamento";
                CboDepartamentoEmp.DisplayMember = "Nombre";
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
                DgvListado.DataSource = NegEmpleado.Listar();
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
                DgvListado.DataSource = NegEmpleado.Buscar(TxtBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.DesactivarControles();
            this.CargarPuesto();
            this.CargarDepartamento();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnNuevoEmp_Click(object sender, EventArgs e)
        {
            this.ActivarControles();
        }

        private void BtnGuardarEmp_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea guardar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtRutEmp.Text == string.Empty || TxtNombreEmp.Text == string.Empty
                        || TxtApellidoEmp.Text == string.Empty ||
                        CboPuestoEmp.Text == string.Empty || CboDepartamentoEmp.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtRutEmp, "Ingrese un rut");
                        ErrorIcono.SetError(TxtNombreEmp, "Ingrese un nombre");
                        ErrorIcono.SetError(TxtApellidoEmp, "Ingrese un apellido");
                        ErrorIcono.SetError(CboPuestoEmp, "Ingrese un puesto de trabajo");
                        ErrorIcono.SetError(CboDepartamentoEmp, "Ingrese un departamento");
                    }
                    else
                    {
                        Respuesta = NegEmpleado.Insertar(TxtRutEmp.Text.Trim(), TxtNombreEmp.Text.Trim(),
                                                         TxtApellidoEmp.Text.Trim(),
                                                         Convert.ToInt32(CboDepartamentoEmp.SelectedValue), Convert.ToInt32(CboPuestoEmp.SelectedValue));
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

        private void BtnEditarEmp_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea actualizar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtRutEmp.Text == string.Empty || TxtNombreEmp.Text == string.Empty
                        || TxtApellidoEmp.Text == string.Empty ||
                        CboPuestoEmp.Text == string.Empty || CboDepartamentoEmp.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtRutEmp, "Ingrese un rut");
                        ErrorIcono.SetError(TxtNombreEmp, "Ingrese un nombre");
                        ErrorIcono.SetError(TxtApellidoEmp, "Ingrese un apellido");
                        ErrorIcono.SetError(CboPuestoEmp, "Ingrese un puesto de trabajo");
                        ErrorIcono.SetError(CboDepartamentoEmp, "Ingrese un departamento");
                    }
                    else
                    {
                        Respuesta = NegEmpleado.Actualizar(Convert.ToInt32(TxtId.Text), this.RutAnt, TxtRutEmp.Text.Trim(), TxtNombreEmp.Text.Trim(),
                                                          TxtApellidoEmp.Text.Trim(), Convert.ToInt32(CboDepartamentoEmp.SelectedValue), Convert.ToInt32(CboPuestoEmp.SelectedValue));
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

        private void BtnActivarEmp_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea activar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtNombreEmp.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtNombreEmp, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegEmpleado.Activar(Convert.ToInt32(TxtId.Text));
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se activo su registro: " + TxtNombreEmp.Text);
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

        private void BtnDesactivarEmp_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea desactivar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtNombreEmp.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtNombreEmp, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegEmpleado.Desactivar(Convert.ToInt32(TxtId.Text));
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se desactivo su registro: " + TxtNombreEmp.Text);
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

        private void BtnCancelarEmp_Click(object sender, EventArgs e)
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
                BtnNuevoEmp.Enabled = false;
                BtnGuardarEmp.Enabled = false;
                BtnEditarEmp.Enabled = true;
                BtnActivarEmp.Enabled = true;
                BtnDesactivarEmp.Enabled = true;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Id"].Value);
                TxtNombreEmp.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombres"].Value);
                TxtApellidoEmp.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Apellidos"].Value);
                this.RutAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Rut"].Value);
                TxtRutEmp.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Rut"].Value);
                CboDepartamentoEmp.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Departamento"].Value);
                CboPuestoEmp.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Puesto"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "| Error: " + ex.Message);
            }
        }
    }
}
