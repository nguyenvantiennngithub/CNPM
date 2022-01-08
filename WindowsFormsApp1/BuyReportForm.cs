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
    public partial class BuyReportForm : Form
    {
        int idBill = 0;
        public BuyReportForm(int idBill)
        {
            InitializeComponent();
            this.idBill = idBill;
        }

        private void BuyReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'KMSDataSet.TotalPrice' table. You can move, or remove it, as needed.
            this.TotalPriceTableAdapter.Fill(this.KMSDataSet.TotalPrice, idBill);
            // TODO: This line of code loads data into the 'KMSDataSet.Acount' table. You can move, or remove it, as needed.
            this.AcountTableAdapter.Fill(this.KMSDataSet.Acount, idBill);
            

            this.reportViewer1.RefreshReport();
        }
    }
}
