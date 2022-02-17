
namespace Sistema.Presentacion
{
    partial class FrmPuesto
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
            this.BtnDesactivarPue = new System.Windows.Forms.Button();
            this.BtnActivarPue = new System.Windows.Forms.Button();
            this.BtnNuevoPue = new System.Windows.Forms.Button();
            this.BtnEditarPue = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnCancelarPue = new System.Windows.Forms.Button();
            this.BtnGuardarPue = new System.Windows.Forms.Button();
            this.TxtDescripcionPue = new System.Windows.Forms.TextBox();
            this.TxtNombrePue = new System.Windows.Forms.TextBox();
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
            this.TabGeneral.Location = new System.Drawing.Point(12, 46);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1364, 523);
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
            this.tabPage1.Size = new System.Drawing.Size(1356, 490);
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
            this.tabPage2.Controls.Add(this.BtnDesactivarPue);
            this.tabPage2.Controls.Add(this.BtnActivarPue);
            this.tabPage2.Controls.Add(this.BtnNuevoPue);
            this.tabPage2.Controls.Add(this.BtnEditarPue);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.BtnCancelarPue);
            this.tabPage2.Controls.Add(this.BtnGuardarPue);
            this.tabPage2.Controls.Add(this.TxtDescripcionPue);
            this.tabPage2.Controls.Add(this.TxtNombrePue);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1356, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenedor";
            // 
            // BtnDesactivarPue
            // 
            this.BtnDesactivarPue.Location = new System.Drawing.Point(1014, 254);
            this.BtnDesactivarPue.Name = "BtnDesactivarPue";
            this.BtnDesactivarPue.Size = new System.Drawing.Size(243, 42);
            this.BtnDesactivarPue.TabIndex = 13;
            this.BtnDesactivarPue.Text = "Desactivar Puesto";
            this.BtnDesactivarPue.UseVisualStyleBackColor = true;
            this.BtnDesactivarPue.Click += new System.EventHandler(this.BtnDesactivarPue_Click);
            // 
            // BtnActivarPue
            // 
            this.BtnActivarPue.Location = new System.Drawing.Point(717, 254);
            this.BtnActivarPue.Name = "BtnActivarPue";
            this.BtnActivarPue.Size = new System.Drawing.Size(242, 42);
            this.BtnActivarPue.TabIndex = 12;
            this.BtnActivarPue.Text = "Activar Puesto";
            this.BtnActivarPue.UseVisualStyleBackColor = true;
            this.BtnActivarPue.Click += new System.EventHandler(this.BtnActivarPue_Click);
            // 
            // BtnNuevoPue
            // 
            this.BtnNuevoPue.Location = new System.Drawing.Point(863, 49);
            this.BtnNuevoPue.Name = "BtnNuevoPue";
            this.BtnNuevoPue.Size = new System.Drawing.Size(243, 42);
            this.BtnNuevoPue.TabIndex = 10;
            this.BtnNuevoPue.Text = "Nuevo Puesto";
            this.BtnNuevoPue.UseVisualStyleBackColor = true;
            this.BtnNuevoPue.Click += new System.EventHandler(this.BtnNuevoPue_Click);
            // 
            // BtnEditarPue
            // 
            this.BtnEditarPue.Location = new System.Drawing.Point(1014, 154);
            this.BtnEditarPue.Name = "BtnEditarPue";
            this.BtnEditarPue.Size = new System.Drawing.Size(243, 42);
            this.BtnEditarPue.TabIndex = 8;
            this.BtnEditarPue.Text = "Editar Puesto";
            this.BtnEditarPue.UseVisualStyleBackColor = true;
            this.BtnEditarPue.Click += new System.EventHandler(this.BtnEditarPue_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(568, 38);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(49, 26);
            this.TxtId.TabIndex = 7;
            this.TxtId.Visible = false;
            // 
            // BtnCancelarPue
            // 
            this.BtnCancelarPue.Location = new System.Drawing.Point(864, 359);
            this.BtnCancelarPue.Name = "BtnCancelarPue";
            this.BtnCancelarPue.Size = new System.Drawing.Size(242, 42);
            this.BtnCancelarPue.TabIndex = 6;
            this.BtnCancelarPue.Text = "Cancelar";
            this.BtnCancelarPue.UseVisualStyleBackColor = true;
            this.BtnCancelarPue.Click += new System.EventHandler(this.BtnCancelarPue_Click);
            // 
            // BtnGuardarPue
            // 
            this.BtnGuardarPue.Location = new System.Drawing.Point(717, 154);
            this.BtnGuardarPue.Name = "BtnGuardarPue";
            this.BtnGuardarPue.Size = new System.Drawing.Size(243, 42);
            this.BtnGuardarPue.TabIndex = 5;
            this.BtnGuardarPue.Text = "Guardar Puesto";
            this.BtnGuardarPue.UseVisualStyleBackColor = true;
            this.BtnGuardarPue.Click += new System.EventHandler(this.BtnGuardarPue_Click);
            // 
            // TxtDescripcionPue
            // 
            this.TxtDescripcionPue.Location = new System.Drawing.Point(298, 185);
            this.TxtDescripcionPue.Multiline = true;
            this.TxtDescripcionPue.Name = "TxtDescripcionPue";
            this.TxtDescripcionPue.Size = new System.Drawing.Size(319, 111);
            this.TxtDescripcionPue.TabIndex = 4;
            // 
            // TxtNombrePue
            // 
            this.TxtNombrePue.Location = new System.Drawing.Point(298, 85);
            this.TxtNombrePue.Name = "TxtNombrePue";
            this.TxtNombrePue.Size = new System.Drawing.Size(319, 26);
            this.TxtNombrePue.TabIndex = 3;
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
            this.LblTotal.Location = new System.Drawing.Point(728, 584);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(68, 25);
            this.LblTotal.TabIndex = 15;
            this.LblTotal.Text = "Total:";
            // 
            // FrmPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1409, 630);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmPuesto";
            this.Text = "Ingreso De Puesto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPuesto_Load);
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
        private System.Windows.Forms.Button BtnDesactivarPue;
        private System.Windows.Forms.Button BtnActivarPue;
        private System.Windows.Forms.Button BtnNuevoPue;
        private System.Windows.Forms.Button BtnEditarPue;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnCancelarPue;
        private System.Windows.Forms.Button BtnGuardarPue;
        private System.Windows.Forms.TextBox TxtDescripcionPue;
        private System.Windows.Forms.TextBox TxtNombrePue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Label LblTotal;
    }
}