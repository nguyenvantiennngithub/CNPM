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
    public partial class SalesReportForm : Form
    {
        int idBill = 0;
        public SalesReportForm(int idBill)
        {
            InitializeComponent();
            this.idBill = idBill;
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SalesReportDateSet.TotalPrice' table. You can move, or remove it, as needed.
            this.TotalPriceTableAdapter.Fill(this.SalesReportDateSet.TotalPrice, idBill);
            MessageBox.Show(idBill.ToString());
            // TODO: This line of code loads data into the 'SalesReportDateSet.Bill' table. You can move, or remove it, as needed.
            this.SalesReportDateSet.EnforceConstraints = false;
            this.BillTableAdapter.Fill(this.SalesReportDateSet.Bill, idBill);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
