
namespace Sistema.Presentacion
{
    partial class FrmDepartamento
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
            this.BtnDesactivarDep = new System.Windows.Forms.Button();
            this.BtnActivarDep = new System.Windows.Forms.Button();
            this.BtnNuevoDep = new System.Windows.Forms.Button();
            this.BtnEditarDep = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnCancelarDep = new System.Windows.Forms.Button();
            this.BtnGuardarDep = new System.Windows.Forms.Button();
            this.TxtDescripcionDep = new System.Windows.Forms.TextBox();
            this.TxtNombreDep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.TabGeneral.Location = new System.Drawing.Point(12, 52);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1364, 533);
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
            this.tabPage1.Size = new System.Drawing.Size(1356, 500);
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
            this.DgvListado.Size = new System.Drawing.Size(1320, 407);
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
            this.tabPage2.Controls.Add(this.BtnDesactivarDep);
            this.tabPage2.Controls.Add(this.BtnActivarDep);
            this.tabPage2.Controls.Add(this.BtnNuevoDep);
            this.tabPage2.Controls.Add(this.BtnEditarDep);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.BtnCancelarDep);
            this.tabPage2.Controls.Add(this.BtnGuardarDep);
            this.tabPage2.Controls.Add(this.TxtDescripcionDep);
            this.tabPage2.Controls.Add(this.TxtNombreDep);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1356, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenedor";
            // 
            // BtnDesactivarDep
            // 
            this.BtnDesactivarDep.Location = new System.Drawing.Point(1005, 254);
            this.BtnDesactivarDep.Name = "BtnDesactivarDep";
            this.BtnDesactivarDep.Size = new System.Drawing.Size(243, 42);
            this.BtnDesactivarDep.TabIndex = 13;
            this.BtnDesactivarDep.Text = "Desactivar Departamento";
            this.BtnDesactivarDep.UseVisualStyleBackColor = true;
            this.BtnDesactivarDep.Click += new System.EventHandler(this.BtnDesactivarDep_Click);
            // 
            // BtnActivarDep
            // 
            this.BtnActivarDep.Location = new System.Drawing.Point(717, 254);
            this.BtnActivarDep.Name = "BtnActivarDep";
            this.BtnActivarDep.Size = new System.Drawing.Size(242, 42);
            this.BtnActivarDep.TabIndex = 12;
            this.BtnActivarDep.Text = "Activar Departamento";
            this.BtnActivarDep.UseVisualStyleBackColor = true;
            this.BtnActivarDep.Click += new System.EventHandler(this.BtnActivarDep_Click);
            // 
            // BtnNuevoDep
            // 
            this.BtnNuevoDep.Location = new System.Drawing.Point(863, 49);
            this.BtnNuevoDep.Name = "BtnNuevoDep";
            this.BtnNuevoDep.Size = new System.Drawing.Size(243, 42);
            this.BtnNuevoDep.TabIndex = 10;
            this.BtnNuevoDep.Text = "Nuevo Departamento";
            this.BtnNuevoDep.UseVisualStyleBackColor = true;
            this.BtnNuevoDep.Click += new System.EventHandler(this.BtnNuevoDep_Click);
            // 
            // BtnEditarDep
            // 
            this.BtnEditarDep.Location = new System.Drawing.Point(1004, 154);
            this.BtnEditarDep.Name = "BtnEditarDep";
            this.BtnEditarDep.Size = new System.Drawing.Size(243, 42);
            this.BtnEditarDep.TabIndex = 8;
            this.BtnEditarDep.Text = "Editar Departamento";
            this.BtnEditarDep.UseVisualStyleBackColor = true;
            this.BtnEditarDep.Click += new System.EventHandler(this.BtnEditarDep_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(568, 38);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(49, 26);
            this.TxtId.TabIndex = 7;
            this.TxtId.Visible = false;
            // 
            // BtnCancelarDep
            // 
            this.BtnCancelarDep.Location = new System.Drawing.Point(864, 363);
            this.BtnCancelarDep.Name = "BtnCancelarDep";
            this.BtnCancelarDep.Size = new System.Drawing.Size(242, 42);
            this.BtnCancelarDep.TabIndex = 6;
            this.BtnCancelarDep.Text = "Cancelar";
            this.BtnCancelarDep.UseVisualStyleBackColor = true;
            this.BtnCancelarDep.Click += new System.EventHandler(this.BtnCancelarDep_Click);
            // 
            // BtnGuardarDep
            // 
            this.BtnGuardarDep.Location = new System.Drawing.Point(716, 154);
            this.BtnGuardarDep.Name = "BtnGuardarDep";
            this.BtnGuardarDep.Size = new System.Drawing.Size(243, 42);
            this.BtnGuardarDep.TabIndex = 5;
            this.BtnGuardarDep.Text = "Guardar Departamento";
            this.BtnGuardarDep.UseVisualStyleBackColor = true;
            this.BtnGuardarDep.Click += new System.EventHandler(this.BtnGuardarDep_Click);
            // 
            // TxtDescripcionDep
            // 
            this.TxtDescripcionDep.Location = new System.Drawing.Point(298, 185);
            this.TxtDescripcionDep.Multiline = true;
            this.TxtDescripcionDep.Name = "TxtDescripcionDep";
            this.TxtDescripcionDep.Size = new System.Drawing.Size(319, 111);
            this.TxtDescripcionDep.TabIndex = 4;
            // 
            // TxtNombreDep
            // 
            this.TxtNombreDep.Location = new System.Drawing.Point(298, 85);
            this.TxtNombreDep.Name = "TxtNombreDep";
            this.TxtNombreDep.Size = new System.Drawing.Size(319, 26);
            this.TxtNombreDep.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "(*)Dato Obligatorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre(*)";
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(759, 615);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(68, 25);
            this.LblTotal.TabIndex = 9;
            this.LblTotal.Text = "Total:";
            // 
            // FrmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1409, 683);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmDepartamento";
            this.Text = "Ingreso De Departamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDepartamento_Load);
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
        private System.Windows.Forms.Button BtnDesactivarDep;
        private System.Windows.Forms.Button BtnActivarDep;
        private System.Windows.Forms.Button BtnNuevoDep;
        private System.Windows.Forms.Button BtnEditarDep;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnCancelarDep;
        private System.Windows.Forms.Button BtnGuardarDep;
        private System.Windows.Forms.TextBox TxtDescripcionDep;
        private System.Windows.Forms.TextBox TxtNombreDep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Label LblTotal;
    }
}