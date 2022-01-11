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

namespace WindowsFormsApp1
{

    public partial class FormUse : Form
    {
        private Acount ac;

        private Form activeForm;
        public FormUse(Acount ac)
        {
            InitializeComponent();
            HideAllllSubMenu();
            this.ac = ac;
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
            pnlRevenue.Visible = false;
            panelbill.Visible = false;
            pnlItem.Visible = false;
        }

        private void ibtnPayment_Click(object sender, EventArgs e)
        {
            HideAllllSubMenu();
            if (activeForm != null)
                activeForm.Close();            
            OpenChildForm(new SalesForm(), sender);
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
           
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ibtnAcountPrivate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AccountPrivate(ac), sender);
            lblTitle.Text = "TÀI KHOẢN CÁ NHÂN";
        }

        private void ibtnAcountAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddAcount(ac), sender);
            lblTitle.Text = "THÊM TÀI KHOẢN";
        }

        private void ibtnRevenue_Click(object sender, EventArgs e)
        {
            HideAllllSubMenu();
            //OpenChildForm(new Forms.RevenueForm(), sender);
            lblTitle.Text = "DOANH THU";
        }

        private void ibtnEmployeeList_Click(object sender, EventArgs e)
        {

            ////OpenChildForm(new Forms.AcountDeleteForm(), sender);
            lblTitle.Text = "DANH SÁCH NHÂN VIÊN";
        }

        private void ibtnEmployeeAdd_Click(object sender, EventArgs e)
        {
            ////OpenChildForm(new Forms.Form3(), sender);
            lblTitle.Text = "THÊM";
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShowBillBuy(), sender);
            lblTitle.Text = "HOÁ ĐƠN NHẬP";
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BillForm(), sender);
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

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            bool check = pnlRevenue.Visible;
            HideAllllSubMenu();
            pnlRevenue.Visible = !check;
        }

        private void btnRevenueIn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Revenue(), sender);
            lblTitle.Text = "DOANH THU BÁN";
        }

        private void btnRenevueOut_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CostUpdatForm(), sender);
            lblTitle.Text = "CẬP NHẬT";
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            HideAllllSubMenu();
            OpenChildForm(new Employe(), sender);
            lblTitle.Text = "NHÂN VIÊN";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            bool check = pnlItem.Visible;
            HideAllllSubMenu();
            pnlItem.Visible = !check;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CategoryForm(), sender);
            lblTitle.Text = "LOẠI SẢN PHẨM";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ItemForm(), sender);
            lblTitle.Text = "THÊM SẢN PHẨM";

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ItemEditForm(), sender);
            lblTitle.Text = "SỬA SẢN PHẨM";
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChartBillDetailForm(), sender);
            lblTitle.Text = "THỐNG KÊ";

        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            HideAllllSubMenu();
            OpenChildForm(new BuyForm(), sender);

        }

        private void FormUse_Load(object sender, EventArgs e)
        {
            OpenChildForm(new SalesForm(), sender);
            lblTitle.Text = "NHẬP HÀNG";
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmini.Visible = true;
            btnmax.Visible = false;
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnmax.Visible = true;
            btnmini.Visible = false;            
        }
    }
}
