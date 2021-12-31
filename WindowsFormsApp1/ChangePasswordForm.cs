using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ChangePasswordForm : Form
    {
        Acount acount;
        public ChangePasswordForm(Acount acount)
        {
            InitializeComponent();
            this.acount = acount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass1 = txbPassword.Text;
            string pass2 = txbPassword2.Text;

            if (pass1 == "")
            {
                MessageBox.Show("Password cant empty");
            }else if (pass1 != pass2)
            {
                MessageBox.Show("Password confirm incorrect");
            }
            else
            {
                ItemSalesDAO.Instance.changePassword(acount.username, pass1);
                MessageBox.Show("password changed");
                this.Close();
            }
        }
    }
}
