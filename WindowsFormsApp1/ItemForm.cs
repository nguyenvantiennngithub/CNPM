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

            loadCategoryFind();
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

            if (txbUnit.Text == "")
            {
                MessageBox.Show("The unit of item is empty");
                return false;
            }

            if (!checkEmptyPanel(pnlOption, "The option is empty")) return false;
            if (!checkEmptyPanel(pnlPrice, "The price is empty")) return false;
            if (!checkEmptyPanel(pnlCount, "The count is empty")) return false;

            if (!checkNumberPanel(pnlPrice, "The price contants only numbers")) return false;
            if (!checkNumberPanel(pnlCount, "The count contants only numbers")) return false;

            if (!checkNegativeNumber(pnlPrice, "The price cant negative")) return false;
            
            if (!checkSameValueInPanel(pnlOption, "The options cant same")) return false;
            
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
        }

        private bool checkSame(List<string> list1, FlowLayoutPanel pnl)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < pnl.Controls.Count; j++)
                {
                    TextBox txb = pnl.Controls[j] as TextBox;
                    if (list1[i] == txb.Text)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                return;
            }
    
            if (!checkExistNameItem())//khi tồn tại thì thêm option
            {
                int idCategory = ItemSalesDAO.Instance.getIdCategoryByName(txbName.Text);
                if (idCategory == int.Parse(cbCategory.SelectedValue.ToString()))//Check xem Là item vừa được thêm nó có cùng category k
                {
                    int idItem = ItemSalesDAO.Instance.getIdItemByName(txbName.Text);
                    List<string> listOption = ItemSalesDAO.Instance.getListOptionByIdBill(idItem);
                    if (checkSame(listOption, pnlOption))
                    {
                        MessageBox.Show("There are some options is exist in database");
                    }
                    else
                    {
                        ItemSalesDAO.Instance.addOption(txbName.Text, pnlOption, pnlPrice, pnlCount);
                        loadDgv();
                    }
                }
                else
                {
                    MessageBox.Show("The name of item is exist in database, but diff category," +
                        "please change category or choose a new name of item");
                }
            }
            else//khi không tồn tại thì thêm mới
            {
                ItemSalesDAO.Instance.addItem(
                    int.Parse(cbCategory.SelectedValue.ToString()),
                    txbName.Text, txbUnit.Text, pnlOption, pnlPrice, pnlCount
                );
                clear();
                loadDgv();
            }
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

        private void loadCategoryFind()
        {
            List<ItemType> listCategory = CategoryDAO.Instance.getListCategory();
            ItemType item = new ItemType() {
                idType = -1,
                nameType = "Tất cả"
            };

            listCategory.Insert(0, item);

            cbCategoryFind.DataBindings.Clear();
            cbCategoryFind.DataSource = listCategory;
            cbCategoryFind.DisplayMember = "nameType";
            cbCategoryFind.ValueMember = "idType";
        }

        private void loadDgvFind(List<FullItemDTO> fullItems)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            int idCategory = int.Parse(cbCategoryFind.SelectedValue.ToString());
            string option = txbOptionFind.Text;
            string name = txbNameFind.Text;

            List<FullItemDTO> fullItems = ItemSalesDAO.Instance.getListItemFind(idCategory, name, option);

            loadDgvFind(fullItems);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadDgv();
            cbCategoryFind.SelectedValue = -1;
            txbNameFind.Text = "";
            txbOptionFind.Text = "";
        }
    }
}
