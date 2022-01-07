using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace WindowsFormsApp1
{
    public partial class ChartBillDetailForm : Form
    {
        public ChartBillDetailForm()
        {
            InitializeComponent();
            SetDataToComboBox();

            cbYear.Text = DateTime.Now.Year.ToString();
            cbFromYear.Text = DateTime.Now.Year.ToString();
            cbToYear.Text = DateTime.Now.Year.ToString();
            btnYearConfirm.PerformClick();
        }

        public void SetDataToComboBox()
        {
            List<int> list = new List<int>();
            for( int i = CostDAO.Instance.GetFirstYear(); i<=CostDAO.Instance.GetLastYear(); i++)
            {
                list.Add(i);
            }
            
            cbYear.DataSource = list;
            cbFromYear.DataSource = list;
            cbToYear.DataSource = list;
            cbYearItem.DataSource = list;

            
            cbItemName.DataSource = ItemDAO.Instance.GetListItemName();
        }
        
        private void btnYearConfirm_Click(object sender, EventArgs e)
        {
            chartDetail.Series["chartDetailSeries"].Points.Clear();
            int year = int.Parse(cbYear.Text);
            lbTitle.Text = "Lợi nhuận năm " + year.ToString();
            List<Cost> list = CostDAO.Instance.GetListCostByYear(year);
            chartDetail.Series["chartDetailSeries"].LegendText = "Lợi nhuận";
            foreach (Cost item in list)
            {
                chartDetail.Series["chartDetailSeries"]
                        .Points.AddXY("Tháng " + item.month.ToString(), item.totalIncome.ToString());
            }
        }

        private void btnFromYearToYear_Click(object sender, EventArgs e)
        {
            chartDetail.Series["chartDetailSeries"].Points.Clear();
            int fromYear = int.Parse(cbFromYear.Text);
            int toYear = int.Parse(cbToYear.Text);
            lbTitle.Text = "Lợi nhuận từ năm " + fromYear.ToString()
                            + " đến năm " + toYear.ToString();
            List<Cost> list = CostDAO.Instance.GetListCostFromYearToYear(fromYear, toYear);
            chartDetail.Series["chartDetailSeries"].LegendText = "Lợi nhuận";
            foreach (Cost item in list)
            {
                chartDetail.Series["chartDetailSeries"]
                        .Points.AddXY("Năm " + item.year.ToString(), item.totalIncome.ToString());
            }
        }

        private void btnItemYear_Click(object sender, EventArgs e)
        {
            chartDetail.Series["chartDetailSeries"].Points.Clear();

            int year = int.Parse(cbYearItem.Text);
            int id = ItemDAO.Instance.GetItemIDByName(cbItemName.Text);

            lbTitle.Text = "Số lượng bán của " + cbItemName.Text + " năm " + year.ToString();
            
            chartDetail.Series["chartDetailSeries"].LegendText = "Số lượng";

            List<int> list = BillDetailDAO.Instance.GetAmountSaleByYearOfItem(year, id);
            for (int i = 0; i< list.Count; i++)
            {
                chartDetail.Series["chartDetailSeries"]
                        .Points.AddXY("Tháng " + (i+1).ToString(), list[i]);
            }
        }

  
    }
}
