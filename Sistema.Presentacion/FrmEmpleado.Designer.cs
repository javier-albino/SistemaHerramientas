
namespace Sistema.Presentacion
{
    partial class FrmEmpleado
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
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtApellidoEmp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CboDepartamentoEmp = new System.Windows.Forms.ComboBox();
            this.CboPuestoEmp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtRutEmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDesactivarEmp = new System.Windows.Forms.Button();
            this.BtnActivarEmp = new System.Windows.Forms.Button();
            this.BtnNuevoEmp = new System.Windows.Forms.Button();
            this.BtnEditarEmp = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnCancelarEmp = new System.Windows.Forms.Button();
            this.BtnGuardarEmp = new System.Windows.Forms.Button();
            this.TxtNombreEmp = new System.Windows.Forms.TextBox();
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
            this.TabGeneral.Location = new System.Drawing.Point(12, 73);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1537, 651);
            this.TabGeneral.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1529, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
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
            this.DgvListado.Size = new System.Drawing.Size(1496, 407);
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
            this.tabPage2.Controls.Add(this.TxtApellidoEmp);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.CboDepartamentoEmp);
            this.tabPage2.Controls.Add(this.CboPuestoEmp);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.TxtRutEmp);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.BtnDesactivarEmp);
            this.tabPage2.Controls.Add(this.BtnActivarEmp);
            this.tabPage2.Controls.Add(this.BtnNuevoEmp);
            this.tabPage2.Controls.Add(this.BtnEditarEmp);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.BtnCancelarEmp);
            this.tabPage2.Controls.Add(this.BtnGuardarEmp);
            this.tabPage2.Controls.Add(this.TxtNombreEmp);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1529, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenedor";
            // 
            // TxtApellidoEmp
            // 
            this.TxtApellidoEmp.Location = new System.Drawing.Point(316, 269);
            this.TxtApellidoEmp.Name = "TxtApellidoEmp";
            this.TxtApellidoEmp.Size = new System.Drawing.Size(319, 26);
            this.TxtApellidoEmp.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Apellidos(*)";
            // 
            // CboDepartamentoEmp
            // 
            this.CboDepartamentoEmp.FormattingEnabled = true;
            this.CboDepartamentoEmp.Location = new System.Drawing.Point(316, 365);
            this.CboDepartamentoEmp.Name = "CboDepartamentoEmp";
            this.CboDepartamentoEmp.Size = new System.Drawing.Size(319, 28);
            this.CboDepartamentoEmp.TabIndex = 23;
            // 
            // CboPuestoEmp
            // 
            this.CboPuestoEmp.FormattingEnabled = true;
            this.CboPuestoEmp.Location = new System.Drawing.Point(316, 459);
            this.CboPuestoEmp.Name = "CboPuestoEmp";
            this.CboPuestoEmp.Size = new System.Drawing.Size(319, 28);
            this.CboPuestoEmp.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Departamento(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Puesto(*)";
            // 
            // TxtRutEmp
            // 
            this.TxtRutEmp.Location = new System.Drawing.Point(312, 80);
            this.TxtRutEmp.Name = "TxtRutEmp";
            this.TxtRutEmp.Size = new System.Drawing.Size(319, 26);
            this.TxtRutEmp.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rut(*)";
            // 
            // BtnDesactivarEmp
            // 
            this.BtnDesactivarEmp.Location = new System.Drawing.Point(1104, 310);
            this.BtnDesactivarEmp.Name = "BtnDesactivarEmp";
            this.BtnDesactivarEmp.Size = new System.Drawing.Size(243, 42);
            this.BtnDesactivarEmp.TabIndex = 13;
            this.BtnDesactivarEmp.Text = "Desactivar Empleado";
            this.BtnDesactivarEmp.UseVisualStyleBackColor = true;
            this.BtnDesactivarEmp.Click += new System.EventHandler(this.BtnDesactivarEmp_Click);
            // 
            // BtnActivarEmp
            // 
            this.BtnActivarEmp.Location = new System.Drawing.Point(827, 310);
            this.BtnActivarEmp.Name = "BtnActivarEmp";
            this.BtnActivarEmp.Size = new System.Drawing.Size(242, 42);
            this.BtnActivarEmp.TabIndex = 12;
            this.BtnActivarEmp.Text = "Activar Empleado";
            this.BtnActivarEmp.UseVisualStyleBackColor = true;
            this.BtnActivarEmp.Click += new System.EventHandler(this.BtnActivarEmp_Click);
            // 
            // BtnNuevoEmp
            // 
            this.BtnNuevoEmp.Location = new System.Drawing.Point(964, 105);
            this.BtnNuevoEmp.Name = "BtnNuevoEmp";
            this.BtnNuevoEmp.Size = new System.Drawing.Size(243, 42);
            this.BtnNuevoEmp.TabIndex = 10;
            this.BtnNuevoEmp.Text = "Nuevo Empleado";
            this.BtnNuevoEmp.UseVisualStyleBackColor = true;
            this.BtnNuevoEmp.Click += new System.EventHandler(this.BtnNuevoEmp_Click);
            // 
            // BtnEditarEmp
            // 
            this.BtnEditarEmp.Location = new System.Drawing.Point(1105, 210);
            this.BtnEditarEmp.Name = "BtnEditarEmp";
            this.BtnEditarEmp.Size = new System.Drawing.Size(243, 42);
            this.BtnEditarEmp.TabIndex = 8;
            this.BtnEditarEmp.Text = "Editar Empleado";
            this.BtnEditarEmp.UseVisualStyleBackColor = true;
            this.BtnEditarEmp.Click += new System.EventHandler(this.BtnEditarEmp_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(1351, 31);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(49, 26);
            this.TxtId.TabIndex = 7;
            this.TxtId.Visible = false;
            // 
            // BtnCancelarEmp
            // 
            this.BtnCancelarEmp.Location = new System.Drawing.Point(965, 424);
            this.BtnCancelarEmp.Name = "BtnCancelarEmp";
            this.BtnCancelarEmp.Size = new System.Drawing.Size(242, 42);
            this.BtnCancelarEmp.TabIndex = 6;
            this.BtnCancelarEmp.Text = "Cancelar";
            this.BtnCancelarEmp.UseVisualStyleBackColor = true;
            this.BtnCancelarEmp.Click += new System.EventHandler(this.BtnCancelarEmp_Click);
            // 
            // BtnGuardarEmp
            // 
            this.BtnGuardarEmp.Location = new System.Drawing.Point(827, 210);
            this.BtnGuardarEmp.Name = "BtnGuardarEmp";
            this.BtnGuardarEmp.Size = new System.Drawing.Size(243, 42);
            this.BtnGuardarEmp.TabIndex = 5;
            this.BtnGuardarEmp.Text = "Guardar Empleado";
            this.BtnGuardarEmp.UseVisualStyleBackColor = true;
            this.BtnGuardarEmp.Click += new System.EventHandler(this.BtnGuardarEmp_Click);
            // 
            // TxtNombreEmp
            // 
            this.TxtNombreEmp.Location = new System.Drawing.Point(312, 169);
            this.TxtNombreEmp.Name = "TxtNombreEmp";
            this.TxtNombreEmp.Size = new System.Drawing.Size(319, 26);
            this.TxtNombreEmp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(960, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "(*)Dato Obligatorio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres(*)";
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(838, 29);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(68, 25);
            this.LblTotal.TabIndex = 9;
            this.LblTotal.Text = "Total:";
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1652, 804);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmEmpleado";
            this.Text = "Ingreso De Empleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
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
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtApellidoEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboDepartamentoEmp;
        private System.Windows.Forms.ComboBox CboPuestoEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtRutEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDesactivarEmp;
        private System.Windows.Forms.Button BtnActivarEmp;
        private System.Windows.Forms.Button BtnNuevoEmp;
        private System.Windows.Forms.Button BtnEditarEmp;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnCancelarEmp;
        private System.Windows.Forms.Button BtnGuardarEmp;
        private System.Windows.Forms.TextBox TxtNombreEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Label LblTotal;
    }
}