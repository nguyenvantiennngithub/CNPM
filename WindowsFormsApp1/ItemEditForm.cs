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
    public partial class ItemEditForm : Form
    {
        public ItemEditForm()
        {
            InitializeComponent();
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                dgvMain.Rows[index].Cells["idCategory"].Value = item.IdCategory;//hidden field
            }
        }

        private void ItemEditForm_Load(object sender, EventArgs e)
        {
            loadDgv();
            loadCategory();
            loadCategoryFind();
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 8)//eidt
                {
                    txbId.Text = dgvMain.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    cbCategory.SelectedItem = dgvMain.Rows[e.RowIndex].Cells["category"].Value.ToString();
                    txbName.Text = dgvMain.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    txbOption.Text = dgvMain.Rows[e.RowIndex].Cells["option"].Value.ToString();
                    txbPrice.Text = dgvMain.Rows[e.RowIndex].Cells["price"].Value.ToString();
                    txbCount.Text = dgvMain.Rows[e.RowIndex].Cells["count"].Value.ToString();
                    txbUnit.Text = dgvMain.Rows[e.RowIndex].Cells["unit"].Value.ToString();

                    
                }
                else if (e.ColumnIndex == 9)//delete
                {

                }
            }
        }

        private void loadCategory()
        {
            List<ItemType> listCategory = CategoryDAO.Instance.getListCategory();
            cbCategory.DataBindings.Clear();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "nameType";
            cbCategory.ValueMember = "nameType";
        }

        private bool checkEmpty(TextBox txb, string message)
        {
            if (txb.Text.ToString() == "")
            {
                MessageBox.Show(message);
                return false;
            }
            return true;
        }

        private bool checkNumber(TextBox txb, string message)
        {
            bool isValid = int.TryParse(txb.Text, out int result);
            if (!isValid)
            {
                MessageBox.Show(message);
                return false;
            }
            return true;
        }

        private bool checkNumberNegative(TextBox txb, string message)
        {
            bool isValid = int.TryParse(txb.Text, out int result);
            if (!isValid || result < 0)
            {
                MessageBox.Show(message);
                return false;
            }
            return true;
        }

        private bool checkInput()
        {
            if (!checkEmpty(txbId, "textbox id cant empty")) return false;
            if (!checkEmpty(txbName, "textbox name cant empty")) return false;
            if (!checkEmpty(txbOption, "textbox option cant empty")) return false;
            if (!checkEmpty(txbPrice, "textbox price cant empty")) return false;
            if (!checkEmpty(txbCount, "textbox count cant empty")) return false;
            if (!checkEmpty(txbUnit, "textbox unit cant empty")) return false;

            if (!checkNumber(txbPrice, "textbox price must be numbers")) return false;
            if (!checkNumber(txbCount, "textbox count must be numbers")) return false;

            if (!checkNumberNegative(txbPrice, "textbox price must be positive")) return false;

            return true;
        }

        private void clear()
        {
            txbId.Text = "";
            txbName.Text = "";
            txbOption.Text = "";
            txbPrice.Text = "";
            txbCount.Text = "";
            txbUnit.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!checkInput()) return;
            List<ItemType> listCategory = CategoryDAO.Instance.getListCategory();
            int idCategory = 1;
            for( int i = 0; i < listCategory.Count; i++)
            {
                if (listCategory[i].nameType.ToString() == cbCategory.SelectedValue.ToString())
                {
                    idCategory = listCategory[i].idType;
                }
            }

            ItemSalesDAO.Instance.editItem(
                        int.Parse(txbId.Text), idCategory, txbName.Text,
                        txbOption.Text, float.Parse(txbPrice.Text),
                        int.Parse(txbCount.Text), txbUnit.Text);
            loadDgv();
            clear();
        }

        private void loadCategoryFind()
        {
            List<ItemType> listCategory = CategoryDAO.Instance.getListCategory();
            ItemType item = new ItemType()
            {
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            int idCategory = int.Parse(cbCategoryFind.SelectedValue.ToString());
            string option = txbOptionFind.Text;
            string name = txbNameFind.Text;

            List<FullItemDTO> fullItems = ItemSalesDAO.Instance.getListItemFind(idCategory, name, option);

            loadDgvFind(fullItems);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            loadDgv();
            cbCategoryFind.SelectedValue = -1;
            txbNameFind.Text = "";
            txbOptionFind.Text = "";
        }
    }
}
