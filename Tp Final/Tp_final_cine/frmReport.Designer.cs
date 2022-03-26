namespace Tp_final_cine
{
    partial class frmReport
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
            this.actoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Tp_final_cine.DataSet1();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtReportNom = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.actoresTableAdapter = new Tp_final_cine.DataSet1TableAdapters.actoresTableAdapter();
            this.txtReportApe = new System.Windows.Forms.TextBox();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.actoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // actoresBindingSource
            // 
            this.actoresBindingSource.DataMember = "actores";
            this.actoresBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(352, 395);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 1;
            this.btnReporte.Text = "Buscar";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtReportNom
            // 
            this.txtReportNom.Location = new System.Drawing.Point(219, 371);
            this.txtReportNom.Name = "txtReportNom";
            this.txtReportNom.Size = new System.Drawing.Size(100, 20);
            this.txtReportNom.TabIndex = 2;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.actoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Tp_final_cine.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 32);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(581, 331);
            this.reportViewer1.TabIndex = 3;
            // 
            // actoresTableAdapter
            // 
            this.actoresTableAdapter.ClearBeforeFill = true;
            // 
            // txtReportApe
            // 
            this.txtReportApe.Location = new System.Drawing.Point(219, 397);
            this.txtReportApe.Name = "txtReportApe";
            this.txtReportApe.Size = new System.Drawing.Size(100, 20);
            this.txtReportApe.TabIndex = 4;
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(169, 374);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(44, 13);
            this.lblnom.TabIndex = 5;
            this.lblnom.Text = "Nombre";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(169, 400);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(44, 13);
            this.lblApe.TabIndex = 6;
            this.lblApe.Text = "Apellido";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(183, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 13);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Ingrese Los datos del actor que desea buscar";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 428);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.txtReportApe);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txtReportNom);
            this.Controls.Add(this.btnReporte);
            this.Name = "frmReport";
            this.Text = "Busqueda Actores";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtReportNom;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource actoresBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.actoresTableAdapter actoresTableAdapter;
        private System.Windows.Forms.TextBox txtReportApe;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblTitulo;
    }
}