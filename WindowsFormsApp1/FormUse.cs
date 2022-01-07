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

namespace GiaoDien
{
    public partial class FormUse : Form
    {
        private Form activeForm;
        public FormUse()
        {
            InitializeComponent();
            HideAllllSubMenu();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(childForm);
            this.panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void HideAllllSubMenu()
        {
            panelMenuAcount.Visible = false;
            panelMenuEmployee.Visible = false;
            panelbill.Visible = false;
        }

        private void ibtnPayment_Click(object sender, EventArgs e)
        {
            HideAllllSubMenu();
            if (activeForm != null)
                activeForm.Close();
            lblTitle.Text = "THANH TOÁN";
        }

        private void ibtnAcount_Click(object sender, EventArgs e)
        {
            bool check = panelMenuAcount.Visible;
            HideAllllSubMenu();
            panelMenuAcount.Visible = !check;
        }

        private void ibtnBill_Click(object sender, EventArgs e)
        {
            bool check = panelbill.Visible;
            HideAllllSubMenu();
            panelbill.Visible = !check;
        }

        private void ibtnEmployee_Click(object sender, EventArgs e)
        {
            bool check = panelMenuEmployee.Visible;
            HideAllllSubMenu();
            panelMenuEmployee.Visible = !check;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ibtnAcountPrivate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AcountPrivateForm(this), sender);
            lblTitle.Text = "TÀI KHOẢN CÁ NHÂN";
        }

        private void ibtnAcountAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AcountAddForm(), sender);
            lblTitle.Text = "THÊM TÀI KHOẢN";
        }

        private void ibtnRevenue_Click(object sender, EventArgs e)
        {
            HideAllllSubMenu();
            OpenChildForm(new Forms.RevenueForm(), sender);
            lblTitle.Text = "DOANH THU";
        }

        private void ibtnEmployeeList_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.AcountDeleteForm(), sender);
            lblTitle.Text = "DANH SÁCH NHÂN VIÊN";
        }

        private void ibtnEmployeeAdd_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.Form3(), sender);
            lblTitle.Text = "THÊM";
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.Form1(), sender);
            lblTitle.Text = "HOÁ ĐƠN NHẬP";
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.Form2(), sender);
            lblTitle.Text = "HOÁ ĐƠN XUẤT";
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
