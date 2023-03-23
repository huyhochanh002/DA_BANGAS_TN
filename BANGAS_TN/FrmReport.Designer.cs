
namespace BANGAS_TN
{
    partial class FrmReport
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
            this.CTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DA_BANGAS_SQLDataSet = new BANGAS_TN.DA_BANGAS_SQLDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CTHDTableAdapter = new BANGAS_TN.DA_BANGAS_SQLDataSetTableAdapters.CTHDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CTHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DA_BANGAS_SQLDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CTHDBindingSource
            // 
            this.CTHDBindingSource.DataMember = "CTHD";
            this.CTHDBindingSource.DataSource = this.DA_BANGAS_SQLDataSet;
            // 
            // DA_BANGAS_SQLDataSet
            // 
            this.DA_BANGAS_SQLDataSet.DataSetName = "DA_BANGAS_SQLDataSet";
            this.DA_BANGAS_SQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CTHD";
            reportDataSource1.Value = this.CTHDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BANGAS_TN.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // CTHDTableAdapter
            // 
            this.CTHDTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CTHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DA_BANGAS_SQLDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource CTHDBindingSource;
        private DA_BANGAS_SQLDataSet DA_BANGAS_SQLDataSet;
        private DA_BANGAS_SQLDataSetTableAdapters.CTHDTableAdapter CTHDTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}