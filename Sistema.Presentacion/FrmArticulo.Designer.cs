
namespace Sistema.Presentacion
{
    partial class FrmArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnReporteArt = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtNombreArt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCodigoBarraArt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPrecioArt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtStockArt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PanelCodigo = new System.Windows.Forms.Panel();
            this.BtnGenerarCodigo = new System.Windows.Forms.Button();
            this.BtnGuardarCodigo = new System.Windows.Forms.Button();
            this.CboMarcaArt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnActivarArt = new System.Windows.Forms.Button();
            this.BtnDesactivarArt = new System.Windows.Forms.Button();
            this.BtnNuevoArt = new System.Windows.Forms.Button();
            this.BtnEditarArt = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnCancelarArt = new System.Windows.Forms.Button();
            this.BtnGuardarArt = new System.Windows.Forms.Button();
            this.TxtModeloArt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblTotal = new System.Windows.Forms.Label();
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Location = new System.Drawing.Point(12, 88);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1566, 816);
            this.TabGeneral.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.BtnReporteArt);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1558, 783);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // BtnReporteArt
            // 
            this.BtnReporteArt.Location = new System.Drawing.Point(1034, 15);
            this.BtnReporteArt.Name = "BtnReporteArt";
            this.BtnReporteArt.Size = new System.Drawing.Size(189, 39);
            this.BtnReporteArt.TabIndex = 3;
            this.BtnReporteArt.Text = "Imprimir Reporte";
            this.BtnReporteArt.UseVisualStyleBackColor = true;
            this.BtnReporteArt.Click += new System.EventHandler(this.BtnReporteArt_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(748, 16);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(189, 37);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(38, 27);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(650, 26);
            this.TxtBuscar.TabIndex = 1;
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(16, 77);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 62;
            this.DgvListado.RowTemplate.Height = 28;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1510, 407);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 8;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.TxtNombreArt);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.DtpFechaCompra);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.TxtCodigoBarraArt);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.TxtPrecioArt);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.TxtStockArt);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.PanelCodigo);
            this.tabPage2.Controls.Add(this.BtnGenerarCodigo);
            this.tabPage2.Controls.Add(this.BtnGuardarCodigo);
            this.tabPage2.Controls.Add(this.CboMarcaArt);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.BtnActivarArt);
            this.tabPage2.Controls.Add(this.BtnDesactivarArt);
            this.tabPage2.Controls.Add(this.BtnNuevoArt);
            this.tabPage2.Controls.Add(this.BtnEditarArt);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.BtnCancelarArt);
            this.tabPage2.Controls.Add(this.BtnGuardarArt);
            this.tabPage2.Controls.Add(this.TxtModeloArt);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1558, 783);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenedor";
            // 
            // TxtNombreArt
            // 
            this.TxtNombreArt.Location = new System.Drawing.Point(300, 129);
            this.TxtNombreArt.Name = "TxtNombreArt";
            this.TxtNombreArt.Size = new System.Drawing.Size(332, 26);
            this.TxtNombreArt.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nombre(*)";
            // 
            // DtpFechaCompra
            // 
            this.DtpFechaCompra.Location = new System.Drawing.Point(299, 539);
            this.DtpFechaCompra.Name = "DtpFechaCompra";
            this.DtpFechaCompra.Size = new System.Drawing.Size(333, 26);
            this.DtpFechaCompra.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Fecha Compra(*)";
            // 
            // TxtCodigoBarraArt
            // 
            this.TxtCodigoBarraArt.Location = new System.Drawing.Point(970, 36);
            this.TxtCodigoBarraArt.Name = "TxtCodigoBarraArt";
            this.TxtCodigoBarraArt.Size = new System.Drawing.Size(332, 26);
            this.TxtCodigoBarraArt.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(747, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Codigo Barras(*)";
            // 
            // TxtPrecioArt
            // 
            this.TxtPrecioArt.Location = new System.Drawing.Point(303, 417);
            this.TxtPrecioArt.Name = "TxtPrecioArt";
            this.TxtPrecioArt.Size = new System.Drawing.Size(332, 26);
            this.TxtPrecioArt.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Precio Compra(*)";
            // 
            // TxtStockArt
            // 
            this.TxtStockArt.Location = new System.Drawing.Point(302, 321);
            this.TxtStockArt.Name = "TxtStockArt";
            this.TxtStockArt.Size = new System.Drawing.Size(333, 26);
            this.TxtStockArt.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Stock(*)";
            // 
            // PanelCodigo
            // 
            this.PanelCodigo.Location = new System.Drawing.Point(732, 169);
            this.PanelCodigo.Name = "PanelCodigo";
            this.PanelCodigo.Size = new System.Drawing.Size(568, 150);
            this.PanelCodigo.TabIndex = 23;
            this.PanelCodigo.Visible = false;
            // 
            // BtnGenerarCodigo
            // 
            this.BtnGenerarCodigo.Location = new System.Drawing.Point(732, 103);
            this.BtnGenerarCodigo.Name = "BtnGenerarCodigo";
            this.BtnGenerarCodigo.Size = new System.Drawing.Size(243, 42);
            this.BtnGenerarCodigo.TabIndex = 22;
            this.BtnGenerarCodigo.Text = "Generar Codigo";
            this.BtnGenerarCodigo.UseVisualStyleBackColor = true;
            this.BtnGenerarCodigo.Click += new System.EventHandler(this.BtnGenerarCodigo_Click);
            // 
            // BtnGuardarCodigo
            // 
            this.BtnGuardarCodigo.Enabled = false;
            this.BtnGuardarCodigo.Location = new System.Drawing.Point(1057, 103);
            this.BtnGuardarCodigo.Name = "BtnGuardarCodigo";
            this.BtnGuardarCodigo.Size = new System.Drawing.Size(243, 42);
            this.BtnGuardarCodigo.TabIndex = 21;
            this.BtnGuardarCodigo.Text = "Guardar Codigo";
            this.BtnGuardarCodigo.UseVisualStyleBackColor = true;
            this.BtnGuardarCodigo.Click += new System.EventHandler(this.BtnGuardarCodigo_Click);
            // 
            // CboMarcaArt
            // 
            this.CboMarcaArt.FormattingEnabled = true;
            this.CboMarcaArt.Location = new System.Drawing.Point(300, 38);
            this.CboMarcaArt.Name = "CboMarcaArt";
            this.CboMarcaArt.Size = new System.Drawing.Size(330, 28);
            this.CboMarcaArt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Marca(*)";
            // 
            // BtnActivarArt
            // 
            this.BtnActivarArt.Location = new System.Drawing.Point(782, 581);
            this.BtnActivarArt.Name = "BtnActivarArt";
            this.BtnActivarArt.Size = new System.Drawing.Size(242, 42);
            this.BtnActivarArt.TabIndex = 12;
            this.BtnActivarArt.Text = "Activar Articulo";
            this.BtnActivarArt.UseVisualStyleBackColor = true;
            this.BtnActivarArt.Click += new System.EventHandler(this.BtnActivarArt_Click);
            // 
            // BtnDesactivarArt
            // 
            this.BtnDesactivarArt.Location = new System.Drawing.Point(1071, 581);
            this.BtnDesactivarArt.Name = "BtnDesactivarArt";
            this.BtnDesactivarArt.Size = new System.Drawing.Size(242, 42);
            this.BtnDesactivarArt.TabIndex = 11;
            this.BtnDesactivarArt.Text = "Desactivar Articulo";
            this.BtnDesactivarArt.UseVisualStyleBackColor = true;
            this.BtnDesactivarArt.Click += new System.EventHandler(this.BtnDesactivarArt_Click);
            // 
            // BtnNuevoArt
            // 
            this.BtnNuevoArt.Location = new System.Drawing.Point(921, 368);
            this.BtnNuevoArt.Name = "BtnNuevoArt";
            this.BtnNuevoArt.Size = new System.Drawing.Size(243, 42);
            this.BtnNuevoArt.TabIndex = 10;
            this.BtnNuevoArt.Text = "Nuevo Articulo";
            this.BtnNuevoArt.UseVisualStyleBackColor = true;
            this.BtnNuevoArt.Click += new System.EventHandler(this.BtnNuevoArt_Click);
            // 
            // BtnEditarArt
            // 
            this.BtnEditarArt.Location = new System.Drawing.Point(1071, 468);
            this.BtnEditarArt.Name = "BtnEditarArt";
            this.BtnEditarArt.Size = new System.Drawing.Size(243, 42);
            this.BtnEditarArt.TabIndex = 8;
            this.BtnEditarArt.Text = "Editar Articulo ";
            this.BtnEditarArt.UseVisualStyleBackColor = true;
            this.BtnEditarArt.Click += new System.EventHandler(this.BtnEditarArt_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(1326, 357);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(49, 26);
            this.TxtId.TabIndex = 7;
            this.TxtId.Visible = false;
            // 
            // BtnCancelarArt
            // 
            this.BtnCancelarArt.Location = new System.Drawing.Point(922, 681);
            this.BtnCancelarArt.Name = "BtnCancelarArt";
            this.BtnCancelarArt.Size = new System.Drawing.Size(242, 42);
            this.BtnCancelarArt.TabIndex = 6;
            this.BtnCancelarArt.Text = "Cancelar";
            this.BtnCancelarArt.UseVisualStyleBackColor = true;
            this.BtnCancelarArt.Click += new System.EventHandler(this.BtnCancelarArt_Click);
            // 
            // BtnGuardarArt
            // 
            this.BtnGuardarArt.Location = new System.Drawing.Point(781, 468);
            this.BtnGuardarArt.Name = "BtnGuardarArt";
            this.BtnGuardarArt.Size = new System.Drawing.Size(243, 42);
            this.BtnGuardarArt.TabIndex = 5;
            this.BtnGuardarArt.Text = "Guardar Articulo";
            this.BtnGuardarArt.UseVisualStyleBackColor = true;
            this.BtnGuardarArt.Click += new System.EventHandler(this.BtnGuardarArt_Click);
            // 
            // TxtModeloArt
            // 
            this.TxtModeloArt.Location = new System.Drawing.Point(300, 220);
            this.TxtModeloArt.Name = "TxtModeloArt";
            this.TxtModeloArt.Size = new System.Drawing.Size(332, 26);
            this.TxtModeloArt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 698);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "(*)Dato Obligatorio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo(*)";
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(743, 19);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(68, 25);
            this.LblTotal.TabIndex = 10;
            this.LblTotal.Text = "Total:";
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1720, 938);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmArticulo";
            this.Text = "Ingreso De Articulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnReporteArt;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtNombreArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechaCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtCodigoBarraArt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPrecioArt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtStockArt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PanelCodigo;
        private System.Windows.Forms.Button BtnGenerarCodigo;
        private System.Windows.Forms.Button BtnGuardarCodigo;
        private System.Windows.Forms.ComboBox CboMarcaArt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnActivarArt;
        private System.Windows.Forms.Button BtnDesactivarArt;
        private System.Windows.Forms.Button BtnNuevoArt;
        private System.Windows.Forms.Button BtnEditarArt;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnCancelarArt;
        private System.Windows.Forms.Button BtnGuardarArt;
        private System.Windows.Forms.TextBox TxtModeloArt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Label LblTotal;
    }
}