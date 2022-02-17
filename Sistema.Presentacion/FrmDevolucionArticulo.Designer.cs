
namespace Sistema.Presentacion
{
    partial class FrmDevolucionArticulo
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
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CboResponsableDev = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnDesactivarDev = new System.Windows.Forms.Button();
            this.CboArticuloDev = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CboMotivoDev = new System.Windows.Forms.ComboBox();
            this.DtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.CboEmpleadoDev = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnNuevaDev = new System.Windows.Forms.Button();
            this.BtnActivarDev = new System.Windows.Forms.Button();
            this.BtnEditarDev = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnCancelarDev = new System.Windows.Forms.Button();
            this.BtnGuardarDev = new System.Windows.Forms.Button();
            this.TxtSerieDev = new System.Windows.Forms.TextBox();
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
            this.TabGeneral.Location = new System.Drawing.Point(12, 28);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1880, 712);
            this.TabGeneral.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.BtnImprimir);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1872, 679);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(1042, 16);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(189, 37);
            this.BtnImprimir.TabIndex = 3;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
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
            this.DgvListado.Size = new System.Drawing.Size(1835, 407);
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
            this.tabPage2.Controls.Add(this.CboResponsableDev);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.BtnDesactivarDev);
            this.tabPage2.Controls.Add(this.CboArticuloDev);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.CboMotivoDev);
            this.tabPage2.Controls.Add(this.DtpFechaDevolucion);
            this.tabPage2.Controls.Add(this.CboEmpleadoDev);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.BtnNuevaDev);
            this.tabPage2.Controls.Add(this.BtnActivarDev);
            this.tabPage2.Controls.Add(this.BtnEditarDev);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.BtnCancelarDev);
            this.tabPage2.Controls.Add(this.BtnGuardarDev);
            this.tabPage2.Controls.Add(this.TxtSerieDev);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1872, 679);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenedor";
            // 
            // CboResponsableDev
            // 
            this.CboResponsableDev.FormattingEnabled = true;
            this.CboResponsableDev.Location = new System.Drawing.Point(412, 552);
            this.CboResponsableDev.Name = "CboResponsableDev";
            this.CboResponsableDev.Size = new System.Drawing.Size(319, 28);
            this.CboResponsableDev.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(87, 555);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 25);
            this.label10.TabIndex = 49;
            this.label10.Text = "Tecnico Responsable(*)";
            // 
            // BtnDesactivarDev
            // 
            this.BtnDesactivarDev.Location = new System.Drawing.Point(1324, 306);
            this.BtnDesactivarDev.Name = "BtnDesactivarDev";
            this.BtnDesactivarDev.Size = new System.Drawing.Size(242, 42);
            this.BtnDesactivarDev.TabIndex = 30;
            this.BtnDesactivarDev.Text = "Desactivar Devolucion";
            this.BtnDesactivarDev.UseVisualStyleBackColor = true;
            this.BtnDesactivarDev.Click += new System.EventHandler(this.BtnDesactivarDev_Click);
            // 
            // CboArticuloDev
            // 
            this.CboArticuloDev.FormattingEnabled = true;
            this.CboArticuloDev.Location = new System.Drawing.Point(412, 324);
            this.CboArticuloDev.Name = "CboArticuloDev";
            this.CboArticuloDev.Size = new System.Drawing.Size(319, 28);
            this.CboArticuloDev.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Articulo(*)";
            // 
            // CboMotivoDev
            // 
            this.CboMotivoDev.FormattingEnabled = true;
            this.CboMotivoDev.Items.AddRange(new object[] {
            "Malo",
            "Reparacion",
            "Garantia",
            "Desvinculacion"});
            this.CboMotivoDev.Location = new System.Drawing.Point(412, 218);
            this.CboMotivoDev.Name = "CboMotivoDev";
            this.CboMotivoDev.Size = new System.Drawing.Size(319, 28);
            this.CboMotivoDev.TabIndex = 27;
            // 
            // DtpFechaDevolucion
            // 
            this.DtpFechaDevolucion.Location = new System.Drawing.Point(412, 121);
            this.DtpFechaDevolucion.Name = "DtpFechaDevolucion";
            this.DtpFechaDevolucion.Size = new System.Drawing.Size(319, 26);
            this.DtpFechaDevolucion.TabIndex = 26;
            // 
            // CboEmpleadoDev
            // 
            this.CboEmpleadoDev.FormattingEnabled = true;
            this.CboEmpleadoDev.Location = new System.Drawing.Point(412, 444);
            this.CboEmpleadoDev.Name = "CboEmpleadoDev";
            this.CboEmpleadoDev.Size = new System.Drawing.Size(319, 28);
            this.CboEmpleadoDev.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 443);
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
            this.label4.Size = new System.Drawing.Size(214, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Motivo Devolucion(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha Devolucion(*)";
            // 
            // BtnNuevaDev
            // 
            this.BtnNuevaDev.Location = new System.Drawing.Point(1203, 89);
            this.BtnNuevaDev.Name = "BtnNuevaDev";
            this.BtnNuevaDev.Size = new System.Drawing.Size(243, 42);
            this.BtnNuevaDev.TabIndex = 10;
            this.BtnNuevaDev.Text = "Nueva Devolucion";
            this.BtnNuevaDev.UseVisualStyleBackColor = true;
            this.BtnNuevaDev.Click += new System.EventHandler(this.BtnNuevaDev_Click);
            // 
            // BtnActivarDev
            // 
            this.BtnActivarDev.Location = new System.Drawing.Point(1038, 306);
            this.BtnActivarDev.Name = "BtnActivarDev";
            this.BtnActivarDev.Size = new System.Drawing.Size(242, 42);
            this.BtnActivarDev.TabIndex = 9;
            this.BtnActivarDev.Text = "Activar Devolucion";
            this.BtnActivarDev.UseVisualStyleBackColor = true;
            this.BtnActivarDev.Click += new System.EventHandler(this.BtnActivarDev_Click);
            // 
            // BtnEditarDev
            // 
            this.BtnEditarDev.Location = new System.Drawing.Point(1324, 187);
            this.BtnEditarDev.Name = "BtnEditarDev";
            this.BtnEditarDev.Size = new System.Drawing.Size(243, 42);
            this.BtnEditarDev.TabIndex = 8;
            this.BtnEditarDev.Text = "Editar Devolucion";
            this.BtnEditarDev.UseVisualStyleBackColor = true;
            this.BtnEditarDev.Click += new System.EventHandler(this.BtnEditarDev_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(1593, 89);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(49, 26);
            this.TxtId.TabIndex = 7;
            this.TxtId.Visible = false;
            // 
            // BtnCancelarDev
            // 
            this.BtnCancelarDev.Location = new System.Drawing.Point(1191, 411);
            this.BtnCancelarDev.Name = "BtnCancelarDev";
            this.BtnCancelarDev.Size = new System.Drawing.Size(242, 42);
            this.BtnCancelarDev.TabIndex = 6;
            this.BtnCancelarDev.Text = "Cancelar";
            this.BtnCancelarDev.UseVisualStyleBackColor = true;
            this.BtnCancelarDev.Click += new System.EventHandler(this.BtnCancelarDev_Click);
            // 
            // BtnGuardarDev
            // 
            this.BtnGuardarDev.Location = new System.Drawing.Point(1037, 187);
            this.BtnGuardarDev.Name = "BtnGuardarDev";
            this.BtnGuardarDev.Size = new System.Drawing.Size(243, 42);
            this.BtnGuardarDev.TabIndex = 5;
            this.BtnGuardarDev.Text = "Guardar Devolucion";
            this.BtnGuardarDev.UseVisualStyleBackColor = true;
            this.BtnGuardarDev.Click += new System.EventHandler(this.BtnGuardarDev_Click);
            // 
            // TxtSerieDev
            // 
            this.TxtSerieDev.Location = new System.Drawing.Point(412, 32);
            this.TxtSerieDev.Name = "TxtSerieDev";
            this.TxtSerieDev.Size = new System.Drawing.Size(319, 26);
            this.TxtSerieDev.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(538, 638);
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
            this.LblTotal.Location = new System.Drawing.Point(1049, 798);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(68, 25);
            this.LblTotal.TabIndex = 51;
            this.LblTotal.Text = "Total:";
            // 
            // FrmDevolucionArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1904, 954);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmDevolucionArticulo";
            this.Text = "Ingreso De Devoluciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDevolucionArticulo_Load);
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
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox CboResponsableDev;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnDesactivarDev;
        private System.Windows.Forms.ComboBox CboArticuloDev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboMotivoDev;
        private System.Windows.Forms.DateTimePicker DtpFechaDevolucion;
        private System.Windows.Forms.ComboBox CboEmpleadoDev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnNuevaDev;
        private System.Windows.Forms.Button BtnActivarDev;
        private System.Windows.Forms.Button BtnEditarDev;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnCancelarDev;
        private System.Windows.Forms.Button BtnGuardarDev;
        private System.Windows.Forms.TextBox TxtSerieDev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Label LblTotal;
    }
}