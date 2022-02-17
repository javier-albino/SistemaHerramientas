
namespace Sistema.Presentacion
{
    partial class FrmUsuario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtClaveUsu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEmailUsu = new System.Windows.Forms.TextBox();
            this.TxtApellidoUsu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CboRolUsu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTelefonoUsu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRutUsu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDesactivarUsu = new System.Windows.Forms.Button();
            this.BtnActivarUsu = new System.Windows.Forms.Button();
            this.BtnNuevoUsu = new System.Windows.Forms.Button();
            this.BtnEditarUsu = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnCancelarUsu = new System.Windows.Forms.Button();
            this.BtnGuardarUsu = new System.Windows.Forms.Button();
            this.TxtNombreUsu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Location = new System.Drawing.Point(12, 61);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1537, 681);
            this.TabGeneral.TabIndex = 9;
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
            this.tabPage1.Size = new System.Drawing.Size(1529, 648);
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
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.TxtApellidoUsu);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.CboRolUsu);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.TxtTelefonoUsu);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TxtRutUsu);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.BtnDesactivarUsu);
            this.tabPage2.Controls.Add(this.BtnActivarUsu);
            this.tabPage2.Controls.Add(this.BtnNuevoUsu);
            this.tabPage2.Controls.Add(this.BtnEditarUsu);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.BtnCancelarUsu);
            this.tabPage2.Controls.Add(this.BtnGuardarUsu);
            this.tabPage2.Controls.Add(this.TxtNombreUsu);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1529, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtClaveUsu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtEmailUsu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(820, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 201);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acceso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Clave(*)";
            // 
            // TxtClaveUsu
            // 
            this.TxtClaveUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClaveUsu.Location = new System.Drawing.Point(163, 138);
            this.TxtClaveUsu.Name = "TxtClaveUsu";
            this.TxtClaveUsu.Size = new System.Drawing.Size(330, 30);
            this.TxtClaveUsu.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email(*)";
            // 
            // TxtEmailUsu
            // 
            this.TxtEmailUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailUsu.Location = new System.Drawing.Point(163, 48);
            this.TxtEmailUsu.Name = "TxtEmailUsu";
            this.TxtEmailUsu.Size = new System.Drawing.Size(330, 30);
            this.TxtEmailUsu.TabIndex = 19;
            // 
            // TxtApellidoUsu
            // 
            this.TxtApellidoUsu.Location = new System.Drawing.Point(316, 258);
            this.TxtApellidoUsu.Name = "TxtApellidoUsu";
            this.TxtApellidoUsu.Size = new System.Drawing.Size(319, 26);
            this.TxtApellidoUsu.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Apellidos(*)";
            // 
            // CboRolUsu
            // 
            this.CboRolUsu.FormattingEnabled = true;
            this.CboRolUsu.Location = new System.Drawing.Point(320, 441);
            this.CboRolUsu.Name = "CboRolUsu";
            this.CboRolUsu.Size = new System.Drawing.Size(319, 28);
            this.CboRolUsu.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Rol(*)";
            // 
            // TxtTelefonoUsu
            // 
            this.TxtTelefonoUsu.Location = new System.Drawing.Point(320, 346);
            this.TxtTelefonoUsu.Name = "TxtTelefonoUsu";
            this.TxtTelefonoUsu.Size = new System.Drawing.Size(319, 26);
            this.TxtTelefonoUsu.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefono(*)";
            // 
            // TxtRutUsu
            // 
            this.TxtRutUsu.Location = new System.Drawing.Point(316, 84);
            this.TxtRutUsu.Name = "TxtRutUsu";
            this.TxtRutUsu.Size = new System.Drawing.Size(319, 26);
            this.TxtRutUsu.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rut(*)";
            // 
            // BtnDesactivarUsu
            // 
            this.BtnDesactivarUsu.Location = new System.Drawing.Point(1122, 445);
            this.BtnDesactivarUsu.Name = "BtnDesactivarUsu";
            this.BtnDesactivarUsu.Size = new System.Drawing.Size(243, 42);
            this.BtnDesactivarUsu.TabIndex = 13;
            this.BtnDesactivarUsu.Text = "Desactivar Usuario";
            this.BtnDesactivarUsu.UseVisualStyleBackColor = true;
            this.BtnDesactivarUsu.Click += new System.EventHandler(this.BtnDesactivarUsu_Click);
            // 
            // BtnActivarUsu
            // 
            this.BtnActivarUsu.Location = new System.Drawing.Point(845, 445);
            this.BtnActivarUsu.Name = "BtnActivarUsu";
            this.BtnActivarUsu.Size = new System.Drawing.Size(242, 42);
            this.BtnActivarUsu.TabIndex = 12;
            this.BtnActivarUsu.Text = "Activar Usuario";
            this.BtnActivarUsu.UseVisualStyleBackColor = true;
            this.BtnActivarUsu.Click += new System.EventHandler(this.BtnActivarUsu_Click);
            // 
            // BtnNuevoUsu
            // 
            this.BtnNuevoUsu.Location = new System.Drawing.Point(982, 240);
            this.BtnNuevoUsu.Name = "BtnNuevoUsu";
            this.BtnNuevoUsu.Size = new System.Drawing.Size(243, 42);
            this.BtnNuevoUsu.TabIndex = 10;
            this.BtnNuevoUsu.Text = "Nuevo Usuario";
            this.BtnNuevoUsu.UseVisualStyleBackColor = true;
            this.BtnNuevoUsu.Click += new System.EventHandler(this.BtnNuevoUsu_Click);
            // 
            // BtnEditarUsu
            // 
            this.BtnEditarUsu.Location = new System.Drawing.Point(1123, 345);
            this.BtnEditarUsu.Name = "BtnEditarUsu";
            this.BtnEditarUsu.Size = new System.Drawing.Size(243, 42);
            this.BtnEditarUsu.TabIndex = 8;
            this.BtnEditarUsu.Text = "Editar Usuario";
            this.BtnEditarUsu.UseVisualStyleBackColor = true;
            this.BtnEditarUsu.Click += new System.EventHandler(this.BtnEditarUsu_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(1373, 262);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(49, 26);
            this.TxtId.TabIndex = 7;
            this.TxtId.Visible = false;
            // 
            // BtnCancelarUsu
            // 
            this.BtnCancelarUsu.Location = new System.Drawing.Point(983, 559);
            this.BtnCancelarUsu.Name = "BtnCancelarUsu";
            this.BtnCancelarUsu.Size = new System.Drawing.Size(242, 42);
            this.BtnCancelarUsu.TabIndex = 6;
            this.BtnCancelarUsu.Text = "Cancelar";
            this.BtnCancelarUsu.UseVisualStyleBackColor = true;
            this.BtnCancelarUsu.Click += new System.EventHandler(this.BtnCancelarUsu_Click);
            // 
            // BtnGuardarUsu
            // 
            this.BtnGuardarUsu.Location = new System.Drawing.Point(845, 345);
            this.BtnGuardarUsu.Name = "BtnGuardarUsu";
            this.BtnGuardarUsu.Size = new System.Drawing.Size(243, 42);
            this.BtnGuardarUsu.TabIndex = 5;
            this.BtnGuardarUsu.Text = "Guardar Usuario";
            this.BtnGuardarUsu.UseVisualStyleBackColor = true;
            this.BtnGuardarUsu.Click += new System.EventHandler(this.BtnGuardarUsu_Click);
            // 
            // TxtNombreUsu
            // 
            this.TxtNombreUsu.Location = new System.Drawing.Point(316, 173);
            this.TxtNombreUsu.Name = "TxtNombreUsu";
            this.TxtNombreUsu.Size = new System.Drawing.Size(319, 26);
            this.TxtNombreUsu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "(*)Dato Obligatorio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres(*)";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(831, 23);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(68, 25);
            this.LblTotal.TabIndex = 10;
            this.LblTotal.Text = "Total:";
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1652, 804);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmUsuario";
            this.Text = "Ingreso De Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtClaveUsu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEmailUsu;
        private System.Windows.Forms.TextBox TxtApellidoUsu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboRolUsu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTelefonoUsu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRutUsu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDesactivarUsu;
        private System.Windows.Forms.Button BtnActivarUsu;
        private System.Windows.Forms.Button BtnNuevoUsu;
        private System.Windows.Forms.Button BtnEditarUsu;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnCancelarUsu;
        private System.Windows.Forms.Button BtnGuardarUsu;
        private System.Windows.Forms.TextBox TxtNombreUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
    }
}