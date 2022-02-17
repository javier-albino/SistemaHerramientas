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
    public partial class FrmUsuario : Form
    {
        private string RutAnt;
        public FrmUsuario()
        {
            InitializeComponent();
        }
        public void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 160;//rut
            DgvListado.Columns[3].Width = 160;//nombres
            DgvListado.Columns[4].Width = 160;//apellido
            DgvListado.Columns[5].Width = 100;//rol
            DgvListado.Columns[6].Width = 100;//telefono
            DgvListado.Columns[7].Width = 160;//email
            DgvListado.Columns[8].Width = 60;//estado
        }
        private void Limpiar()
        {
            TxtId.Clear();
            TxtNombreUsu.Clear();
            TxtApellidoUsu.Clear();
            TxtRutUsu.Clear();
            TxtTelefonoUsu.Clear();
            TxtEmailUsu.Clear();
            TxtClaveUsu.Clear();
            CboRolUsu.Text = "";
            TxtBuscar.Clear();
            BtnGuardarUsu.Enabled = false;
            BtnEditarUsu.Enabled = false;
            BtnActivarUsu.Enabled = false;
            BtnDesactivarUsu.Enabled = false;
            ErrorIcono.Clear();
        }
        private void ActivarControles()
        {
            TxtNombreUsu.Enabled = true;
            TxtApellidoUsu.Enabled = true;
            TxtRutUsu.Enabled = true;
            TxtTelefonoUsu.Enabled = true;
            TxtEmailUsu.Enabled = true;
            TxtClaveUsu.Enabled = true;
            CboRolUsu.Enabled = true;
            BtnGuardarUsu.Enabled = true;
            BtnCancelarUsu.Enabled = true;
            BtnEditarUsu.Enabled = true;
            BtnActivarUsu.Enabled = true;
            BtnDesactivarUsu.Enabled = true;
        }
        private void DesactivarControles()
        {
            TxtNombreUsu.Enabled = false;
            TxtApellidoUsu.Enabled = false;
            TxtRutUsu.Enabled = false;
            TxtTelefonoUsu.Enabled = false;
            TxtEmailUsu.Enabled = false;
            TxtClaveUsu.Enabled = false;
            CboRolUsu.Enabled = false;
            BtnGuardarUsu.Enabled = false;
            BtnCancelarUsu.Enabled = true;
            BtnEditarUsu.Enabled = false;
            BtnActivarUsu.Enabled = false;
            BtnDesactivarUsu.Enabled = false;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeAceptado(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CargarRol()
        {
            try
            {
                CboRolUsu.DataSource = NegRol.Seleccionar();
                CboRolUsu.ValueMember = "IdRol";
                CboRolUsu.DisplayMember = "Nombre";
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
                DgvListado.DataSource = NegUsuario.Listar();
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
                DgvListado.DataSource = NegUsuario.Buscar(TxtBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.DesactivarControles();
            this.CargarRol();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnNuevoUsu_Click(object sender, EventArgs e)
        {
            this.ActivarControles();
        }

        private void BtnGuardarUsu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea guardar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtRutUsu.Text == string.Empty || TxtNombreUsu.Text == string.Empty || TxtApellidoUsu.Text == string.Empty ||
                        TxtTelefonoUsu.Text == string.Empty || TxtEmailUsu.Text == string.Empty ||
                        TxtClaveUsu.Text == string.Empty || CboRolUsu.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtRutUsu, "Ingrese un rut");
                        ErrorIcono.SetError(TxtNombreUsu, "Ingrese un nombre");
                        ErrorIcono.SetError(TxtApellidoUsu, "Ingrese un apellido");
                        ErrorIcono.SetError(TxtTelefonoUsu, "Ingrese un numero de telefono");
                        ErrorIcono.SetError(TxtEmailUsu, "Ingrese un email");
                        ErrorIcono.SetError(TxtClaveUsu, "Ingrese una clave");
                        ErrorIcono.SetError(CboRolUsu, "Ingrese un rol");
                    }
                    else
                    {
                        Respuesta = NegUsuario.Insertar(TxtRutUsu.Text.Trim(), TxtNombreUsu.Text.Trim(), TxtApellidoUsu.Text.Trim(),
                                                        TxtTelefonoUsu.Text.Trim(), TxtEmailUsu.Text.Trim(), TxtClaveUsu.Text.Trim(),
                                                        Convert.ToInt32(CboRolUsu.SelectedValue));
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

        private void BtnEditarUsu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea actualizar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtRutUsu.Text == string.Empty || TxtNombreUsu.Text == string.Empty || TxtApellidoUsu.Text == string.Empty ||
                        TxtTelefonoUsu.Text == string.Empty || TxtEmailUsu.Text == string.Empty ||
                        TxtClaveUsu.Text == string.Empty || CboRolUsu.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtRutUsu, "Ingrese un rut");
                        ErrorIcono.SetError(TxtNombreUsu, "Ingrese un nombre");
                        ErrorIcono.SetError(TxtApellidoUsu, "Ingrese un apellido");
                        ErrorIcono.SetError(TxtTelefonoUsu, "Ingrese un numero de telefono");
                        ErrorIcono.SetError(TxtEmailUsu, "Ingrese un email");
                        ErrorIcono.SetError(TxtClaveUsu, "Ingrese una clave");
                        ErrorIcono.SetError(CboRolUsu, "Ingrese un rol");
                    }
                    else
                    {
                        Respuesta = NegUsuario.Actualizar(Convert.ToInt32(TxtId.Text), this.RutAnt, TxtRutUsu.Text.Trim(), TxtNombreUsu.Text.Trim(),
                                                          TxtApellidoUsu.Text.Trim(), TxtTelefonoUsu.Text.Trim(), TxtEmailUsu.Text.Trim(),
                                                          TxtClaveUsu.Text.Trim(), Convert.ToInt32(CboRolUsu.SelectedValue));
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

        private void BtnActivarUsu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea activar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtNombreUsu.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtNombreUsu, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegUsuario.Activar(Convert.ToInt32(TxtId.Text));
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se activo su registro: " + TxtNombreUsu.Text);
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

        private void BtnDesactivarUsu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea desactivar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtNombreUsu.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtNombreUsu, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegUsuario.Desactivar(Convert.ToInt32(TxtId.Text));
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se desactivo su registro: " + TxtNombreUsu.Text);
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

        private void BtnCancelarUsu_Click(object sender, EventArgs e)
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
                BtnNuevoUsu.Enabled = false;
                BtnGuardarUsu.Enabled = false;
                BtnEditarUsu.Enabled = true;
                BtnActivarUsu.Enabled = true;
                BtnDesactivarUsu.Enabled = true;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Id"].Value);
                TxtNombreUsu.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombres"].Value);
                TxtApellidoUsu.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Apellidos"].Value);
                this.RutAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Rut"].Value);
                TxtRutUsu.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Rut"].Value);
                TxtTelefonoUsu.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Telefono"].Value);
                TxtEmailUsu.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                CboRolUsu.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Rol"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "| Error: " + ex.Message);
            }
        }
    }
}
