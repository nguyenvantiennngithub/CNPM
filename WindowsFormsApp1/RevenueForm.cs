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
    public partial class RevenueForm : Form
    {
        public RevenueForm()
        {
            InitializeComponent();

            LoadDataComboBox();
            pnListView.Visible = false;
            radiobtnAll.Checked = true;
            cbMonth.Text = DateTime.Now.Month.ToString();
            cbYear.Text = DateTime.Now.Year.ToString();

            LoadAllTime();
        }

        public void NoRecordFound()
        {
            lbTotalFundNum.Text = "0";
            lbTotalFeeNum.Text = "0";
            lbTotalTaxNum.Text = "0";
            lbTotalNum.Text = "0";
            lbTotalIncomeNum.Text = "0";

            lbCurrentDateTime.Text = "Không tìm thấy  dữ liệu bạn cần tìm";

        }

        public void CheckNextRecordByYear(int b)
        {
            if (CostDAO.Instance.CheckRecordByYear(b + 1)) 
            {
                btnNext.Enabled = true;
            }
        }

        public void CheckPreviousRecordByYear(int b)
        {
            if (CostDAO.Instance.CheckRecordByYear(b - 1)) 
            {
                btnLast.Enabled = true;
            }
        }

        public void CheckNextRecordByMonth(int a, int b)
        {
            if (a == 12)
            {
                a = 0;
                b = b + 1;
            }
            if (CostDAO.Instance.CheckRecordByMonth(a + 1, b))
            {
                btnNext.Enabled = true;
            }
        }

        public void CheckPreviousRecordByMonth(int a, int b)
        {
            if (a == 1)
            {
                a = 13;
                b = b - 1;
            }
            if (CostDAO.Instance.CheckRecordByMonth(a - 1, b))
            {
                btnLast.Enabled = true;
            }
        }

        public void LoadDataComboBox()
        {
            for (int i = 0; i <= 12; i++)
            {
                cbMonth.Properties.Items.Add(i.ToString());
            }

            for (int i = CostDAO.Instance.GetFirstYear(); i <= CostDAO.Instance.GetLastYear(); i++)
            {
                cbYear.Properties.Items.Add(i.ToString());
            }
        }

        public void LoadAllTime()
        {
            lbTotalNum.Text = CostDAO.Instance.getTotal().ToString();
            lbTotalFundNum.Text = CostDAO.Instance.getTotalFund().ToString();
            lbTotalFeeNum.Text = CostDAO.Instance.getTotalFee().ToString();
            lbTotalTaxNum.Text =
            lbTotalIncomeNum.Text = CostDAO.Instance.getTotalIncome().ToString();

            lbCurrentDateTime.Text = "Tổng toàn bộ các thời gian hoạt động";
            btnNext.Enabled = false;
            btnLast.Enabled = false;
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radiobtnMonth.Checked)
            {
                int a = int.Parse(cbMonth.Text);
                int b = int.Parse(cbYear.Text);
                if (CostDAO.Instance.CheckRecordByMonth(a, b))
                {
                    lbTotalFundNum.Text = CostDAO.Instance.GetTotalFundByMonth(a, b).ToString();
                    lbTotalFeeNum.Text = CostDAO.Instance.GetTotalFeeByMonth(a, b).ToString();
                    lbTotalTaxNum.Text = CostDAO.Instance.GetTotalFeeByMonth(a, b).ToString();
                    lbTotalNum.Text = CostDAO.Instance.GetTotalByMonth(a, b).ToString();
                    lbTotalIncomeNum.Text = CostDAO.Instance.GetTotalIncomeByMonth(a, b).ToString();

                    lbCurrentDateTime.Text = "Tháng " + a.ToString() + " năm " + b.ToString();

                    LoadDataToListViewByMonth(a, b);

                    CheckNextRecordByMonth(a, b);
                    CheckPreviousRecordByMonth(a, b);
                }
                else
                {
                    NoRecordFound();
                    CheckNextRecordByMonth(a, b);
                    CheckPreviousRecordByMonth(a, b);
                }
            }
        }

        private void radiobtnYear_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnYear.Checked)
            {
                cbYear.Enabled = true;
                cbMonth.Enabled = false;

                int b = int.Parse(cbYear.Text);
                lbTotalFundNum.Text = CostDAO.Instance.GetTotalFundByYear(b).ToString();
                lbTotalFeeNum.Text = CostDAO.Instance.GetTotalFeeByYear(b).ToString();
                lbTotalTaxNum.Text = CostDAO.Instance.GetTotalTaxByYear(b).ToString();
                lbTotalNum.Text = CostDAO.Instance.GetTotalByYear(b).ToString();
                lbTotalIncomeNum.Text = CostDAO.Instance.GetTotalIncomeByYear(b).ToString();

                lbCurrentDateTime.Text = "Năm " + b.ToString();

            }
        }

        private void radiobtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnMonth.Checked)
            {
                cbMonth.Enabled = true;
                cbYear.Enabled = false;

                int a = int.Parse(cbMonth.Text);
                int b = int.Parse(cbYear.Text);
                lbTotalFundNum.Text = CostDAO.Instance.GetTotalFundByMonth(a, b).ToString();
                lbTotalFeeNum.Text = CostDAO.Instance.GetTotalFeeByMonth(a, b).ToString();
                lbTotalTaxNum.Text = CostDAO.Instance.GetTotalFeeByMonth(a, b).ToString();
                lbTotalNum.Text = CostDAO.Instance.GetTotalByMonth(a, b).ToString();
                lbTotalIncomeNum.Text = CostDAO.Instance.GetTotalIncomeByMonth(a, b).ToString();

                lbCurrentDateTime.Text = "Tháng " + a.ToString() + " năm " + b.ToString();

            }
        }

        private void radiobtnAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnAll.Checked)
            {
                cbMonth.Enabled = false;
                cbYear.Enabled = false;
                LoadAllTime();
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radiobtnMonth.Checked)
            {
                int a = int.Parse(cbMonth.Text);
                int b = int.Parse(cbYear.Text);
                if (CostDAO.Instance.CheckRecordByMonth(a, b))
                {
                    lbTotalFundNum.Text = CostDAO.Instance.GetTotalFundByMonth(a, b).ToString();
                    lbTotalFeeNum.Text = CostDAO.Instance.GetTotalFeeByMonth(a, b).ToString();
                    lbTotalTaxNum.Text = CostDAO.Instance.GetTotalFeeByMonth(a, b).ToString();
                    lbTotalNum.Text = CostDAO.Instance.GetTotalByMonth(a, b).ToString();
                    lbTotalIncomeNum.Text = CostDAO.Instance.GetTotalIncomeByMonth(a, b).ToString();

                    lbCurrentDateTime.Text = "Tháng " + a.ToString() + " năm " + b.ToString();

                    LoadDataToListViewByMonth(a, b);

                    CheckNextRecordByMonth(a, b);
                    CheckPreviousRecordByMonth(a, b);
                }
                else
                {
                    NoRecordFound();
                    CheckNextRecordByMonth(a, b);
                    CheckPreviousRecordByMonth(a, b);
                }
            }
            else
            {
                int b = int.Parse(cbYear.Text);
                if (CostDAO.Instance.CheckRecordByYear(b))
                {
                    lbTotalFundNum.Text = CostDAO.Instance.GetTotalFundByYear(b).ToString();
                    lbTotalFeeNum.Text = CostDAO.Instance.GetTotalFeeByYear(b).ToString();
                    lbTotalTaxNum.Text = CostDAO.Instance.GetTotalTaxByYear(b).ToString();
                    lbTotalNum.Text = CostDAO.Instance.GetTotalByYear(b).ToString();
                    lbTotalIncomeNum.Text = CostDAO.Instance.GetTotalIncomeByYear(b).ToString();

                    lbCurrentDateTime.Text = "Năm " + b.ToString();

                    LoadDataToListViewByYear(b);

                    CheckNextRecordByYear(b);
                    CheckPreviousRecordByYear(b);
                }
                else
                {
                    NoRecordFound();
                    CheckNextRecordByYear(b);
                    CheckPreviousRecordByYear(b);
                }
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (radiobtnMonth.Checked)
            {
                int a = int.Parse(cbMonth.Text);
                int b = int.Parse(cbYear.Text);
                if (a == 1)
                {
                    a = 13;
                    b--;
                }
                lbTotalFundNum.Text = CostDAO.Instance.GetTotalFundByMonth(a - 1, b).ToString();
                lbTotalFeeNum.Text = CostDAO.Instance.GetTotalFeeByMonth(a - 1, b).ToString();
                lbTotalTaxNum.Text = CostDAO.Instance.GetTotalFeeByMonth(a - 1, b).ToString();
                lbTotalNum.Text = CostDAO.Instance.GetTotalByMonth(a - 1, b).ToString();
                lbTotalIncomeNum.Text = CostDAO.Instance.GetTotalIncomeByMonth(a - 1, b).ToString();

                lbCurrentDateTime.Text = "Tháng " + (a - 1).ToString() + " năm " + b.ToString();

                CheckNextRecordByMonth(a - 1, b);
                CheckPreviousRecordByMonth(a - 1, b);
            }
            else if (radiobtnYear.Checked)
            {
                int b = int.Parse(cbYear.Text);
                lbTotalFundNum.Text = CostDAO.Instance.GetTotalFundByYear(b - 1).ToString();
                lbTotalFeeNum.Text = CostDAO.Instance.GetTotalFeeByYear(b - 1).ToString();
                lbTotalTaxNum.Text = CostDAO.Instance.GetTotalTaxByYear(b - 1).ToString();
                lbTotalNum.Text = CostDAO.Instance.GetTotalByYear(b - 1).ToString();
                lbTotalIncomeNum.Text = CostDAO.Instance.GetTotalIncomeByYear(b - 1).ToString();

                lbCurrentDateTime.Text = "Năm " + (b - 1).ToString();

                CheckNextRecordByYear(b - 1);
                CheckPreviousRecordByYear(b - 1);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (radiobtnMonth.Checked)
            {
                int a = int.Parse(cbMonth.Text);
                int b = int.Parse(cbYear.Text);
                if (a == 12)
                {
                    a = 0;
                    b++;
                }
                lbTotalFundNum.Text = CostDAO.Instance.GetTotalFundByMonth(a + 1, b).ToString();
                lbTotalFeeNum.Text = CostDAO.Instance.GetTotalFeeByMonth(a + 1, b).ToString();
                lbTotalTaxNum.Text = CostDAO.Instance.GetTotalFeeByMonth(a + 1, b).ToString();
                lbTotalNum.Text = CostDAO.Instance.GetTotalByMonth(a + 1, b).ToString();
                lbTotalIncomeNum.Text = CostDAO.Instance.GetTotalIncomeByMonth(a + 1, b).ToString();

                lbCurrentDateTime.Text = "Tháng " + (a + 1).ToString() + " năm " + b.ToString();

                CheckNextRecordByMonth(a + 1, b);
                CheckPreviousRecordByMonth(a + 1, b);
            }
            else if (radiobtnYear.Checked)
            {
                int b = int.Parse(cbYear.Text);
                lbTotalFundNum.Text = CostDAO.Instance.GetTotalFundByYear(b + 1).ToString();
                lbTotalFeeNum.Text = CostDAO.Instance.GetTotalFeeByYear(b + 1).ToString();
                lbTotalTaxNum.Text = CostDAO.Instance.GetTotalTaxByYear(b + 1).ToString();
                lbTotalNum.Text = CostDAO.Instance.GetTotalByYear(b + 1).ToString();
                lbTotalIncomeNum.Text = CostDAO.Instance.GetTotalIncomeByYear(b + 1).ToString();

                lbCurrentDateTime.Text = "Năm " + (b + 1).ToString();

                CheckNextRecordByYear(b + 1);
                CheckPreviousRecordByYear(b + 1);
            }
        }

        public void LoadDataToListViewByMonth(int a, int b)
        {
            lvCost.Clear();
            lvCost.Columns.Add("Tháng");
            lvCost.Columns.Add("Năm");
            lvCost.Columns.Add("Phí mặt bằng");
            lvCost.Columns.Add("Phí điện");
            lvCost.Columns.Add("Phí nước");
            lvCost.Columns.Add("Tổng vốn");
            lvCost.Columns.Add("Lãi suất ngân hàng");
            lvCost.Columns.Add("Tổng thuế");
            lvCost.Columns.Add("Doanh thu");
            lvCost.Columns.Add("Lợi nhuận");

            List<Cost> list = CostDAO.Instance.GetListCostByMonth(a, b);
            for (int i = 0; i < list.Count(); i++)
            {
                ListViewItem item = new ListViewItem();

                float electricity = float.Parse(list[i].electricityCost.ToString());
                float water = float.Parse(list[i].waterCost.ToString());
                float premise = float.Parse(list[i].premiseCost.ToString());
                float totalFund = float.Parse(list[i].totalFundCost.ToString());
                float tax = float.Parse(list[i].totalTaxCost.ToString());

                item.SubItems.Add(list[i].month.ToString());
                item.SubItems.Add(list[i].year.ToString());
                item.SubItems.Add(premise.ToString());
                item.SubItems.Add(electricity.ToString());
                item.SubItems.Add(water.ToString());
                item.SubItems.Add(totalFund.ToString());
                item.SubItems.Add((float.Parse(list[i].bankInterestExpensePercent.ToString())
                                    * (water + electricity + premise + totalFund + tax)).ToString());
                item.SubItems.Add(list[i].total.ToString());
                item.SubItems.Add(list[i].totalIncome.ToString());

                lvCost.Items.Add(item);

            }
        }

        public void LoadDataToListViewByYear( int b)
        {
            lvCost.Clear();
            lvCost.Columns.Add("Năm");
            lvCost.Columns.Add("Phí mặt bằng");
            lvCost.Columns.Add("Phí điện");
            lvCost.Columns.Add("Phí nước");
            lvCost.Columns.Add("Tổng vốn");
            lvCost.Columns.Add("Lãi suất ngân hàng");
            lvCost.Columns.Add("Tổng thuế");
            lvCost.Columns.Add("Doanh thu");
            lvCost.Columns.Add("Lợi nhuận");

            List<Cost> list = CostDAO.Instance.GetListCostByYear(b);
            for (int i = 0; i < list.Count(); i++)
            {
                ListViewItem item = new ListViewItem();

                float electricity = float.Parse(list[i].electricityCost.ToString());
                float water = float.Parse(list[i].waterCost.ToString());
                float premise = float.Parse(list[i].premiseCost.ToString());
                float totalFund = float.Parse(list[i].totalFundCost.ToString());
                float tax = float.Parse(list[i].totalTaxCost.ToString());

                item.SubItems.Add(list[i].month.ToString());
                item.SubItems.Add(list[i].year.ToString());
                item.SubItems.Add(premise.ToString());
                item.SubItems.Add(electricity.ToString());
                item.SubItems.Add(water.ToString());
                item.SubItems.Add(totalFund.ToString());
                item.SubItems.Add((float.Parse(list[i].bankInterestExpensePercent.ToString())
                                    * (water + electricity + premise + totalFund + tax)).ToString());
                item.SubItems.Add(list[i].total.ToString());
                item.SubItems.Add(list[i].totalIncome.ToString());

                lvCost.Items.Add(item);

            }
        }

        private void lbDetail_Click(object sender, EventArgs e)
        {
            pnListView.Visible = !pnListView.Visible;
        }
    }
}
