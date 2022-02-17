
namespace Sistema.Presentacion
{
    partial class FrmEntregaArticulo
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
            this.BtnReporteEnt = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CboResponsableEnt = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnDesactivarEnt = new System.Windows.Forms.Button();
            this.CboArticuloEnt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CboCondicionEnt = new System.Windows.Forms.ComboBox();
            this.DtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.CboEmpleadoEnt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnNuevaEnt = new System.Windows.Forms.Button();
            this.BtnActivarEnt = new System.Windows.Forms.Button();
            this.BtnEditarEnt = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnCancelarEnt = new System.Windows.Forms.Button();
            this.BtnGuardarEnt = new System.Windows.Forms.Button();
            this.TxtSerieEnt = new System.Windows.Forms.TextBox();
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
            this.TabGeneral.Location = new System.Drawing.Point(12, 31);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1827, 759);
            this.TabGeneral.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.BtnReporteEnt);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1819, 726);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // BtnReporteEnt
            // 
            this.BtnReporteEnt.Location = new System.Drawing.Point(1015, 16);
            this.BtnReporteEnt.Name = "BtnReporteEnt";
            this.BtnReporteEnt.Size = new System.Drawing.Size(189, 34);
            this.BtnReporteEnt.TabIndex = 3;
            this.BtnReporteEnt.Text = "Imprimir Reporte";
            this.BtnReporteEnt.UseVisualStyleBackColor = true;
            this.BtnReporteEnt.Click += new System.EventHandler(this.BtnReporteEnt_Click);
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
            this.DgvListado.Size = new System.Drawing.Size(1769, 407);
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
            this.tabPage2.Controls.Add(this.CboResponsableEnt);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.BtnDesactivarEnt);
            this.tabPage2.Controls.Add(this.CboArticuloEnt);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.CboCondicionEnt);
            this.tabPage2.Controls.Add(this.DtpFechaEntrega);
            this.tabPage2.Controls.Add(this.CboEmpleadoEnt);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.BtnNuevaEnt);
            this.tabPage2.Controls.Add(this.BtnActivarEnt);
            this.tabPage2.Controls.Add(this.BtnEditarEnt);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.BtnCancelarEnt);
            this.tabPage2.Controls.Add(this.BtnGuardarEnt);
            this.tabPage2.Controls.Add(this.TxtSerieEnt);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1819, 726);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenedor";
            // 
            // CboResponsableEnt
            // 
            this.CboResponsableEnt.FormattingEnabled = true;
            this.CboResponsableEnt.Location = new System.Drawing.Point(377, 531);
            this.CboResponsableEnt.Name = "CboResponsableEnt";
            this.CboResponsableEnt.Size = new System.Drawing.Size(319, 28);
            this.CboResponsableEnt.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(87, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tecnico Responsable(*)";
            // 
            // BtnDesactivarEnt
            // 
            this.BtnDesactivarEnt.Location = new System.Drawing.Point(1286, 319);
            this.BtnDesactivarEnt.Name = "BtnDesactivarEnt";
            this.BtnDesactivarEnt.Size = new System.Drawing.Size(242, 42);
            this.BtnDesactivarEnt.TabIndex = 30;
            this.BtnDesactivarEnt.Text = "Desactivar Entrega";
            this.BtnDesactivarEnt.UseVisualStyleBackColor = true;
            this.BtnDesactivarEnt.Click += new System.EventHandler(this.BtnDesactivarEnt_Click);
            // 
            // CboArticuloEnt
            // 
            this.CboArticuloEnt.FormattingEnabled = true;
            this.CboArticuloEnt.Location = new System.Drawing.Point(376, 333);
            this.CboArticuloEnt.Name = "CboArticuloEnt";
            this.CboArticuloEnt.Size = new System.Drawing.Size(319, 28);
            this.CboArticuloEnt.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Articulo(*)";
            // 
            // CboCondicionEnt
            // 
            this.CboCondicionEnt.FormattingEnabled = true;
            this.CboCondicionEnt.Items.AddRange(new object[] {
            "Nuevo",
            "Traspaso",
            "Usado",
            "Reparado"});
            this.CboCondicionEnt.Location = new System.Drawing.Point(376, 224);
            this.CboCondicionEnt.Name = "CboCondicionEnt";
            this.CboCondicionEnt.Size = new System.Drawing.Size(319, 28);
            this.CboCondicionEnt.TabIndex = 27;
            // 
            // DtpFechaEntrega
            // 
            this.DtpFechaEntrega.Location = new System.Drawing.Point(376, 127);
            this.DtpFechaEntrega.Name = "DtpFechaEntrega";
            this.DtpFechaEntrega.Size = new System.Drawing.Size(319, 26);
            this.DtpFechaEntrega.TabIndex = 26;
            // 
            // CboEmpleadoEnt
            // 
            this.CboEmpleadoEnt.FormattingEnabled = true;
            this.CboEmpleadoEnt.Location = new System.Drawing.Point(378, 428);
            this.CboEmpleadoEnt.Name = "CboEmpleadoEnt";
            this.CboEmpleadoEnt.Size = new System.Drawing.Size(319, 28);
            this.CboEmpleadoEnt.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Empleado(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Condicion(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha Entrega(*)";
            // 
            // BtnNuevaEnt
            // 
            this.BtnNuevaEnt.Location = new System.Drawing.Point(1145, 92);
            this.BtnNuevaEnt.Name = "BtnNuevaEnt";
            this.BtnNuevaEnt.Size = new System.Drawing.Size(243, 42);
            this.BtnNuevaEnt.TabIndex = 10;
            this.BtnNuevaEnt.Text = "Nueva Entrega";
            this.BtnNuevaEnt.UseVisualStyleBackColor = true;
            this.BtnNuevaEnt.Click += new System.EventHandler(this.BtnNuevaEnt_Click);
            // 
            // BtnActivarEnt
            // 
            this.BtnActivarEnt.Location = new System.Drawing.Point(1000, 319);
            this.BtnActivarEnt.Name = "BtnActivarEnt";
            this.BtnActivarEnt.Size = new System.Drawing.Size(242, 42);
            this.BtnActivarEnt.TabIndex = 9;
            this.BtnActivarEnt.Text = "Activar Entrega";
            this.BtnActivarEnt.UseVisualStyleBackColor = true;
            this.BtnActivarEnt.Click += new System.EventHandler(this.BtnActivarEnt_Click);
            // 
            // BtnEditarEnt
            // 
            this.BtnEditarEnt.Location = new System.Drawing.Point(1286, 200);
            this.BtnEditarEnt.Name = "BtnEditarEnt";
            this.BtnEditarEnt.Size = new System.Drawing.Size(243, 42);
            this.BtnEditarEnt.TabIndex = 8;
            this.BtnEditarEnt.Text = "Editar Entrega";
            this.BtnEditarEnt.UseVisualStyleBackColor = true;
            this.BtnEditarEnt.Click += new System.EventHandler(this.BtnEditarEnt_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(1558, 100);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(49, 26);
            this.TxtId.TabIndex = 7;
            this.TxtId.Visible = false;
            // 
            // BtnCancelarEnt
            // 
            this.BtnCancelarEnt.Location = new System.Drawing.Point(1145, 441);
            this.BtnCancelarEnt.Name = "BtnCancelarEnt";
            this.BtnCancelarEnt.Size = new System.Drawing.Size(242, 42);
            this.BtnCancelarEnt.TabIndex = 6;
            this.BtnCancelarEnt.Text = "Cancelar";
            this.BtnCancelarEnt.UseVisualStyleBackColor = true;
            this.BtnCancelarEnt.Click += new System.EventHandler(this.BtnCancelarEnt_Click);
            // 
            // BtnGuardarEnt
            // 
            this.BtnGuardarEnt.Location = new System.Drawing.Point(999, 200);
            this.BtnGuardarEnt.Name = "BtnGuardarEnt";
            this.BtnGuardarEnt.Size = new System.Drawing.Size(243, 42);
            this.BtnGuardarEnt.TabIndex = 5;
            this.BtnGuardarEnt.Text = "Guardar Entrega";
            this.BtnGuardarEnt.UseVisualStyleBackColor = true;
            this.BtnGuardarEnt.Click += new System.EventHandler(this.BtnGuardarEnt_Click);
            // 
            // TxtSerieEnt
            // 
            this.TxtSerieEnt.Location = new System.Drawing.Point(376, 40);
            this.TxtSerieEnt.Name = "TxtSerieEnt";
            this.TxtSerieEnt.Size = new System.Drawing.Size(319, 26);
            this.TxtSerieEnt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(474, 646);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "(*)Dato Obligatorio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero De Serie(*)";
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(1010, 846);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(68, 25);
            this.LblTotal.TabIndex = 39;
            this.LblTotal.Text = "Total:";
            // 
            // FrmEntregaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1868, 958);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmEntregaArticulo";
            this.Text = "Ingreso De Entregas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEntregaArticulo_Load);
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
        private System.Windows.Forms.Button BtnReporteEnt;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox CboResponsableEnt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnDesactivarEnt;
        private System.Windows.Forms.ComboBox CboArticuloEnt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboCondicionEnt;
        private System.Windows.Forms.DateTimePicker DtpFechaEntrega;
        private System.Windows.Forms.ComboBox CboEmpleadoEnt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnNuevaEnt;
        private System.Windows.Forms.Button BtnActivarEnt;
        private System.Windows.Forms.Button BtnEditarEnt;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnCancelarEnt;
        private System.Windows.Forms.Button BtnGuardarEnt;
        private System.Windows.Forms.TextBox TxtSerieEnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Label LblTotal;
    }
}