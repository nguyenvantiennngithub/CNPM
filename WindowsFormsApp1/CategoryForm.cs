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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void loadListCategory()
        {
            dgvCategory.Rows.Clear();
            List<ItemType> itemTypes = CategoryDAO.Instance.getListCategory();
            for (int i = 0; i < itemTypes.Count; i++)
            {
                var index = dgvCategory.Rows.Add();
                dgvCategory.Rows[index].Cells["index"].Value = index + 1;
                dgvCategory.Rows[index].Cells["id"].Value = itemTypes[i].idType.ToString();
                dgvCategory.Rows[index].Cells["category"].Value = itemTypes[i].nameType.ToString();
            }
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            loadListCategory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbCategoryAdd.Text == "")
            {
                MessageBox.Show("Category is empty");
                return;
            }
            CategoryDAO.Instance.addCategory(txbCategoryAdd.Text);
            loadListCategory();
        }

        private int checkExistId(string id)
        {
            for (int i = 0; i < dgvCategory.Rows.Count; i++)
            {
                string idItem = dgvCategory.Rows[i].Cells["id"].Value.ToString();
                if (idItem == id) return i;
            }
            return -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = checkExistId(txbId.Text.ToString());
            if (txbCategoryEdit.Text == "")
            {
                MessageBox.Show("Category is required");
            }
            else if (index != -1)//is exist, editable
            {
                CategoryDAO.Instance.editCategory(int.Parse(txbId.Text.ToString()), txbCategoryEdit.Text);
                loadListCategory();
            }
            else
            {
                MessageBox.Show("Cant find id");
            }
        }
    }
}
