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
using System.Drawing.Imaging;


namespace Sistema.Presentacion
{
    public partial class FrmArticulo : Form
    {
        private string NumAnt;
        public FrmArticulo()
        {
            InitializeComponent();
        }
        public void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 100;//marca
            DgvListado.Columns[3].Width = 150;//nombre
            DgvListado.Columns[4].Width = 150;//modelo
            DgvListado.Columns[5].Width = 60;//stock
            DgvListado.Columns[6].Width = 70;//disponibles
            DgvListado.Columns[7].Width = 100;//precio
            DgvListado.Columns[8].Width = 100;//fecha
            DgvListado.Columns[9].Width = 120;//codigo
            DgvListado.Columns[10].Width = 60;//estado
        }
        private void Limpiar()
        {
            TxtId.Clear();
            CboMarcaArt.Text = "";
            TxtNombreArt.Clear();
            TxtModeloArt.Clear();
            TxtStockArt.Clear();
            TxtPrecioArt.Clear();
            DtpFechaCompra.Text = "";
            TxtCodigoBarraArt.Clear();
            TxtBuscar.Clear();
            BtnGuardarArt.Enabled = false;
            BtnEditarArt.Enabled = false;
            BtnActivarArt.Enabled = false;
            BtnDesactivarArt.Enabled = false;
            ErrorIcono.Clear();
        }
        private void ActivarControles()
        {
            CboMarcaArt.Enabled = true;
            TxtNombreArt.Enabled = true;
            TxtModeloArt.Enabled = true;
            TxtStockArt.Enabled = true;
            TxtPrecioArt.Enabled = true;
            DtpFechaCompra.Enabled = true;
            TxtCodigoBarraArt.Enabled = true;
            BtnGuardarArt.Enabled = true;
            BtnCancelarArt.Enabled = true;
            BtnEditarArt.Enabled = true;
            BtnDesactivarArt.Enabled = true;
            BtnGenerarCodigo.Enabled = true;
        }
        private void DesactivarControles()
        {
            CboMarcaArt.Enabled = false;
            TxtNombreArt.Enabled = false;
            TxtModeloArt.Enabled = false;
            TxtStockArt.Enabled = false;
            TxtPrecioArt.Enabled = false;
            DtpFechaCompra.Enabled = false;
            TxtCodigoBarraArt.Enabled = false;
            BtnGuardarArt.Enabled = false;
            BtnCancelarArt.Enabled = true;
            BtnEditarArt.Enabled = false;
            BtnActivarArt.Enabled = false;
            BtnDesactivarArt.Enabled = false;
            BtnGuardarCodigo.Enabled = false;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeAceptado(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CargarMarca()
        {
            try
            {
                CboMarcaArt.DataSource = NegMarca.Seleccionar();
                CboMarcaArt.ValueMember = "IdMarca";
                CboMarcaArt.DisplayMember = "Nombre";
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
                DgvListado.DataSource = NegArticulo.Listar();
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
                DgvListado.DataSource = NegArticulo.Buscar(TxtBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarMarca();
            this.DesactivarControles();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnNuevoArt_Click(object sender, EventArgs e)
        {
            this.ActivarControles();
        }

        private void BtnGuardarArt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea guardar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (CboMarcaArt.Text == string.Empty || TxtNombreArt.Text == string.Empty || TxtModeloArt.Text == string.Empty ||
                        TxtStockArt.Text == string.Empty || TxtPrecioArt.Text == string.Empty || TxtCodigoBarraArt.Text == string.Empty || DtpFechaCompra.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(CboMarcaArt, "Ingrese una marca");
                        ErrorIcono.SetError(TxtNombreArt, "Ingrese un nombre");
                        ErrorIcono.SetError(TxtModeloArt, "Ingrese un modelo");
                        ErrorIcono.SetError(TxtStockArt, "Ingrese un stock");
                        ErrorIcono.SetError(TxtPrecioArt, "Ingrese un precio");
                        ErrorIcono.SetError(DtpFechaCompra, "Ingrese una fecha");
                        ErrorIcono.SetError(TxtCodigoBarraArt, "Ingrese un codigo");
                    }
                    else
                    {
                        Respuesta = NegArticulo.Insertar(TxtNombreArt.Text.Trim(), TxtModeloArt.Text.Trim(), Convert.ToInt32(TxtStockArt.Text.Trim()),
                                                         Convert.ToInt32(TxtPrecioArt.Text.Trim()), Convert.ToDateTime(DtpFechaCompra.Value),
                                                         TxtCodigoBarraArt.Text.Trim(), Convert.ToInt32(CboMarcaArt.SelectedValue));
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

        private void BtnEditarArt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea actualizar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (CboMarcaArt.Text == string.Empty || TxtNombreArt.Text == string.Empty || TxtModeloArt.Text == string.Empty ||
                        TxtStockArt.Text == string.Empty || TxtPrecioArt.Text == string.Empty || TxtCodigoBarraArt.Text == string.Empty || DtpFechaCompra.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(CboMarcaArt, "Ingrese una marca");
                        ErrorIcono.SetError(TxtNombreArt, "Ingrese un nombre");
                        ErrorIcono.SetError(TxtModeloArt, "Ingrese un modelo");
                        ErrorIcono.SetError(TxtStockArt, "Ingrese un stock");
                        ErrorIcono.SetError(TxtPrecioArt, "Ingrese un precio");
                        ErrorIcono.SetError(DtpFechaCompra, "Ingrese una fecha");
                        ErrorIcono.SetError(TxtCodigoBarraArt, "Ingrese un codigo");
                    }
                    else
                    {
                        Respuesta = NegArticulo.Actualizar(Convert.ToInt32(TxtId.Text), TxtNombreArt.Text.Trim(), TxtModeloArt.Text.Trim(), this.NumAnt,
                                                           Convert.ToInt32(TxtStockArt.Text.Trim()), Convert.ToInt32(TxtPrecioArt.Text.Trim()), Convert.ToDateTime(DtpFechaCompra.Value),
                                                           TxtCodigoBarraArt.Text.Trim(), Convert.ToInt32(CboMarcaArt.SelectedValue));
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

        private void BtnActivarArt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea activar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtModeloArt.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtModeloArt, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegArticulo.Activar(Convert.ToInt32(TxtId.Text));
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se activo su registro: " + TxtModeloArt.Text);
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

        private void BtnDesactivarArt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea desactivar el resgistro?", "Sistema Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Respuesta = "";
                    if (TxtModeloArt.Text == string.Empty)
                    {
                        this.MensajeError("Faltan datos, seran remarcados");
                        ErrorIcono.SetError(TxtModeloArt, "Ingrese un nombre");
                    }
                    else
                    {
                        Respuesta = NegArticulo.Desactivar(Convert.ToInt32(TxtId.Text));
                        if (Respuesta.Equals("Bueno"))
                        {
                            this.MensajeAceptado("Se desactivo su registro: " + TxtModeloArt.Text);
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

        private void BtnGenerarCodigo_Click(object sender, EventArgs e)
        {
            PanelCodigo.Visible = true;
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            PanelCodigo.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, TxtCodigoBarraArt.Text, Color.Black, Color.White, 400, 100);
            BtnGuardarCodigo.Enabled = true;
        }

        private void BtnGuardarCodigo_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)PanelCodigo.BackgroundImage.Clone();
            SaveFileDialog DialogoGuardar = new SaveFileDialog();
            DialogoGuardar.AddExtension = true;
            DialogoGuardar.Filter = "Imagen PNG (*.png) |*.png";
            DialogoGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(DialogoGuardar.FileName))
            {
                imgFinal.Save(DialogoGuardar.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
        }

        private void BtnCancelarArt_Click(object sender, EventArgs e)
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
                BtnNuevoArt.Enabled = false;
                BtnGuardarArt.Enabled = false;
                BtnEditarArt.Enabled = true;
                BtnActivarArt.Enabled = true;
                BtnDesactivarArt.Enabled = true;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Id"].Value);
                CboMarcaArt.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Marca"].Value);
                TxtNombreArt.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Articulo"].Value);
                TxtModeloArt.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Modelo"].Value);
                this.NumAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Codigo"].Value);
                TxtStockArt.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Stock"].Value);
                TxtPrecioArt.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Precio"].Value);
                DtpFechaCompra.Value = Convert.ToDateTime(DgvListado.CurrentRow.Cells["Fecha"].Value);
                TxtCodigoBarraArt.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Codigo"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "| Error: " + ex.Message);
            }
        }

        private void BtnReporteArt_Click(object sender, EventArgs e)
        {
            Reportes.FrmListadoArticulos from = new Reportes.FrmListadoArticulos();
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
