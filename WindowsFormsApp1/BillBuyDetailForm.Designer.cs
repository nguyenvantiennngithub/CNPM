
namespace WindowsFormsApp1
{
    partial class BillBuyDetailForm
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
            this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singlePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbOption = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSinglePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbMiss = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbUnit = new System.Windows.Forms.TextBox();
            this.txbNote = new System.Windows.Forms.TextBox();
            this.txbCount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.idItem,
            this.item,
            this.option,
            this.count,
            this.singlePrice,
            this.totalPrice,
            this.status,
            this.miss,
            this.unit,
            this.note});
            this.dgvMain.Location = new System.Drawing.Point(12, 232);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(776, 196);
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
            // idItem
            // 
            this.idItem.HeaderText = "Id Item";
            this.idItem.Name = "idItem";
            this.idItem.ReadOnly = true;
            this.idItem.Width = 50;
            // 
            // item
            // 
            this.item.HeaderText = "Name Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            // 
            // option
            // 
            this.option.HeaderText = "Option";
            this.option.Name = "option";
            this.option.ReadOnly = true;
            this.option.Width = 50;
            // 
            // count
            // 
            this.count.HeaderText = "Count";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 50;
            // 
            // singlePrice
            // 
            this.singlePrice.HeaderText = "Single Price";
            this.singlePrice.Name = "singlePrice";
            this.singlePrice.ReadOnly = true;
            this.singlePrice.Width = 50;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Width = 50;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // miss
            // 
            this.miss.HeaderText = "Missing Count";
            this.miss.Name = "miss";
            this.miss.ReadOnly = true;
            this.miss.Width = 50;
            // 
            // unit
            // 
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Width = 50;
            // 
            // note
            // 
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Form Edit Bill Buy Detail";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txbId
            // 
            this.txbId.Enabled = false;
            this.txbId.Location = new System.Drawing.Point(98, 74);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 20);
            this.txbId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Option: ";
            // 
            // txbOption
            // 
            this.txbOption.Enabled = false;
            this.txbOption.Location = new System.Drawing.Point(278, 100);
            this.txbOption.Name = "txbOption";
            this.txbOption.Size = new System.Drawing.Size(100, 20);
            this.txbOption.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Count: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Single Price: ";
            // 
            // txbSinglePrice
            // 
            this.txbSinglePrice.Location = new System.Drawing.Point(98, 152);
            this.txbSinglePrice.Name = "txbSinglePrice";
            this.txbSinglePrice.Size = new System.Drawing.Size(100, 20);
            this.txbSinglePrice.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Price: ";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Enabled = false;
            this.txbTotalPrice.Location = new System.Drawing.Point(98, 178);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.txbTotalPrice.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Status: ";
            // 
            // txbStatus
            // 
            this.txbStatus.Enabled = false;
            this.txbStatus.Location = new System.Drawing.Point(278, 74);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(100, 20);
            this.txbStatus.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Missing Count: ";
            // 
            // txbMiss
            // 
            this.txbMiss.Location = new System.Drawing.Point(98, 102);
            this.txbMiss.Name = "txbMiss";
            this.txbMiss.Size = new System.Drawing.Size(100, 20);
            this.txbMiss.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Unit: ";
            // 
            // txbUnit
            // 
            this.txbUnit.Enabled = false;
            this.txbUnit.Location = new System.Drawing.Point(278, 129);
            this.txbUnit.Name = "txbUnit";
            this.txbUnit.Size = new System.Drawing.Size(100, 20);
            this.txbUnit.TabIndex = 16;
            // 
            // txbNote
            // 
            this.txbNote.Location = new System.Drawing.Point(278, 155);
            this.txbNote.Name = "txbNote";
            this.txbNote.Size = new System.Drawing.Size(100, 20);
            this.txbNote.TabIndex = 18;
            // 
            // txbCount
            // 
            this.txbCount.Location = new System.Drawing.Point(98, 128);
            this.txbCount.Name = "txbCount";
            this.txbCount.Size = new System.Drawing.Size(100, 20);
            this.txbCount.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Note: ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(303, 181);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Edit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // BillBuyDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbCount);
            this.Controls.Add(this.txbNote);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbUnit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbMiss);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbTotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbSinglePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbOption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMain);
            this.Name = "BillBuyDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillBuyDetailForm";
            this.Load += new System.EventHandler(this.BillBuyDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbOption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSinglePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbMiss;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbUnit;
        private System.Windows.Forms.TextBox txbNote;
        private System.Windows.Forms.NumericUpDown txbCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn option;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn singlePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn miss;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
    }
}