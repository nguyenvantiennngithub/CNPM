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
    public partial class BillDetailForm : Form
    {
        List<BillDetail> list = new List<BillDetail>();
        List<BillDetail> listDelete = new List<BillDetail>();
        int id;
        public BillDetailForm( int id)
        {
            InitializeComponent();
            this.id = id;
            SetValueToControls();
        }

        public void SetValueToControls()
        {
            lbID.Text = "ID hóa đơn: " + id.ToString();

            list = BillDetailDAO.Instance.GetListBillDetailByID(id);
            LoadDataToListView(list);

            float totalPrice = 0;
            foreach (BillDetail item in list)
            {
                if( item.status != "Đã xóa")
                    totalPrice = totalPrice + (float)item.singlePrice * item.amount;
            }
            lbTotalPrice.Text = "Tổng tiền: " + totalPrice.ToString();
        }

        public void LoadDataToListView(List<BillDetail> listBillDetail)
        {
            lvBillDetail.Items.Clear();
            int i = 1;
            foreach( BillDetail listItem in listBillDetail)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(listItem.idItem.ToString());
                item.SubItems.Add("");
                item.SubItems.Add(listItem.classify);
                item.SubItems.Add(listItem.amount.ToString());
                item.SubItems.Add(listItem.amountCount);
                item.SubItems.Add(listItem.status);
                item.SubItems.Add(listItem.singlePrice.ToString());

                lvBillDetail.Items.Add(item);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SetValueToControls();
            listDelete.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvBillDetail.SelectedItems.Count > 0)
            {
                for( int i = 0; i < lvBillDetail.SelectedItems.Count; i++)
                {
                    for(int j = 0; j < list.Count; j++)
                    {
                        if( list[j].idItem==int.Parse(lvBillDetail.SelectedItems[i].SubItems[1].Text)
                            && list[j].classify==lvBillDetail.SelectedItems[i].SubItems[3].Text)
                        {
                            listDelete.Add(list[j]);
                            list.RemoveAt(j);                           
                            break;
                        }
                    
                    } 
                }
                LoadDataToListView(list);
                float totalPrice = 0;
                foreach (BillDetail item in list)
                {
                    if( item.status != "Đã xóa")
                        totalPrice = totalPrice + (float)item.singlePrice * item.amount;
                }
                lbTotalPrice.Text = "Tổng tiền: " + totalPrice.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listDelete.Count == 0)
            {
                return;
            }
             BillDetailDAO.Instance.ChangeBillDetailStatusToDeleted(listDelete);
        }
    }
}
