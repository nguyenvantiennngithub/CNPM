
namespace WindowsFormsApp1
{
    partial class ForgotPasswordForm
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
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txbCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.Ente = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCountDown = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(213, 109);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(75, 23);
            this.btnSendEmail.TabIndex = 0;
            this.btnSendEmail.Text = "Send";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(107, 177);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(100, 20);
            this.txbCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter code";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(213, 174);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 3;
            this.btnVerify.Text = "Submit";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // Ente
            // 
            this.Ente.AutoSize = true;
            this.Ente.Location = new System.Drawing.Point(18, 112);
            this.Ente.Name = "Ente";
            this.Ente.Size = new System.Drawing.Size(81, 13);
            this.Ente.TabIndex = 5;
            this.Ente.Text = "Enter username";
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(107, 109);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(100, 20);
            this.txbUsername.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Change Password Form";
            // 
            // lbCountDown
            // 
            this.lbCountDown.AutoSize = true;
            this.lbCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountDown.ForeColor = System.Drawing.Color.Red;
            this.lbCountDown.Location = new System.Drawing.Point(231, 135);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(0, 20);
            this.lbCountDown.TabIndex = 35;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 220);
            this.Controls.Add(this.lbCountDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Ente);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.btnSendEmail);
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label Ente;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCountDown;
    }
}