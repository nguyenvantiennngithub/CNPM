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
            listStatus.Add("Đã hủy");
            listStatus.Add("Đã thanh toán");
            listStatus.Add("Chưa thanh toán");

            cbStatus.DataSource = listStatus;
            cbStatusFind.DataSource = listStatus;

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
                ListViewItem item = new ListViewItem();

                item.SubItems.Add(list[i].id.ToString());
                item.SubItems.Add(list[i].createdDay.ToString());
                item.SubItems.Add(list[i].creator);
                item.SubItems.Add(list[i].status);

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
            txbIDFind.Text = "";
            cbAcountFind.Text = "Tất cả";
            cbStatus.Text = "Tất cả";
        }

        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBill.SelectedItems.Count > 0)
            {
                txbID.Text = lvBill.SelectedItems[0].SubItems[0].Text;
                txbDate.Text = lvBill.SelectedItems[0].SubItems[1].Text;
                txbAcount.Text = lvBill.SelectedItems[0].SubItems[2].Text;
                cbStatus.Text = lvBill.SelectedItems[0].SubItems[3].Text;
                txbSumPrice.Text = lvBill.SelectedItems[0].SubItems[4].Text;
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txbID.Text != null)
            {
                for( int i = 0; i < listBill.Count(); i++)
                {
                    if( listBill[i].id == int.Parse(txbID.Text))
                    {
                        listBill[i].status = cbStatus.Text;
                        break;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if( txbID.Text != null)
            {
                for( int i = 0; i < listBill.Count(); i++)
                {
                    if( listBill[i].id == int.Parse(txbID.Text))
                    {
                        listBill.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BillDAO.Instance.SetBillRecordByList(listBill);
        }

        private void txbIDFind_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[^\d]+");
            if (regex.IsMatch(txbIDFind.Text))
            {
                txbIDFind.Text.Remove(txbIDFind.Text.Length - 1, txbIDFind.Text.Length - 1);
                txbIDFind.SelectionStart = txbIDFind.Text.Length;
            }
        }
    }
}
