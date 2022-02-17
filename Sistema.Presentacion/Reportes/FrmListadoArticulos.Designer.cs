
namespace Sistema.Presentacion.Reportes
{
    partial class FrmListadoArticulos
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
            this.ArticuloBuscarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArticuloBuscarTableAdapter = new Sistema.Presentacion.Reportes.DsPrincipalTableAdapters.ArticuloBuscarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBuscarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsListadoArticulo";
            reportDataSource1.Value = this.ArticuloBuscarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.Reportes.FichaListadoArticulos.rdlc";
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
            // ArticuloBuscarBindingSource
            // 
            this.ArticuloBuscarBindingSource.DataMember = "ArticuloBuscar";
            this.ArticuloBuscarBindingSource.DataSource = this.DsPrincipal;
            // 
            // ArticuloBuscarTableAdapter
            // 
            this.ArticuloBuscarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmListadoArticulos";
            this.Text = "Listado Articulos";
            this.Load += new System.EventHandler(this.FrmListadoArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBuscarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ArticuloBuscarBindingSource;
        private DsPrincipal DsPrincipal;
        private DsPrincipalTableAdapters.ArticuloBuscarTableAdapter ArticuloBuscarTableAdapter;
    }
}