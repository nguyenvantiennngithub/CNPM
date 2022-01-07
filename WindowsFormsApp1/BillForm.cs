using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class BillForm : Form
    {
        List<Bill> listBill = new List<Bill>();
        List<Bill> listChange = new List<Bill>();
        List<Bill> listSelected = new List<Bill>();
        public BillForm()
        {
            InitializeComponent();

            LoadDataToControl();
            SetDefaultValueOfControl();
        }

        public void LoadDataToControl()
        {
            List<string> listStatus = new List<string>();
            listStatus.Add("Tất cả");
            listStatus.Add("Đã xóa");
            listStatus.Add("Đã thanh toán");
            listStatus.Add("Chưa thanh toán");

            cbStatusFind.DataSource = listStatus;

            List<string> listStatus2 = new List<string>();
            listStatus2.Add("Đã xóa");
            listStatus2.Add("Đã thanh toán");
            listStatus2.Add("Chưa thanh toán");

            cbStatus.DataSource = listStatus2;

            List<string> listAcount = new List<string>();
            listAcount.Add("Tất cả");
            listAcount.AddRange(AcountDAO.Instance.GetAllAcountUserNameList());
            cbAcountFind.DataSource = listAcount;

            List<string> listYear = new List<string>();
            for( int i = CostDAO.Instance.GetFirstYear(); i<= CostDAO.Instance.GetLastYear(); i++)
            {
                listYear.Add(i.ToString());
            }
            cbFindFromYear.DataSource = listYear;
            cbFindToYear.DataSource = listYear;
        }

        public void SetDefaultValueOfControl()
        {
            numericFindFromMonth.Value = DateTime.Now.Month;
            numericFindToMonth.Value = DateTime.Now.Month;

            cbFindFromYear.Text = DateTime.Now.Year.ToString();
            cbFindToYear.Text = DateTime.Now.Year.ToString();

            dtpDateFind.Value = DateTime.Now;

            radiobtnNoTime.Checked = true;
        }

        public void LoadDataToListView(List<Bill> list)
        {
            lvBill.Items.Clear();
            for( int i = 0; i < list.Count(); i++)
            {
                ListViewItem item = new ListViewItem((i+1).ToString());

                item.SubItems.Add(list[i].id.ToString());
                item.SubItems.Add(list[i].createdDay.ToString());
                item.SubItems.Add(list[i].creator);
                item.SubItems.Add(list[i].status);
                item.SubItems.Add(BillDetailDAO.Instance.GetTotalPriceByID(list[i].id).ToString());

                lvBill.Items.Add(item);
            }
        }

        private void radiobtnDate_CheckedChanged(object sender, EventArgs e)
        {
            pnDateFind.Enabled = true;
            pnMonthFind.Enabled = false;
            pnYearFind.Enabled = false;



        }

        private void radiobtnMonthYear_CheckedChanged(object sender, EventArgs e)
        {
            pnDateFind.Enabled = false;
            pnMonthFind.Enabled = true;
            pnYearFind.Enabled = true;
        }

        private void radiobtnNoTime_CheckedChanged(object sender, EventArgs e)
        {
            pnDateFind.Enabled = false;
            pnMonthFind.Enabled = false;
            pnYearFind.Enabled = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (radiobtnDate.Checked)
            {
                listBill = BillDAO.Instance.FindBillByDate( txbIDFind.Text, cbAcountFind.Text
                                                            , cbStatusFind.Text, dtpDateFind.Value);
                LoadDataToListView(listBill);
            }
            else if (radiobtnMonthYear.Checked)
            {
                listBill = BillDAO.Instance.FindBillByMonthYear(txbIDFind.Text, cbAcountFind.Text
                                                                , cbStatusFind.Text
                                                                , (int)numericFindFromMonth.Value
                                                                , (int)numericFindToMonth.Value
                                                                , int.Parse(cbFindFromYear.Text)
                                                                , int.Parse(cbFindToYear.Text));
                LoadDataToListView(listBill);
            }
            else
            {
                listBill = BillDAO.Instance.FindBillNoTime(txbIDFind.Text, cbAcountFind.Text
                                                            , cbStatusFind.Text);
                LoadDataToListView(listBill);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listBill = BillDAO.Instance.GetAllBillList();
            LoadDataToListView(listBill);
            SetDefaultValueOfControl();
            listSelected.Clear();
            listChange.Clear();
            txbIDFind.Text = "";
            cbAcountFind.Text = "Tất cả";
            cbStatusFind.Text = "Tất cả";
            txbID.Text = "";
            txbAcount.Text = "";
            txbDate.Text = "";
            cbStatus.Text = "";
            txbSumPrice.Text = ""; 
        }

        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBill.SelectedItems.Count == 1)
            {
                txbID.Text = lvBill.SelectedItems[0].SubItems[1].Text;
                txbDate.Text = lvBill.SelectedItems[0].SubItems[2].Text;
                txbAcount.Text = lvBill.SelectedItems[0].SubItems[3].Text;
                cbStatus.Text = lvBill.SelectedItems[0].SubItems[4].Text;
                txbSumPrice.Text = lvBill.SelectedItems[0].SubItems[5].Text;
                

                listSelected.Add(listBill[int.Parse(lvBill.SelectedItems[0].SubItems[0].Text) - 1]);
            }
            else if (lvBill.SelectedItems.Count > 1)
            {
                txbID.Text = "";
                txbDate.Text = "";
                txbAcount.Text = "";
                txbSumPrice.Text = "";

                listSelected.Clear();
                for (int i = 0; i < lvBill.SelectedItems.Count; i++)
                {
                    listSelected.Add(listBill[int.Parse(lvBill.SelectedItems[i].SubItems[0].Text)-1]);
                }
            }
            else
            {
                listSelected.Clear();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (listSelected.Count > 0)
            {
                for (int i = 0; i < listSelected.Count; i++)
                {
                    if (listChange.Contains(listSelected[i]))
                        listChange.Remove(listSelected[i]);

                    Bill a = listBill.Find(x => x.id == listSelected[i].id);

                    if (a.status.Equals(cbStatus.Text))
                        listSelected.RemoveAt(i);
                    else
                    {
                        a.status = cbStatus.Text;
                        listSelected[i].status = cbStatus.Text;
                        listChange.Add(listSelected[i]);
                    }
                }
                listSelected.Clear();
                LoadDataToListView(listBill);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listSelected.Count > 0)
            {
                for (int i = 0; i < listSelected.Count; i++)
                {
                    if (listChange.Contains(listSelected[i]))
                        listChange.Remove(listSelected[i]);

                    listBill.Remove(listSelected[i]);
                    listSelected[i].status = "Đã xóa";
                    listChange.Add(listSelected[i]);
                }
                listSelected.Clear();
                LoadDataToListView(listBill);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listChange.Count > 0)
            {
                BillDAO.Instance.ChangeBillRecordByList(listChange);
                listChange.Clear();
                listSelected.Clear();
            }
        }

        private void txbIDFind_TextChanged(object sender, EventArgs e)
        {
            if (txbIDFind.Text.Length > 0)
            {
                txbIDFind.Text = Regex.Replace(txbIDFind.Text, @"[^\d]", String.Empty);
                txbIDFind.SelectionStart = txbIDFind.Text.Length;
            }
        }

        private void btnBillDetail_Click(object sender, EventArgs e)
        {
            BillDetailForm form = new BillDetailForm(int.Parse(txbID.Text));
            form.ShowDialog();
        }
    }
}
