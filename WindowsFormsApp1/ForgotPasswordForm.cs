using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public partial class ForgotPasswordForm : Form
    {
        private int timeWaint = 50;
        private int time;
        private bool flag = false;
        Acount acount;
        int code;
        public ForgotPasswordForm()
        {
            InitializeComponent();
            time = timeWaint;
        }

        private void sendEmail(string receiver, int code)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(receiver);
            mailMessage.From = new MailAddress("ng.van.sssien.201@gmail.com");
            mailMessage.Body = "Mã xác nhận: " + code.ToString() 
                + " , bạn đang tiến hành đổi mật khẩu. Tuyệt đối không tiết lộ mã xác nhận cho người khác để đảm bảo an toàn cho tài khoản của bạn. " +
                "Nếu như đây không phải thao tác từ bạn, hãy lập tức đổi mật khẩu.";
            mailMessage.Subject = "Mã xác nhận tìm lại mật khẩu";

            using (SmtpClient client = new SmtpClient())
            {
                client.EnableSsl = true;    
                client.UseDefaultCredentials = true;
                client.Credentials = new NetworkCredential("ng.van.tien.201@gmail.com", "0123456789vt");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                try
                {
                    client.Send(mailMessage);
                    MessageBox.Show("Sended");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check exist username ....
            string username = txbUsername.Text;
            acount = ItemSalesDAO.Instance.getAccountByUsername(username);
            if (acount != null)
            {
                Random rand1 = new Random();
                btnSendEmail.Enabled = false;
                timer1.Start();
                btnSendEmail.Text = time.ToString();
                code = rand1.Next(1000, 10000);
                flag = true;
                sendEmail(acount.mailAddress, code);
            }
            else
            {
                MessageBox.Show("Username is not exist");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            if (time <= 0)
            {
                timer1.Stop();
                btnSendEmail.Enabled = true;
                btnSendEmail.Text = "Resend";
                lbCountDown.Text = "0";
                time = timeWaint;
                flag = false;
            }
            else
            {
                btnSendEmail.Text = time.ToString();
                lbCountDown.Text = time.ToString();
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            bool isValid = int.TryParse(txbCode.Text, out int result);
            if (isValid)
            {
                if (code == result && flag)
                {
                    MessageBox.Show("Correct");

                    //will open a change password form
                    ChangePasswordForm passwordForm = new ChangePasswordForm(acount);
                    passwordForm.ShowDialog();

                    //close this form 
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrent code");
                }

            }
            else
            {
                MessageBox.Show("Textbox just receive numbers");
            }
        }
    }
}
