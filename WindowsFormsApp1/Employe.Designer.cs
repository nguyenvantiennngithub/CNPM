
namespace WindowsFormsApp1
{
    partial class Employe
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbHoVaTen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.billTableAdapter1 = new WindowsFormsApp1.SalesReportDateSetTableAdapters.BillTableAdapter();
            this.txtICN = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShowDeleted = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSOSalary = new System.Windows.Forms.Button();
            this.btnSOStatus = new System.Windows.Forms.Button();
            this.btnSOID = new System.Windows.Forms.Button();
            this.btnSOPosition = new System.Windows.Forms.Button();
            this.btnSOICN = new System.Windows.Forms.Button();
            this.btnSOBirthday = new System.Windows.Forms.Button();
            this.btnSOName = new System.Windows.Forms.Button();
            this.dtpSBirthday = new System.Windows.Forms.DateTimePicker();
            this.cbSStatus = new System.Windows.Forms.ComboBox();
            this.cbSPositon = new System.Windows.Forms.ComboBox();
            this.txtSSalary = new System.Windows.Forms.TextBox();
            this.txtSICN = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHide = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.txtShowDeleted.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(23, 287);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1178, 432);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 56);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDay.Location = new System.Drawing.Point(310, 61);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(112, 22);
            this.dtpBirthDay.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(310, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 22);
            this.txtName.TabIndex = 3;
            // 
            // lbHoVaTen
            // 
            this.lbHoVaTen.AutoSize = true;
            this.lbHoVaTen.Location = new System.Drawing.Point(251, 25);
            this.lbHoVaTen.Name = "lbHoVaTen";
            this.lbHoVaTen.Size = new System.Drawing.Size(45, 17);
            this.lbHoVaTen.TabIndex = 4;
            this.lbHoVaTen.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Birthday";
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản lý",
            "Trưởng phòng"});
            this.cbPosition.Location = new System.Drawing.Point(310, 137);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(153, 24);
            this.cbPosition.TabIndex = 5;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Position";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(23, 84);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 56);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(23, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 56);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Identity card number";
            // 
            // billTableAdapter1
            // 
            this.billTableAdapter1.ClearBeforeFill = true;
            // 
            // txtICN
            // 
            this.txtICN.Location = new System.Drawing.Point(310, 99);
            this.txtICN.Name = "txtICN";
            this.txtICN.Size = new System.Drawing.Size(170, 22);
            this.txtICN.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(310, 171);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(38, 22);
            this.txtID.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID";
            // 
            // txtShowDeleted
            // 
            this.txtShowDeleted.Controls.Add(this.txtSID);
            this.txtShowDeleted.Controls.Add(this.label12);
            this.txtShowDeleted.Controls.Add(this.label11);
            this.txtShowDeleted.Controls.Add(this.label10);
            this.txtShowDeleted.Controls.Add(this.label9);
            this.txtShowDeleted.Controls.Add(this.label8);
            this.txtShowDeleted.Controls.Add(this.label7);
            this.txtShowDeleted.Controls.Add(this.label6);
            this.txtShowDeleted.Controls.Add(this.btnSOSalary);
            this.txtShowDeleted.Controls.Add(this.btnSOStatus);
            this.txtShowDeleted.Controls.Add(this.btnSOID);
            this.txtShowDeleted.Controls.Add(this.btnSOPosition);
            this.txtShowDeleted.Controls.Add(this.btnSOICN);
            this.txtShowDeleted.Controls.Add(this.btnSOBirthday);
            this.txtShowDeleted.Controls.Add(this.btnSOName);
            this.txtShowDeleted.Controls.Add(this.dtpSBirthday);
            this.txtShowDeleted.Controls.Add(this.cbSStatus);
            this.txtShowDeleted.Controls.Add(this.cbSPositon);
            this.txtShowDeleted.Controls.Add(this.txtSSalary);
            this.txtShowDeleted.Controls.Add(this.txtSICN);
            this.txtShowDeleted.Controls.Add(this.txtSName);
            this.txtShowDeleted.Location = new System.Drawing.Point(661, 5);
            this.txtShowDeleted.Name = "txtShowDeleted";
            this.txtShowDeleted.Size = new System.Drawing.Size(540, 276);
            this.txtShowDeleted.TabIndex = 14;
            this.txtShowDeleted.TabStop = false;
            this.txtShowDeleted.Text = "Search";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Salary";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Identity card number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Birthday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Name";
            // 
            // btnSOSalary
            // 
            this.btnSOSalary.Location = new System.Drawing.Point(329, 230);
            this.btnSOSalary.Name = "btnSOSalary";
            this.btnSOSalary.Size = new System.Drawing.Size(92, 24);
            this.btnSOSalary.TabIndex = 29;
            this.btnSOSalary.Text = "Search ";
            this.btnSOSalary.UseVisualStyleBackColor = true;
            this.btnSOSalary.Click += new System.EventHandler(this.btnSOSalary_Click);
            // 
            // btnSOStatus
            // 
            this.btnSOStatus.Location = new System.Drawing.Point(345, 194);
            this.btnSOStatus.Name = "btnSOStatus";
            this.btnSOStatus.Size = new System.Drawing.Size(92, 24);
            this.btnSOStatus.TabIndex = 28;
            this.btnSOStatus.Text = "Search";
            this.btnSOStatus.UseVisualStyleBackColor = true;
            this.btnSOStatus.Click += new System.EventHandler(this.btnSOStatus_Click);
            // 
            // btnSOID
            // 
            this.btnSOID.Location = new System.Drawing.Point(230, 162);
            this.btnSOID.Name = "btnSOID";
            this.btnSOID.Size = new System.Drawing.Size(92, 24);
            this.btnSOID.TabIndex = 27;
            this.btnSOID.Text = "Search";
            this.btnSOID.UseVisualStyleBackColor = true;
            this.btnSOID.Click += new System.EventHandler(this.btnSOID_Click);
            // 
            // btnSOPosition
            // 
            this.btnSOPosition.Location = new System.Drawing.Point(345, 129);
            this.btnSOPosition.Name = "btnSOPosition";
            this.btnSOPosition.Size = new System.Drawing.Size(92, 24);
            this.btnSOPosition.TabIndex = 26;
            this.btnSOPosition.Text = "Search";
            this.btnSOPosition.UseVisualStyleBackColor = true;
            this.btnSOPosition.Click += new System.EventHandler(this.btnSOPosition_Click);
            // 
            // btnSOICN
            // 
            this.btnSOICN.Location = new System.Drawing.Point(362, 90);
            this.btnSOICN.Name = "btnSOICN";
            this.btnSOICN.Size = new System.Drawing.Size(92, 24);
            this.btnSOICN.TabIndex = 25;
            this.btnSOICN.Text = "Search";
            this.btnSOICN.UseVisualStyleBackColor = true;
            this.btnSOICN.Click += new System.EventHandler(this.btnSOICN_Click);
            // 
            // btnSOBirthday
            // 
            this.btnSOBirthday.Location = new System.Drawing.Point(304, 52);
            this.btnSOBirthday.Name = "btnSOBirthday";
            this.btnSOBirthday.Size = new System.Drawing.Size(92, 24);
            this.btnSOBirthday.TabIndex = 24;
            this.btnSOBirthday.Text = "Search";
            this.btnSOBirthday.UseVisualStyleBackColor = true;
            this.btnSOBirthday.Click += new System.EventHandler(this.btnSOBirthday_Click);
            // 
            // btnSOName
            // 
            this.btnSOName.Location = new System.Drawing.Point(422, 11);
            this.btnSOName.Name = "btnSOName";
            this.btnSOName.Size = new System.Drawing.Size(92, 24);
            this.btnSOName.TabIndex = 19;
            this.btnSOName.Text = "Search ";
            this.btnSOName.UseVisualStyleBackColor = true;
            this.btnSOName.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtpSBirthday
            // 
            this.dtpSBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSBirthday.Location = new System.Drawing.Point(186, 54);
            this.dtpSBirthday.Name = "dtpSBirthday";
            this.dtpSBirthday.Size = new System.Drawing.Size(112, 22);
            this.dtpSBirthday.TabIndex = 10;
            // 
            // cbSStatus
            // 
            this.cbSStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSStatus.FormattingEnabled = true;
            this.cbSStatus.Items.AddRange(new object[] {
            "Hoạt động",
            "Không hoạt động"});
            this.cbSStatus.Location = new System.Drawing.Point(186, 195);
            this.cbSStatus.Name = "cbSStatus";
            this.cbSStatus.Size = new System.Drawing.Size(153, 24);
            this.cbSStatus.TabIndex = 9;
            // 
            // cbSPositon
            // 
            this.cbSPositon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSPositon.FormattingEnabled = true;
            this.cbSPositon.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản lý",
            "Trưởng phòng"});
            this.cbSPositon.Location = new System.Drawing.Point(186, 130);
            this.cbSPositon.Name = "cbSPositon";
            this.cbSPositon.Size = new System.Drawing.Size(153, 24);
            this.cbSPositon.TabIndex = 8;
            // 
            // txtSSalary
            // 
            this.txtSSalary.Location = new System.Drawing.Point(186, 232);
            this.txtSSalary.Name = "txtSSalary";
            this.txtSSalary.Size = new System.Drawing.Size(137, 22);
            this.txtSSalary.TabIndex = 7;
            // 
            // txtSICN
            // 
            this.txtSICN.Location = new System.Drawing.Point(186, 92);
            this.txtSICN.Name = "txtSICN";
            this.txtSICN.Size = new System.Drawing.Size(170, 22);
            this.txtSICN.TabIndex = 5;
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(186, 13);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(230, 22);
            this.txtSName.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHide
            // 
            this.txtHide.Location = new System.Drawing.Point(92, 214);
            this.txtHide.Name = "txtHide";
            this.txtHide.Size = new System.Drawing.Size(58, 52);
            this.txtHide.TabIndex = 15;
            this.txtHide.Text = "Hide";
            this.txtHide.UseVisualStyleBackColor = true;
            this.txtHide.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Hoạt động",
            "Không hoạt động"});
            this.cbStatus.Location = new System.Drawing.Point(310, 202);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(153, 24);
            this.cbStatus.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Status";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(310, 237);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(137, 22);
            this.txtSalary.TabIndex = 18;
            this.txtSalary.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(248, 240);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(48, 17);
            this.Salary.TabIndex = 19;
            this.Salary.Text = "Salary";
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(185, 164);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(39, 22);
            this.txtSID.TabIndex = 38;
            // 
            // Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1213, 731);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtHide);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtShowDeleted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtICN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.lbHoVaTen);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dtpBirthDay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv);
            this.Name = "Employe";
            this.Load += new System.EventHandler(this.Employe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.txtShowDeleted.ResumeLayout(false);
            this.txtShowDeleted.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbHoVaTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private SalesReportDateSetTableAdapters.BillTableAdapter billTableAdapter1;
        private System.Windows.Forms.TextBox txtICN;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox txtShowDeleted;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtHide;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.DateTimePicker dtpSBirthday;
        private System.Windows.Forms.ComboBox cbSStatus;
        private System.Windows.Forms.ComboBox cbSPositon;
        private System.Windows.Forms.TextBox txtSSalary;
        private System.Windows.Forms.TextBox txtSICN;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSOSalary;
        private System.Windows.Forms.Button btnSOStatus;
        private System.Windows.Forms.Button btnSOID;
        private System.Windows.Forms.Button btnSOPosition;
        private System.Windows.Forms.Button btnSOICN;
        private System.Windows.Forms.Button btnSOBirthday;
        private System.Windows.Forms.Button btnSOName;
        private System.Windows.Forms.TextBox txtSID;
    }
}