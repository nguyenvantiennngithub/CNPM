
namespace WindowsFormsApp1
{
    partial class SalesReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesReportDateSet = new WindowsFormsApp1.SalesReportDateSet();
            this.BillTableAdapter = new WindowsFormsApp1.SalesReportDateSetTableAdapters.BillTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TotalPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TotalPriceTableAdapter = new WindowsFormsApp1.SalesReportDateSetTableAdapters.TotalPriceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportDateSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPriceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hóa đơn thanh toán";
            // 
            // BillBindingSource
            // 
            this.BillBindingSource.DataMember = "Bill";
            this.BillBindingSource.DataSource = this.SalesReportDateSet;
            // 
            // SalesReportDateSet
            // 
            this.SalesReportDateSet.DataSetName = "SalesReportDateSet";
            this.SalesReportDateSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BillTableAdapter
            // 
            this.BillTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ItemDataSet";
            reportDataSource1.Value = this.BillBindingSource;
            reportDataSource2.Name = "TotalPrice";
            reportDataSource2.Value = this.TotalPriceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 2;
            // 
            // TotalPriceBindingSource
            // 
            this.TotalPriceBindingSource.DataMember = "TotalPrice";
            this.TotalPriceBindingSource.DataSource = this.SalesReportDateSet;
            // 
            // TotalPriceTableAdapter
            // 
            this.TotalPriceTableAdapter.ClearBeforeFill = true;
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Name = "SalesReportForm";
            this.Text = "SalesReportForm";
            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportDateSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPriceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource BillBindingSource;
        private SalesReportDateSet SalesReportDateSet;
        private SalesReportDateSetTableAdapters.BillTableAdapter BillTableAdapter;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TotalPriceBindingSource;
        private SalesReportDateSetTableAdapters.TotalPriceTableAdapter TotalPriceTableAdapter;
    }
}