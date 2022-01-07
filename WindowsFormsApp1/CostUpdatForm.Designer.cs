
namespace WindowsFormsApp1
{
    partial class CostUpdatForm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMonth = new System.Windows.Forms.TextBox();
            this.txbYear = new System.Windows.Forms.TextBox();
            this.txbElectricFee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbWaterFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPremiseFee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbBankInterest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbBankInterestChange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPremiseFeechange = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbWaterFeeChange = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbElectricFeeChange = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbTitle);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1423, 168);
            this.panelControl1.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(2, 2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1419, 164);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "label1";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.btnSelect);
            this.panelControl2.Controls.Add(this.pictureEdit1);
            this.panelControl2.Controls.Add(this.txbBankInterestChange);
            this.panelControl2.Controls.Add(this.label7);
            this.panelControl2.Controls.Add(this.txbPremiseFeechange);
            this.panelControl2.Controls.Add(this.label8);
            this.panelControl2.Controls.Add(this.txbWaterFeeChange);
            this.panelControl2.Controls.Add(this.label9);
            this.panelControl2.Controls.Add(this.txbElectricFeeChange);
            this.panelControl2.Controls.Add(this.label10);
            this.panelControl2.Controls.Add(this.txbBankInterest);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.txbPremiseFee);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.txbWaterFee);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.txbElectricFee);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.txbYear);
            this.panelControl2.Controls.Add(this.txbMonth);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 168);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1423, 893);
            this.panelControl2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm";
            // 
            // txbMonth
            // 
            this.txbMonth.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMonth.Location = new System.Drawing.Point(313, 79);
            this.txbMonth.Name = "txbMonth";
            this.txbMonth.Size = new System.Drawing.Size(162, 32);
            this.txbMonth.TabIndex = 2;
            this.txbMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbMonth.TextChanged += new System.EventHandler(this.txbMonth_TextChanged_1);
            // 
            // txbYear
            // 
            this.txbYear.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbYear.Location = new System.Drawing.Point(749, 82);
            this.txbYear.Name = "txbYear";
            this.txbYear.Size = new System.Drawing.Size(162, 32);
            this.txbYear.TabIndex = 3;
            this.txbYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbYear.TextChanged += new System.EventHandler(this.txbYear_TextChanged);
            // 
            // txbElectricFee
            // 
            this.txbElectricFee.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbElectricFee.Location = new System.Drawing.Point(439, 320);
            this.txbElectricFee.Name = "txbElectricFee";
            this.txbElectricFee.ReadOnly = true;
            this.txbElectricFee.Size = new System.Drawing.Size(162, 32);
            this.txbElectricFee.TabIndex = 5;
            this.txbElectricFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phí điện";
            // 
            // txbWaterFee
            // 
            this.txbWaterFee.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbWaterFee.Location = new System.Drawing.Point(439, 398);
            this.txbWaterFee.Name = "txbWaterFee";
            this.txbWaterFee.ReadOnly = true;
            this.txbWaterFee.Size = new System.Drawing.Size(162, 32);
            this.txbWaterFee.TabIndex = 7;
            this.txbWaterFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phí nước";
            // 
            // txbPremiseFee
            // 
            this.txbPremiseFee.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPremiseFee.Location = new System.Drawing.Point(439, 482);
            this.txbPremiseFee.Name = "txbPremiseFee";
            this.txbPremiseFee.ReadOnly = true;
            this.txbPremiseFee.Size = new System.Drawing.Size(162, 32);
            this.txbPremiseFee.TabIndex = 9;
            this.txbPremiseFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(206, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phí mặt bằng";
            // 
            // txbBankInterest
            // 
            this.txbBankInterest.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBankInterest.Location = new System.Drawing.Point(439, 562);
            this.txbBankInterest.Name = "txbBankInterest";
            this.txbBankInterest.ReadOnly = true;
            this.txbBankInterest.Size = new System.Drawing.Size(162, 32);
            this.txbBankInterest.TabIndex = 11;
            this.txbBankInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tỉ lệ tăng trưởng";
            // 
            // txbBankInterestChange
            // 
            this.txbBankInterestChange.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBankInterestChange.Location = new System.Drawing.Point(1065, 562);
            this.txbBankInterestChange.Name = "txbBankInterestChange";
            this.txbBankInterestChange.Size = new System.Drawing.Size(162, 32);
            this.txbBankInterestChange.TabIndex = 19;
            this.txbBankInterestChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbBankInterestChange.TextChanged += new System.EventHandler(this.txbBankInterestChange_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(836, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tỉ lệ tăng trưởng";
            // 
            // txbPremiseFeechange
            // 
            this.txbPremiseFeechange.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPremiseFeechange.Location = new System.Drawing.Point(1065, 482);
            this.txbPremiseFeechange.Name = "txbPremiseFeechange";
            this.txbPremiseFeechange.Size = new System.Drawing.Size(162, 32);
            this.txbPremiseFeechange.TabIndex = 17;
            this.txbPremiseFeechange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPremiseFeechange.TextChanged += new System.EventHandler(this.txbPremiseFeechange_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(836, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Phí mặt bằng";
            // 
            // txbWaterFeeChange
            // 
            this.txbWaterFeeChange.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbWaterFeeChange.Location = new System.Drawing.Point(1065, 398);
            this.txbWaterFeeChange.Name = "txbWaterFeeChange";
            this.txbWaterFeeChange.Size = new System.Drawing.Size(162, 32);
            this.txbWaterFeeChange.TabIndex = 15;
            this.txbWaterFeeChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbWaterFeeChange.TextChanged += new System.EventHandler(this.txbWaterFeeChange_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(836, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "Phí nước";
            // 
            // txbElectricFeeChange
            // 
            this.txbElectricFeeChange.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbElectricFeeChange.Location = new System.Drawing.Point(1065, 320);
            this.txbElectricFeeChange.Name = "txbElectricFeeChange";
            this.txbElectricFeeChange.Size = new System.Drawing.Size(162, 32);
            this.txbElectricFeeChange.TabIndex = 13;
            this.txbElectricFeeChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbElectricFeeChange.TextChanged += new System.EventHandler(this.txbElectricFeeChange_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(836, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 32);
            this.label10.TabIndex = 12;
            this.label10.Text = "Phí điện";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(662, 398);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 20;
            // 
            // btnSelect
            // 
            this.btnSelect.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Appearance.Options.UseFont = true;
            this.btnSelect.Location = new System.Drawing.Point(1065, 75);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(124, 49);
            this.btnSelect.TabIndex = 21;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(1123, 677);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 59);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CostUpdatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 1061);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "CostUpdatForm";
            this.Text = "CostUpdatForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lbTitle;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.TextBox txbBankInterestChange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbPremiseFeechange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbWaterFeeChange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbElectricFeeChange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbBankInterest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbPremiseFee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbWaterFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbElectricFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbYear;
        private System.Windows.Forms.TextBox txbMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}