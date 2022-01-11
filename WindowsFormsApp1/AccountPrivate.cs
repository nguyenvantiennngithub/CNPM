using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class AccountPrivate : Form
    {
        public AccountPrivate(Acount ac)
        {
            InitializeComponent();
            this.ac = ac;
        }
        private Acount ac;

        private void AccountPrivate_Load(object sender, EventArgs e)
        {            
            Employee a = EmployeeDAO.Instance.GetEmployeeByID(ac.idEmployee);
            labelUsername.Text = a.name;
            labelEmail.Text = ac.mailAddress;
            labelAge.Text = a.age.ToString();
            
            /*if (ac.img =="")
            {
                //picUser.Image = global::WindowsFormsApp1.Properties.Resources.user__1_;
            }*/
        }
/*
        private void btnAvata_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            System.IO.File.Copy(openFileDialog.FileName, 
            labelUsername.Text=openFileDialog.FileName;
            labelEmail.Text = Application.StartupPath + @"\image";
        }
*/
        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelAge_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelPost_Click(object sender, EventArgs e)
        {

        }
    }
}
