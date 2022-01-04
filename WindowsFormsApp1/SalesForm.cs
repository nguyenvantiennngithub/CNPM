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
    public partial class SalesForm : Form
    {
        List<CategoryGroupBy> listCategory;
        public SalesForm()
        {
            InitializeComponent();
            listCategory = ItemSalesDAO.Instance.GetCategoryGroupBy();
        }

        private void loadCbCategoty()
        {
            listCategory = ItemSalesDAO.Instance.GetCategoryGroupBy();
         
            cbCategory.DataBindings.Clear();
            cbCategory.DisplayMember = "category";
            cbCategory.DataSource = listCategory;
        }

        private void loadCbItem()
        {
            cbProduct.DataBindings.Clear();
            cbProduct.DisplayMember = "item"; 
            cbProduct.DataBindings.Add("DataSource", cbCategory.SelectedValue, "listItem");
        }

        private void loadCbOption()
        {
            cbOption.DataBindings.Clear();
            cbOption.DisplayMember = "option"; ;
            cbOption.DataBindings.Add("DataSource", cbProduct.SelectedValue, "option");
        }

        private void addItemNotExist(OptionCategory option, int count)//add item khi mà trong dgv chưa có 
        {
            if (count < 0)
            {
                MessageBox.Show("the current number lt the number you want to subtract");
                return;
            }
            var index = dgvSales.Rows.Add();
            dgvSales.Rows[index].Cells["index"].Value = index + 1;
            dgvSales.Rows[index].Cells["displayName"].Value = option.Item;
            dgvSales.Rows[index].Cells["option"].Value = option.Option;
            dgvSales.Rows[index].Cells["singlePrice"].Value = option.Price;
            dgvSales.Rows[index].Cells["count"].Value = count;
            dgvSales.Rows[index].Cells["totalPrice"].Value = option.Price * count;
            dgvSales.Rows[index].Cells["idItem"].Value = option.Id;

        }

        private void addItemExist(OptionCategory option, int count, int index)
        {
            int countBefore = int.Parse(dgvSales.Rows[index].Cells["count"].Value.ToString());
            int sumCount = countBefore + count;
            if (sumCount > 0)
            {
                dgvSales.Rows[index].Cells["count"].Value = sumCount;
                dgvSales.Rows[index].Cells["totalPrice"].Value = option.Price * (sumCount);
            }else if (sumCount == 0)
            {
                dgvSales.Rows.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("the current number lt the number you want to subtract");
            }
        }

        private int checkExistItem(string displayName, string option)
        {
            for (int i = 0; i < dgvSales.Rows.Count; i++)
            {
                string displayNameItem = dgvSales.Rows[i].Cells["displayName"].Value.ToString();
                string optionItem = dgvSales.Rows[i].Cells["option"].Value.ToString();
                if (displayName == displayNameItem && option == optionItem) return i;
            }
            return -1;
        }

        private float calcTotalPrice()
        {
            float total = 0;
            for (int i = 0; i < dgvSales.Rows.Count; i++)
            {
                total += float.Parse(dgvSales.Rows[i].Cells["totalPrice"].Value.ToString());
            }
            return total;
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            loadCbCategoty();
        }

        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            loadCbItem();
        }

        private void cbProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            loadCbOption();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count = int.Parse(numCount.Value.ToString());
            OptionCategory option = cbOption.SelectedValue as OptionCategory;
            int isExistItem = checkExistItem(option.Item, option.Option);
            if (count != 0)
            {
                if (isExistItem == -1)
                {
                    addItemNotExist(option, count);
                }
                else
                {
                    addItemExist(option, count, isExistItem);
                }
                txbTotalPrice.Text = calcTotalPrice().ToString();
                btnSubmit.Enabled = dgvSales.Rows.Count > 0;
            }
            else
            {
                MessageBox.Show("the number equal 0, cant add");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure ?", "Alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int idBill = ItemSalesDAO.Instance.Payment(dgvSales.Rows);
                dgvSales.Rows.Clear();
                txbTotalPrice.Text = "0";
                btnSubmit.Enabled = false;

                if (MessageBox.Show("Do you want to print bill", "ask", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    SalesReportForm salesReport = new SalesReportForm(idBill);
                    salesReport.Show();
                }
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
