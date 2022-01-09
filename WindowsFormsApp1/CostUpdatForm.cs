using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class CostUpdatForm : Form
    {
        private Cost cost;
        public CostUpdatForm()
        {
            InitializeComponent();

            lbTitle.Text = "Hãy chọn tháng, năm";
        }

        public void ResetTextBox()
        {
            txbElectricFeeChange.Text = "";
            txbWaterFeeChange.Text = "";
            txbPremiseFeechange.Text = "";
            txbBankInterestChange.Text = "";

            txbElectricFee.Text = "";
            txbWaterFee.Text = "";
            txbPremiseFee.Text = "";
            txbBankInterest.Text = "";
        }


        private void txbWaterFeeChange_TextChanged(object sender, EventArgs e)
        {
            TextBox a = sender as TextBox;
            Regex regex = new Regex("^[0-9]+([.]([0-9]+)?)?$");
            if (!regex.IsMatch(a.Text))
            {
                if (a.Text.Length > 0)
                {
                    a.Text = a.Text.Remove(a.Text.Length - 1);
                    a.SelectionStart = a.Text.Length;
                }
            }
        }

        private void txbYear_TextChanged(object sender, EventArgs e)
        {
            TextBox a = sender as TextBox;
            Regex regex = new Regex("^[^0-9]+$");
            if (regex.IsMatch(a.Text))
            {
                if (a.Text.Length > 0)
                {
                    a.Text = a.Text.Remove(a.Text.Length - 1);
                    a.SelectionStart = a.Text.Length;
                }
            }
        }

        private void txbElectricFeeChange_TextChanged(object sender, EventArgs e)
        {
            TextBox a = sender as TextBox;
            Regex regex = new Regex("^[0-9]+([.]([0-9]+)?)?$");
            if (!regex.IsMatch(a.Text))
            {
                if (a.Text.Length > 0)
                {
                    a.Text = a.Text.Remove(a.Text.Length - 1);
                    a.SelectionStart = a.Text.Length;
                }
            }
        }

        private void txbMonth_TextChanged_1(object sender, EventArgs e)
        {
            TextBox a = sender as TextBox;
            Regex regex = new Regex("^[^0-9]+$");
            if (regex.IsMatch(a.Text))
            {
                if (a.Text.Length > 0)
                {
                    a.Text = a.Text.Remove(a.Text.Length - 1);
                    a.SelectionStart = a.Text.Length;
                }
            }
            if (a.Text.Length > 0)
            {
                if (int.Parse(a.Text) < 1 || int.Parse(a.Text) > 12)
                {
                    a.Text = a.Text.Remove(a.Text.Length - 1);
                    a.SelectionStart = a.Text.Length;
                }
            }
        }
        private void txbPremiseFeechange_TextChanged(object sender, EventArgs e)
        {
            TextBox a = sender as TextBox;
            Regex regex = new Regex("^[0-9]+([.]([0-9]+)?)?$");
            if (!regex.IsMatch(a.Text))
            {
                if (a.Text.Length > 0)
                {
                    a.Text = a.Text.Remove(a.Text.Length - 1);
                    a.SelectionStart = a.Text.Length;
                }
            }
        }

        private void txbBankInterestChange_TextChanged(object sender, EventArgs e)
        {
            TextBox a = sender as TextBox;
            Regex regex = new Regex("^[0-9]+([.]([0-9]+)?)?$");
            if (!regex.IsMatch(a.Text))
            {
                if (a.Text.Length > 0)
                {
                    a.Text = a.Text.Remove(a.Text.Length - 1);
                    a.SelectionStart = a.Text.Length;
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (txbMonth.Text == "")
            {
                MessageBox.Show("Chưa chọn Tháng, Năm");
                return;
            }
            int month = int.Parse(txbMonth.Text);
            int year = int.Parse(txbYear.Text);


            if (!CostDAO.Instance.CheckRecordByMonth(month, year))
            {
                MessageBox.Show("Không có dữ liệu tìm thấy!");
                return;
            }

            lbTitle.Text = "Tháng " + month.ToString() + " năm " + year.ToString();

            cost = CostDAO.Instance.GetRecordCostByMonth(month, year);

            txbElectricFeeChange.Text = cost.electricityCost.ToString();
            txbWaterFeeChange.Text = cost.waterCost.ToString();
            txbPremiseFeechange.Text = cost.premiseCost.ToString();
            txbBankInterestChange.Text = cost.bankInterestExpensePercent.ToString();

            txbElectricFee.Text = cost.electricityCost.ToString();
            txbWaterFee.Text = cost.waterCost.ToString();
            txbPremiseFee.Text = cost.premiseCost.ToString();
            txbBankInterest.Text = cost.bankInterestExpensePercent.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbElectricFeeChange.Text == "" || txbWaterFeeChange.Text == "" || txbPremiseFeechange.Text == "" || txbBankInterestChange.Text == "")
            {
                MessageBox.Show("Text box cant empty");
                return;
            }    
            if (cost == null)
            {
                MessageBox.Show("Vui lòng chọn tháng, năm trước!");
                return;
            }
            else
            {
                float electric = float.Parse(txbElectricFeeChange.Text);
                float water = float.Parse(txbWaterFeeChange.Text);
                float premise = float.Parse(txbPremiseFeechange.Text);
                float bankIntered = float.Parse(txbBankInterestChange.Text);

                CostDAO.Instance.UpdateCostByMonth(cost.month, cost.year, electric, water, premise, bankIntered);

                lbTitle.Text = "Hãy chọn tháng, năm!";
                ResetTextBox();
                MessageBox.Show("Cập nhật dữ liệu thành công");
            }

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txbBankInterest_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txbPremiseFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txbWaterFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txbElectricFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
