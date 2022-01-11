using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddAcount : Form { 
        private Acount ac;
        public AddAcount(Acount ac)
        {
            InitializeComponent();
            this.ac = ac;
        }
        bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        private bool checkAccount(string username)
        {
            List<string> acc = AcountDAO.Instance.GetAllAcountUserNameList();
            for (int i = 0; i < acc.Count; i++)
            {
                if (acc[i] == username)
                {
                    return false;
                }
            }
            return true;

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (txbUser.Text == "" || txbCpass.Text == "" || txbPass.Text == "" || txbEmail.Text == "")
            {
                msgError("     Không được để trống");
            }else if (txbCpass.Text != txbPass.Text)
            {
                msgError("     Mật khẩu không khớp");
            }else if (!IsValidEmail(txbEmail.Text)){
                msgError("     Không phải mail");
            }else if (!checkAccount(txbUser.Text))
            {
                msgError("     Username đã tồn tại");
            }
            else
            {
                AcountDAO.Instance.CreateAccount(txbUser.Text, txbPass.Text, txbEmail.Text);
                MessageBox.Show("Đã thêm thành công!");
                loadDGV();
            }
        }

        private void msgError(string msg)
        {
            labelError.Text = "" + msg;
            labelError.Visible = true;

        }
        private void loadDGV()
        {
            List<AccountDTO> list = AcountDAO.Instance.GetUsernameEmail();
            dataGridView1.Rows.Clear();

            foreach (AccountDTO account in list)
            {
                var index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells["username"].Value = account.Username;
                dataGridView1.Rows[index].Cells["email"].Value = account.Email;
            }

        }

        private void AddAcount_Load(object sender, EventArgs e)
        {
            loadDGV();
            labelError.Visible = false;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbEmail_Enter(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }
    }
}
