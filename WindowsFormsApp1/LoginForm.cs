using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txbpass.PasswordChar == '\0')
            {
                btnhide.BringToFront();
                txbpass.PasswordChar = '*';
            }
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            if (txbpass.PasswordChar == '*')
            {
                btnshow.BringToFront();
                txbpass.PasswordChar = '\0';
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbuser_Enter(object sender, EventArgs e)
        {
            lberror.Visible = false;
            if (txbuser.Text == "Tên đăng nhập")
            {
                txbuser.Text = "";
                txbuser.ForeColor = Color.Black;
            }
        }

        private void txbuser_Leave(object sender, EventArgs e)
        {
            if (txbuser.Text == "")
            {
                txbuser.Text = "Tên đăng nhập";
                txbuser.ForeColor = Color.Gray;
            }
        }

        private void txbpass_Enter(object sender, EventArgs e)
        {
            lberror.Visible = false;
            if (txbpass.Text == "Mật khẩu")
            {
                txbpass.Text = "";
                txbpass.ForeColor = Color.Black;
            }
        }
        private void txbpass_Leave(object sender, EventArgs e)
                {
                    if (txbpass.Text == "")
                    {
                        txbpass.Text = "Mật khẩu";
                        txbpass.ForeColor = Color.Gray;
                    }
                }
        private void txbpass_MouseLeave(object sender, EventArgs e)
        {

        }  
        
        private void btnLogin_Click(object sender, EventArgs e)
        {            
            if (txbuser.Text != "Tên đăng nhập")
            {
                if (txbpass.Text != "Mật khẩu")
                {
                    FormUse formUse = new FormUse();
                    this.Hide();
                    formUse.Show();
                }
                else msgError("    Hãy nhập mật khẩu");
            }
            else msgError("    Hãy nhập tên đăng nhập");
        }

        private void msgError(string msg)
        {
            lberror.Text = "" + msg;
            lberror.Visible = true;

        }

        
    }
}
