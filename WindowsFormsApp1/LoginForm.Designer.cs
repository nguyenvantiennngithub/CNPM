namespace WindowsFormsApp1
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lberror = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnhide = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnshow = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txbuser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnhide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 506);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 82F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 127);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.electronics_shop;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(51, 223);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(237, 199);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.btnhide);
            this.panel2.Controls.Add(this.btnshow);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.guna2CircleButton1);
            this.panel2.Controls.Add(this.txbuser);
            this.panel2.Controls.Add(this.txbpass);
            this.panel2.Controls.Add(this.guna2CirclePictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(344, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 506);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lberror);
            this.panel3.Location = new System.Drawing.Point(43, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 34);
            this.panel3.TabIndex = 14;
            // 
            // lberror
            // 
            this.lberror.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lberror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberror.ForeColor = System.Drawing.Color.Red;
            this.lberror.Image = global::WindowsFormsApp1.Properties.Resources.warn213;
            this.lberror.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lberror.Location = new System.Drawing.Point(0, 0);
            this.lberror.Name = "lberror";
            this.lberror.Size = new System.Drawing.Size(368, 34);
            this.lberror.TabIndex = 12;
            this.lberror.Text = "     Error";
            this.lberror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(160, 472);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 25);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.DisabledState.Parent = this.btnLogin;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(136, 408);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(180, 46);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnhide
            // 
            this.btnhide.BackColor = System.Drawing.Color.White;
            this.btnhide.Image = global::WindowsFormsApp1.Properties.Resources.blind;
            this.btnhide.ImageRotate = 0F;
            this.btnhide.Location = new System.Drawing.Point(305, 306);
            this.btnhide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhide.Name = "btnhide";
            this.btnhide.ShadowDecoration.Parent = this.btnhide;
            this.btnhide.Size = new System.Drawing.Size(40, 39);
            this.btnhide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnhide.TabIndex = 10;
            this.btnhide.TabStop = false;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.White;
            this.btnshow.Image = global::WindowsFormsApp1.Properties.Resources.show__1_;
            this.btnshow.ImageRotate = 0F;
            this.btnshow.Location = new System.Drawing.Point(305, 306);
            this.btnshow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnshow.Name = "btnshow";
            this.btnshow.ShadowDecoration.Parent = this.btnshow;
            this.btnshow.Size = new System.Drawing.Size(40, 39);
            this.btnshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnshow.TabIndex = 9;
            this.btnshow.TabStop = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(43, 304);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.user__3_;
            this.pictureBox1.Location = new System.Drawing.Point(43, 233);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.remove;
            this.guna2CircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.DisabledState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(373, 26);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(60, 50);
            this.guna2CircleButton1.TabIndex = 6;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // txbuser
            // 
            this.txbuser.BackColor = System.Drawing.Color.Transparent;
            this.txbuser.BorderColor = System.Drawing.Color.Aqua;
            this.txbuser.BorderRadius = 18;
            this.txbuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbuser.DefaultText = "Tên đăng nhập";
            this.txbuser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbuser.DisabledState.Parent = this.txbuser;
            this.txbuser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbuser.FocusedState.Parent = this.txbuser;
            this.txbuser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txbuser.ForeColor = System.Drawing.Color.Gray;
            this.txbuser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbuser.HoverState.Parent = this.txbuser;
            this.txbuser.Location = new System.Drawing.Point(100, 233);
            this.txbuser.Margin = new System.Windows.Forms.Padding(5);
            this.txbuser.Name = "txbuser";
            this.txbuser.PasswordChar = '\0';
            this.txbuser.PlaceholderText = "";
            this.txbuser.SelectedText = "";
            this.txbuser.SelectionStart = 13;
            this.txbuser.ShadowDecoration.Parent = this.txbuser;
            this.txbuser.Size = new System.Drawing.Size(259, 44);
            this.txbuser.TabIndex = 4;
            this.txbuser.Enter += new System.EventHandler(this.txbuser_Enter);
            this.txbuser.Leave += new System.EventHandler(this.txbuser_Leave);
            // 
            // txbpass
            // 
            this.txbpass.BorderColor = System.Drawing.Color.Aqua;
            this.txbpass.BorderRadius = 18;
            this.txbpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbpass.DefaultText = "Mật khẩu";
            this.txbpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbpass.DisabledState.Parent = this.txbpass;
            this.txbpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbpass.FocusedState.Parent = this.txbpass;
            this.txbpass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txbpass.ForeColor = System.Drawing.Color.Gray;
            this.txbpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbpass.HoverState.Parent = this.txbpass;
            this.txbpass.Location = new System.Drawing.Point(100, 304);
            this.txbpass.Margin = new System.Windows.Forms.Padding(5);
            this.txbpass.Name = "txbpass";
            this.txbpass.PasswordChar = '*';
            this.txbpass.PlaceholderText = "";
            this.txbpass.SelectedText = "";
            this.txbpass.SelectionStart = 8;
            this.txbpass.ShadowDecoration.Parent = this.txbpass;
            this.txbpass.Size = new System.Drawing.Size(259, 44);
            this.txbpass.TabIndex = 5;
            this.txbpass.Enter += new System.EventHandler(this.txbpass_Enter);
            this.txbpass.Leave += new System.EventHandler(this.txbpass_Leave);
            this.txbpass.MouseLeave += new System.EventHandler(this.txbpass_MouseLeave);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.user__1_;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(120, 14);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(225, 199);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnhide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox btnhide;
        private Guna.UI2.WinForms.Guna2PictureBox btnshow;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2TextBox txbuser;
        private Guna.UI2.WinForms.Guna2TextBox txbpass;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label lberror;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel3;
    }
}