
namespace Sistema.Presentacion.Reportes
{
    partial class FrmListadoDevolucion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsPrincipal = new Sistema.Presentacion.Reportes.DsPrincipal();
            this.DevolucionArticuloBuscarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DevolucionArticuloBuscarTableAdapter = new Sistema.Presentacion.Reportes.DsPrincipalTableAdapters.DevolucionArticuloBuscarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevolucionArticuloBuscarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsDevolucionArticulo";
            reportDataSource1.Value = this.DevolucionArticuloBuscarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.Reportes.FichaListadoDevolucion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsPrincipal
            // 
            this.DsPrincipal.DataSetName = "DsPrincipal";
            this.DsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DevolucionArticuloBuscarBindingSource
            // 
            this.DevolucionArticuloBuscarBindingSource.DataMember = "DevolucionArticuloBuscar";
            this.DevolucionArticuloBuscarBindingSource.DataSource = this.DsPrincipal;
            // 
            // DevolucionArticuloBuscarTableAdapter
            // 
            this.DevolucionArticuloBuscarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListadoDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmListadoDevolucion";
            this.Text = "Listado Devolucion";
            this.Load += new System.EventHandler(this.FrmListadoDevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevolucionArticuloBuscarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DevolucionArticuloBuscarBindingSource;
        private DsPrincipal DsPrincipal;
        private DsPrincipalTableAdapters.DevolucionArticuloBuscarTableAdapter DevolucionArticuloBuscarTableAdapter;
    }
}