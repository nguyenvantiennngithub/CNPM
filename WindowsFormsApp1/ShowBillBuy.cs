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
    public partial class ShowBillBuy : Form
    {
        public ShowBillBuy()
        {
            InitializeComponent();
        }

        private void loadDgv()
        {
            List<BillBuyDTO> listBuyBuy = ItemSalesDAO.Instance.getListBillBuy();
            dgvMain.Rows.Clear();

            foreach (BillBuyDTO b in listBuyBuy)
            {
                var index = dgvMain.Rows.Add();
                dgvMain.Rows[index].Cells["index"].Value = index + 1;
                dgvMain.Rows[index].Cells["id"].Value = b.Id;
                dgvMain.Rows[index].Cells["totalBill"].Value = b.TotalBill;
                dgvMain.Rows[index].Cells["status"].Value = b.Status;
                dgvMain.Rows[index].Cells["creator"].Value = b.Creator;
                dgvMain.Rows[index].Cells["createdAt"].Value = b.CreatedAt;
            }
        }
        private void ShowBillBuy_Load(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                int id = int.Parse(dgvMain.Rows[e.RowIndex].Cells["id"].Value.ToString());
                if (e.ColumnIndex == 6)//show report
                {
                    BuyReportForm buyReportForm = new BuyReportForm(id);
                    buyReportForm.Show();
                }
                else if (e.ColumnIndex == 7)//show detail
                {
                    BillBuyDetailForm billBuy = new BillBuyDetailForm(id);
                    billBuy.ShowDialog();
                    loadDgv();
                }
            }
        }
    }
}
