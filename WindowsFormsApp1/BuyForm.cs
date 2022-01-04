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
    public partial class BuyForm : Form
    {
        List<CategoryGroupBy> listCategory;
        public BuyForm()
        {
            InitializeComponent();
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
     

       
        private void BuyForm_Load(object sender, EventArgs e)
        {
            loadCbCategoty();
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


        private void addItemNotExist(OptionCategory option, int count, string price, string note, string miss)//add item khi mà trong dgv chưa có 
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
            dgvSales.Rows[index].Cells["singlePrice"].Value = price;
            dgvSales.Rows[index].Cells["count"].Value = count;
            dgvSales.Rows[index].Cells["totalPrice"].Value = float.Parse(price) * count;
            dgvSales.Rows[index].Cells["miss"].Value = miss;
            dgvSales.Rows[index].Cells["idItem"].Value = option.Id;
            dgvSales.Rows[index].Cells["note"].Value = note;
            dgvSales.Rows[index].Cells["category"].Value = option.Category;

        }

        private void addItemExist(OptionCategory option, int count, int index, string price, string note, string miss)
        {
            int countBefore = int.Parse(dgvSales.Rows[index].Cells["count"].Value.ToString());
            int sumCount = countBefore + count;
            if (sumCount > 0)
            {
                dgvSales.Rows[index].Cells["count"].Value = sumCount;
                dgvSales.Rows[index].Cells["totalPrice"].Value = float.Parse(price) * (sumCount);
                dgvSales.Rows[index].Cells["note"].Value = note;
                dgvSales.Rows[index].Cells["singlePrice"].Value = price;
                dgvSales.Rows[index].Cells["miss"].Value = miss;
            }
            else if (sumCount == 0)
            {
                dgvSales.Rows.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("the current number lt the number you want to subtract");
            }
        }

        private bool checkInput()
        {
            if (txbPrice.Text == "")
            {
                MessageBox.Show("Price cant empty");
                return false;
            }else if(!int.TryParse(txbPrice.Text, out int result))
            {
                MessageBox.Show("Price just receive numbers");
                return false;
            }else if (!int.TryParse(txbPrice.Text, out int result1))
            {
                MessageBox.Show("Missing count just receive numbers");
                return false;
            }
            else if (result <= 0)
            {
                MessageBox.Show("Price cant negative");
                return false;
            }
            else if (result1 < 0)
            {
                MessageBox.Show("Missing count cant negative");
                return false;
            }
            else if (result1 < 0)
            {
                MessageBox.Show("Missing count cant negative");
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkInput()) return;

            int count = int.Parse(numCount.Value.ToString());
            OptionCategory option = cbOption.SelectedValue as OptionCategory;
            int isExistItem = checkExistItem(option.Item, option.Option);
            if (count != 0)
            {
                if (isExistItem == -1)
                {
                    if (int.Parse(txbMiss.Text.ToString()) > count)
                    {
                        MessageBox.Show("Missing count cant gt count");
                    }
                    else
                    {
                        addItemNotExist(option, count, txbPrice.Text, txbNote.Text, txbMiss.Text);
                    }
                }
                else
                {
                    int countBefore = int.Parse(dgvSales.Rows[isExistItem].Cells["count"].Value.ToString());
                    if (int.Parse(txbMiss.Text.ToString()) > count + countBefore)
                    {
                        MessageBox.Show("Missing count cant gt count");
                    }
                    else { 
                        addItemExist(option, count, isExistItem, txbPrice.Text, txbNote.Text, txbMiss.Text);
                    }
                }
                txbTotalPrice.Text = calcTotalPrice().ToString();
                btnSubmit.Enabled = dgvSales.Rows.Count > 0;
            }
            else
            {
                MessageBox.Show("the number equal 0, cant add");
            }
        }

        private void clearPriceNote()
        {
            txbPrice.Text = "";
            txbNote.Text = "";
        }

        private void cbCategory_SelectedValueChanged_1(object sender, EventArgs e)
        {
            loadCbItem();
        }

        private void cbProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            loadCbOption();
        }

        private void cbOption_SelectedValueChanged(object sender, EventArgs e)
        {
            clearPriceNote();
            OptionCategory optionCB = cbOption.SelectedValue as OptionCategory;
            for (int i = 0; i < dgvSales.Rows.Count; i++)
            {
                int id = int.Parse(dgvSales.Rows[i].Cells["idItem"].Value.ToString());
                string category = dgvSales.Rows[i].Cells["category"].Value.ToString();
                string option = dgvSales.Rows[i].Cells["option"].Value.ToString();
                string note = dgvSales.Rows[i].Cells["note"].Value.ToString();
                string singlePrice = dgvSales.Rows[i].Cells["singlePrice"].Value.ToString();
                string miss = dgvSales.Rows[i].Cells["miss"].Value.ToString();

                if (optionCB.Id == id && optionCB.Category == category && optionCB.Option == option)
                {
                    txbNote.Text = note;
                    txbPrice.Text = singlePrice;
                    txbMiss.Text = miss;    
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure ?", "Alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int idBill = ItemSalesDAO.Instance.import(dgvSales.Rows);
                dgvSales.Rows.Clear();
                txbTotalPrice.Text = "0";
                btnSubmit.Enabled = false;
                MessageBox.Show("Imported");
                if (MessageBox.Show("Do you want to print bill", "ask", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BuyReportForm salesReport = new BuyReportForm(idBill);
                    salesReport.Show();
                }
            }
        }
    }
}
