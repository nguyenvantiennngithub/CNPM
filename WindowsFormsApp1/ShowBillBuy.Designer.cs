
namespace WindowsFormsApp1
{
    partial class ShowBillBuy
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showReport = new System.Windows.Forms.DataGridViewButtonColumn();
            this.showDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.id,
            this.totalBill,
            this.status,
            this.creator,
            this.createdAt,
            this.showReport,
            this.showDetail});
            this.dgvMain.Location = new System.Drawing.Point(91, 79);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(694, 459);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // index
            // 
            this.index.HeaderText = "Index";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 50;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // totalBill
            // 
            this.totalBill.HeaderText = "Total Bill";
            this.totalBill.Name = "totalBill";
            this.totalBill.ReadOnly = true;
            this.totalBill.Width = 50;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // creator
            // 
            this.creator.HeaderText = "Creator";
            this.creator.Name = "creator";
            this.creator.ReadOnly = true;
            // 
            // createdAt
            // 
            this.createdAt.HeaderText = "Created At";
            this.createdAt.Name = "createdAt";
            this.createdAt.ReadOnly = true;
            // 
            // showReport
            // 
            this.showReport.HeaderText = "Show Report";
            this.showReport.Name = "showReport";
            this.showReport.ReadOnly = true;
            this.showReport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.showReport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.showReport.Text = "Show Report";
            this.showReport.UseColumnTextForButtonValue = true;
            // 
            // showDetail
            // 
            this.showDetail.HeaderText = "Show Detail";
            this.showDetail.Name = "showDetail";
            this.showDetail.ReadOnly = true;
            this.showDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.showDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.showDetail.Text = "Show Detail";
            this.showDetail.UseColumnTextForButtonValue = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(363, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 25);
            this.label11.TabIndex = 39;
            this.label11.Text = "Show Bill  Buy Form";
            // 
            // ShowBillBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 594);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowBillBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowBillBuy";
            this.Load += new System.EventHandler(this.ShowBillBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
        private System.Windows.Forms.DataGridViewButtonColumn showReport;
        private System.Windows.Forms.DataGridViewButtonColumn showDetail;
        private System.Windows.Forms.Label label11;
    }
}