
namespace WindowsFormsApp1
{
    partial class BuyForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singlePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbOption = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbMiss = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(165, 71);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 33);
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total price";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Enabled = false;
            this.txbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.Location = new System.Drawing.Point(143, 33);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(132, 30);
            this.txbTotalPrice.TabIndex = 21;
            this.txbTotalPrice.Text = "0";
            // 
            // numCount
            // 
            this.numCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCount.Location = new System.Drawing.Point(169, 129);
            this.numCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCount.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(160, 30);
            this.numCount.TabIndex = 20;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(230, 184);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Option";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Category";
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.displayName,
            this.option,
            this.singlePrice,
            this.count,
            this.miss,
            this.totalPrice,
            this.note,
            this.category,
            this.idItem});
            this.dgvSales.Location = new System.Drawing.Point(89, 19);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.Size = new System.Drawing.Size(963, 292);
            this.dgvSales.TabIndex = 15;
            // 
            // index
            // 
            this.index.HeaderText = "Index";
            this.index.MinimumWidth = 6;
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 50;
            // 
            // displayName
            // 
            this.displayName.HeaderText = "Display Name";
            this.displayName.MinimumWidth = 6;
            this.displayName.Name = "displayName";
            this.displayName.ReadOnly = true;
            this.displayName.Width = 125;
            // 
            // option
            // 
            this.option.HeaderText = "Option";
            this.option.MinimumWidth = 6;
            this.option.Name = "option";
            this.option.ReadOnly = true;
            this.option.Width = 50;
            // 
            // singlePrice
            // 
            this.singlePrice.HeaderText = "Single Price";
            this.singlePrice.MinimumWidth = 6;
            this.singlePrice.Name = "singlePrice";
            this.singlePrice.ReadOnly = true;
            this.singlePrice.Width = 50;
            // 
            // count
            // 
            this.count.HeaderText = "Count";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 50;
            // 
            // miss
            // 
            this.miss.HeaderText = "Missing Count";
            this.miss.MinimumWidth = 6;
            this.miss.Name = "miss";
            this.miss.ReadOnly = true;
            this.miss.Width = 50;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.MinimumWidth = 6;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Width = 125;
            // 
            // note
            // 
            this.note.HeaderText = "Note";
            this.note.MinimumWidth = 6;
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.Width = 125;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 125;
            // 
            // idItem
            // 
            this.idItem.HeaderText = "Id Item";
            this.idItem.MinimumWidth = 6;
            this.idItem.Name = "idItem";
            this.idItem.ReadOnly = true;
            this.idItem.Width = 125;
            // 
            // cbOption
            // 
            this.cbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOption.FormattingEnabled = true;
            this.cbOption.Location = new System.Drawing.Point(172, 123);
            this.cbOption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbOption.Name = "cbOption";
            this.cbOption.Size = new System.Drawing.Size(160, 33);
            this.cbOption.TabIndex = 14;
            this.cbOption.SelectedValueChanged += new System.EventHandler(this.cbOption_SelectedValueChanged);
            // 
            // cbProduct
            // 
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(172, 74);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(160, 33);
            this.cbProduct.TabIndex = 13;
            this.cbProduct.SelectedValueChanged += new System.EventHandler(this.cbProduct_SelectedValueChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(172, 29);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(160, 33);
            this.cbCategory.TabIndex = 12;
            this.cbCategory.SelectedValueChanged += new System.EventHandler(this.cbCategory_SelectedValueChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Price";
            // 
            // txbPrice
            // 
            this.txbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.Location = new System.Drawing.Point(170, 35);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(160, 30);
            this.txbPrice.TabIndex = 24;
            this.txbPrice.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Note";
            // 
            // txbNote
            // 
            this.txbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNote.Location = new System.Drawing.Point(170, 80);
            this.txbNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNote.Name = "txbNote";
            this.txbNote.Size = new System.Drawing.Size(160, 30);
            this.txbNote.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 169);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Missing Count";
            // 
            // txbMiss
            // 
            this.txbMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMiss.Location = new System.Drawing.Point(172, 168);
            this.txbMiss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMiss.Name = "txbMiss";
            this.txbMiss.Size = new System.Drawing.Size(160, 30);
            this.txbMiss.TabIndex = 29;
            this.txbMiss.Text = "0";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1162, 118);
            this.label9.TabIndex = 31;
            this.label9.Text = "Sales Form";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 118);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1162, 225);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbCategory);
            this.panel3.Controls.Add(this.cbProduct);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cbOption);
            this.panel3.Controls.Add(this.txbMiss);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 225);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbTotalPrice);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnSubmit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(762, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 225);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.numCount);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txbPrice);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txbNote);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(364, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(398, 225);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 672);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1162, 17);
            this.panel6.TabIndex = 34;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvSales);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 343);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1162, 329);
            this.panel7.TabIndex = 35;
            // 
            // BuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 689);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BuyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyForm";
            this.Load += new System.EventHandler(this.BuyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.ComboBox cbOption;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbMiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn option;
        private System.Windows.Forms.DataGridViewTextBoxColumn singlePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn miss;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}