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
    public partial class FrmMarca : Form
    {
        private string NombreAnt;
        public FrmMarca()
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
            TxtNombreMar.Clear();
            TxtDescripcionMar.Clear();
            TxtBuscar.Clear();
            BtnGuardarMar.Enabled = false;
            BtnEditarMar.Enabled = false;
            BtnActivarMar.Enabled = false;
            BtnActivarMar.Enabled = false;
            BtnDesactivarMar.Enabled = false;
            ErrorIcono.Clear();
        }
        private void ActivarControles()
        {
            TxtNombreMar.Enabled = true;
            TxtDescripcionMar.Enabled = true;
            BtnGuardarMar.Enabled = true;
            BtnEditarMar.Enabled = true;
            BtnCancelarMar.Enabled = true;
            BtnActivarMar.Enabled = true;
            BtnDesactivarMar.Enabled = true;
        }
        private void DesactivarControles()
        {
            TxtNombreMar.Enabled = false;
            TxtDescripcionMar.Enabled = false;
            BtnGuardarMar.Enabled = false;
            BtnEditarMar.Enabled = false;
            BtnCancelarMar.Enabled = true;
            BtnActivarMar.Enabled = false;
            BtnDesactivarMar.Enabled = false;
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
                DgvListado.DataSource = NegMarca.Listar();
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
                DgvListado.DataSource = NegMarca.Buscar(TxtBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.DesactivarControles();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
        private void BtnNuevaMar_Click(object sender, EventArgs e)
        {
            this.ActivarControles();
        }

        private void BtnGuardarMar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea guardar el registro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = null;
                    if (TxtNombreMar.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos seran marcados");
                        ErrorIcono.SetError(TxtNombreMar, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegMarca.Insertar(TxtNombreMar.Text.Trim(), TxtDescripcionMar.Text.Trim());
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

        private void BtnEditarMar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea actualizar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtNombreMar.Text == string.Empty || TxtId.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtNombreMar, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegMarca.Actualizar(Convert.ToInt32(TxtId.Text), this.NombreAnt, TxtNombreMar.Text.Trim(), TxtDescripcionMar.Text.Trim());
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se actualizo su registro: " + TxtNombreMar.Text);
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

        private void BtnActivarMar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea activar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtNombreMar.Text == string.Empty || TxtId.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtNombreMar, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegMarca.Activar(Convert.ToInt32(TxtId.Text));
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se activo su registro: " + TxtNombreMar.Text);
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

        private void BtnDesactivarMar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea desactivar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtNombreMar.Text == string.Empty || TxtId.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtNombreMar, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegMarca.Desactivar(Convert.ToInt32(TxtId.Text));
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se desactivo su registro: " + TxtNombreMar.Text);
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

        private void BtnCancelarMar_Click(object sender, EventArgs e)
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
                BtnNuevaMar.Enabled = false;
                BtnGuardarMar.Enabled = false;
                BtnEditarMar.Enabled = true;
                BtnActivarMar.Enabled = true;
                BtnDesactivarMar.Enabled = true;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Id"].Value);
                this.NombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtNombreMar.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtDescripcionMar.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "| Error: " + ex.Message);
            }
        }
    }
}
