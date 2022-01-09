
namespace WindowsFormsApp1
{
    partial class BuyReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AcountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KMSDataSet = new WindowsFormsApp1.KMSDataSet();
            this.TotalPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AcountTableAdapter = new WindowsFormsApp1.KMSDataSetTableAdapters.AcountTableAdapter();
            this.TotalPriceTableAdapter = new WindowsFormsApp1.KMSDataSetTableAdapters.TotalPriceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AcountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPriceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AcountBindingSource
            // 
            this.AcountBindingSource.DataMember = "Acount";
            this.AcountBindingSource.DataSource = this.KMSDataSet;
            // 
            // KMSDataSet
            // 
            this.KMSDataSet.DataSetName = "KMSDataSet";
            this.KMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TotalPriceBindingSource
            // 
            this.TotalPriceBindingSource.DataMember = "TotalPrice";
            this.TotalPriceBindingSource.DataSource = this.KMSDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BuyReportForm";
            reportDataSource1.Value = this.AcountBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.TotalPriceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // AcountTableAdapter
            // 
            this.AcountTableAdapter.ClearBeforeFill = true;
            // 
            // TotalPriceTableAdapter
            // 
            this.TotalPriceTableAdapter.ClearBeforeFill = true;
            // 
            // BuyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BuyReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyReportForm";
            this.Load += new System.EventHandler(this.BuyReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AcountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPriceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AcountBindingSource;
        private KMSDataSet KMSDataSet;
        private KMSDataSetTableAdapters.AcountTableAdapter AcountTableAdapter;
        private System.Windows.Forms.BindingSource TotalPriceBindingSource;
        private KMSDataSetTableAdapters.TotalPriceTableAdapter TotalPriceTableAdapter;
    }
}