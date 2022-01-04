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
    public partial class BillBuyDetailForm : Form
    {
        private int idBill;
        public BillBuyDetailForm(int idBill)
        {
            InitializeComponent();
            this.idBill = idBill;
        }

        private void loadDgv()
        {
            List<BillBuyDetailDTO> data = ItemSalesDAO.Instance.GetBillBuyDetails(idBill);
            dgvMain.Rows.Clear();``
            foreach (BillBuyDetailDTO b in data)
            {
                var index = dgvMain.Rows.Add();
                dgvMain.Rows[index].Cells["index"].Value = index + 1;
                dgvMain.Rows[index].Cells["idItem"].Value = b.IdItem;
                dgvMain.Rows[index].Cells["item"].Value = b.Item;
                dgvMain.Rows[index].Cells["option"].Value = b.Option;
                dgvMain.Rows[index].Cells["count"].Value = b.Count.ToString();
                dgvMain.Rows[index].Cells["singlePrice"].Value = b.SinglePrice.ToString();
                dgvMain.Rows[index].Cells["totalPrice"].Value = b.Count * b.SinglePrice;
                dgvMain.Rows[index].Cells["status"].Value = b.Status;
                dgvMain.Rows[index].Cells["miss"].Value = b.Miss;
                dgvMain.Rows[index].Cells["unit"].Value = b.Unit;
                dgvMain.Rows[index].Cells["note"].Value = b.Note;
            }
        }

        private void BillBuyDetailForm_Load(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                txbId.Text = dgvMain.Rows[e.RowIndex].Cells["idItem"].Value.ToString();
                txbOption.Text = dgvMain.Rows[e.RowIndex].Cells["option"].Value.ToString();
                txbCount.Value = int.Parse(dgvMain.Rows[e.RowIndex].Cells["count"].Value.ToString());
                txbSinglePrice.Text = dgvMain.Rows[e.RowIndex].Cells["singlePrice"].Value.ToString();
                txbTotalPrice.Text = (int.Parse(txbSinglePrice.Text) * txbCount.Value).ToString();
                txbStatus.Text = dgvMain.Rows[e.RowIndex].Cells["status"].Value.ToString();
                txbMiss.Text = dgvMain.Rows[e.RowIndex].Cells["miss"].Value.ToString();
                txbUnit.Text = dgvMain.Rows[e.RowIndex].Cells["unit"].Value.ToString();
                if (dgvMain.Rows[e.RowIndex].Cells["note"].Value == null)
                {
                    txbNote.Text = "";
                }
                else
                {
                    txbNote.Text = dgvMain.Rows[e.RowIndex].Cells["note"].Value.ToString();
                }
            }

        }

        private bool check()
        {
            if (txbId.Text == "")
            {
                MessageBox.Show("Choose yet");
                return false;
            } else if (txbMiss.Text == "" || txbNote.Text == "" || txbSinglePrice.Text == "")
            {
                MessageBox.Show("textbox empty");
                return false;
            }else if (!int.TryParse(txbMiss.Text, out int result) || !int.TryParse(txbSinglePrice.Text, out int result1))
            {
                MessageBox.Show("textbox miss and textbox price just receive numbers");
                return false;
            }else if (result1 <= 0)
            {
                MessageBox.Show("Price must be gt 0");
                return false;
            }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            ItemSalesDAO.Instance.editBillBuyDetail(
                idBill, txbOption.Text, int.Parse(txbId.Text),
                (int)txbCount.Value, float.Parse(txbSinglePrice.Text),
                int.Parse(txbMiss.Text), txbNote.Text);
            loadDgv();
        }
    }
}
