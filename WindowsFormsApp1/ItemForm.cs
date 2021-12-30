using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private void addTextBox(FlowLayoutPanel pnl)
        {
            TextBox txb = new TextBox();
            pnl.Controls.Add(txb);
        }

        private void removeTextBox(FlowLayoutPanel pnl)
        {
            pnl.Controls.RemoveAt(pnl.Controls.Count -1);
        }
        private void btnAddOption_Click(object sender, EventArgs e)
        {
            if (pnlOption.Controls.Count >= 4)
            {
                MessageBox.Show("Max options is lte 4");
                return;
            }
            addTextBox(pnlOption);
            addTextBox(pnlPrice);
            addTextBox(pnlUnit);
            addTextBox(pnlCount);
        }

        private void btnRemoveOption_Click(object sender, EventArgs e)
        {
            if (pnlOption.Controls.Count <= 1)
            {
                MessageBox.Show("Min options is gte 1");
                return;
            }
            removeTextBox(pnlOption);
            removeTextBox(pnlPrice);
            removeTextBox(pnlUnit);
            removeTextBox(pnlCount);
        }

        private void loadCategory()
        {
            List<ItemType> listCategory = CategoryDAO.Instance.getListCategory();
            cbCategory.DataBindings.Clear();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "nameType";
            cbCategory.ValueMember = "idType";
        }
        private void ItemForm_Load(object sender, EventArgs e)
        {
            loadCategory();
            loadDgv();
        }


        private bool checkEmptyPanel(FlowLayoutPanel pnl, string message)
        {
            foreach (TextBox textBox in pnl.Controls)
            {
                if (textBox.Text == "")
                {
                    MessageBox.Show(message);
                    return false;
                }
            }
            return true;
        }

        private bool checkNumberPanel(FlowLayoutPanel pnl, string message)
        {
            Regex regex = new Regex("^[0-9]+$");
            foreach (TextBox textBox in pnl.Controls)
            {
                if (!regex.IsMatch(textBox.Text))
                {
                    MessageBox.Show(message);
                    return false;
                }
            }

            return true;
        }

        private bool checkNegativeNumber(FlowLayoutPanel pnl, string message)
        {
            foreach (TextBox textBox in pnl.Controls)
            {
                if (int.Parse(textBox.Text.ToString()) < 0)
                {
                    MessageBox.Show(message);
                    return false;
                }
            }

            return true;
        }

        private bool checkSameValueInPanel(FlowLayoutPanel pnl, string message)
        {
            for (int i = 0; i < pnl.Controls.Count - 1; i++)
            {
                for (int j = i + 1; j < pnl.Controls.Count; j++)
                {
                    TextBox textBox1 = pnl.Controls[i] as TextBox;
                    TextBox textBox2 = pnl.Controls[j] as TextBox;
                    if (textBox1.Text == textBox2.Text)
                    {
                        MessageBox.Show(message);
                        return false;
                    }
                }
            }
            return true;
        }

        private bool checkExistNameItem()
        {
            List<string> listNameItem = ItemSalesDAO.Instance.getListNameItem();
            for (int i = 0; i  < listNameItem.Count; i++)
            {
                if (listNameItem[i] == txbName.Text)
                {
                    MessageBox.Show("The name of item is exist");
                    return false;
                }
            }
            return true;
        }

         private bool checkInput()
         {
            if (txbName.Text == "")
            {
                MessageBox.Show("The name of item is empty");
                return false;
            }

            if (!checkEmptyPanel(pnlOption, "The option is empty")) return false;
            if (!checkEmptyPanel(pnlPrice, "The price is empty")) return false;
            if (!checkEmptyPanel(pnlUnit, "The unit is empty")) return false;
            if (!checkEmptyPanel(pnlCount, "The count is empty")) return false;

            if (!checkNumberPanel(pnlPrice, "The price contants only numbers")) return false;
            if (!checkNumberPanel(pnlCount, "The count contants only numbers")) return false;

            if (!checkNegativeNumber(pnlPrice, "The price cant negative")) return false;
            
            if (!checkSameValueInPanel(pnlOption, "The options cant same")) return false;

            if (!checkExistNameItem()) return false;
            
            return true;
         }

        private void clearPanel(FlowLayoutPanel pnl)
        {
            for (int i = pnl.Controls.Count - 1; i >= 1; i--)
            {
                pnl.Controls.Remove(pnl.Controls[i]);
            }
            TextBox txb = pnl.Controls[0] as TextBox;
            txb.Text = "";
        }

        private void clear()
        {
            txbName.Text = "";
            clearPanel(pnlOption);
            clearPanel(pnlCount);
            clearPanel(pnlPrice);
            clearPanel(pnlUnit);
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                return;
            }
            ItemSalesDAO.Instance.addItem(
                int.Parse(cbCategory.SelectedValue.ToString()),
                txbName.Text, pnlOption, pnlPrice, pnlUnit, pnlCount
            );
            clear();
            loadDgv();
        }


        private void loadDgv()
        {
            List<FullItemDTO> fullItems = ItemSalesDAO.Instance.getFullItem();
            dgvMain.Rows.Clear();
            for (int i = 0; i < fullItems.Count; i++)
            {
                FullItemDTO item = fullItems[i];

                var index = dgvMain.Rows.Add();
                dgvMain.Rows[index].Cells["index"].Value = index + 1;
                dgvMain.Rows[index].Cells["id"].Value = item.Id;
                dgvMain.Rows[index].Cells["category"].Value = item.Category;
                dgvMain.Rows[index].Cells["name"].Value = item.Name;
                dgvMain.Rows[index].Cells["option"].Value = item.Option;
                dgvMain.Rows[index].Cells["price"].Value = item.Price;
                dgvMain.Rows[index].Cells["count"].Value = item.Count;
                dgvMain.Rows[index].Cells["unit"].Value = item.Unit;
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
