using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ItemSalesDAO
    {
        //List<ItemSalesDTO>
        private static ItemSalesDAO instance = null;
        internal static ItemSalesDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ItemSalesDAO();
                return instance;
            }
        }
        public List<CategoryGroupBy> GetCategoryGroupBy()
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return kms.Items.Join(
                    kms.ItemTypes,
                    item => item.idType,
                    type => type.idType,
                    (item, type) => new
                    {
                        id = item.id,
                        category = type.nameType,
                        item = item.name,
                    }).Join(kms.ItemClassifies,
                        item => item.id,
                        option => option.idItem,
                        (item, option) => new
                        {
                            id = item.id,
                            item = item.item,
                            category = item.category,
                            option = option.classify,
                        }).Join(kms.ItemPrices,
                            item => new { id = item.id, option = item.option },
                            price => new { id = price.id, option = price.classify },
                            (item, price) => new OptionCategory
                            {
                                Id = item.id,
                                Item = item.item,
                                Category = item.category,
                                Option = item.option,
                                Price = (float)price.price,
                            }
                        ).GroupBy(item => new { item.Category, item.Id, item.Item })
                            .Select(item => new ItemGroupBy
                            {
                                Item = item.Key.Item,
                                Id = item.Key.Id,
                                Category = item.Key.Category,
                                Option = item.ToList(),
                            }).GroupBy(item => item.Category)
                            .Select(item => new CategoryGroupBy
                            {
                                Category = item.Key,
                                ListItem = item.ToList(),
                            }).ToList();
            }
        }
        public int Payment(DataGridViewRowCollection rows)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                Bill bill = new Bill() {
                    creator = "minhtoan",
                    createdDay = DateTime.Now,
                    status = Constant.Instance.billStatusSold,
                    totalPrice = 0,
                };
                kms.Bills.Add(bill);
                kms.SaveChanges();

                for (int i = 0; i < rows.Count; i++)
                {
                    BillDetail billDetail = new BillDetail()
                    {
                        idBill = bill.id,
                        idItem = int.Parse(rows[i].Cells["idItem"].Value.ToString()),
                        classify = rows[i].Cells["option"].Value.ToString(),
                        amount = int.Parse(rows[i].Cells["count"].Value.ToString()),
                        status = Constant.Instance.billStatusSold,
                        singlePrice = decimal.Parse(rows[i].Cells["singlePrice"].Value.ToString()),
                        amountCount = "Cái",
                    };
                    kms.BillDetails.Add(billDetail);
                }

                kms.SaveChanges();
                return bill.id;
            }
        }

        public void addItem(int idCategory, string name, 
            FlowLayoutPanel pnlOption, FlowLayoutPanel pnlPrice, 
            FlowLayoutPanel pnlUnit, FlowLayoutPanel pnlCount)
        {
            TextBox txbOption;
            TextBox txbPrice;
            TextBox txbUnit;
            TextBox txbCount;
            using (KMSEntities kms = new KMSEntities())
            {
                Item item = new Item()
                {
                    name = name,
                    idType = idCategory,
                    status = Constant.Instance.itemStatusActive,
                };
                kms.Items.Add(item);

                for (int i = 0; i < pnlOption.Controls.Count; i++)
                {
                    txbOption = pnlOption.Controls[i] as TextBox;
                    txbPrice = pnlPrice.Controls[i] as TextBox;
                    txbUnit = pnlUnit.Controls[i] as TextBox;
                    txbCount = pnlCount.Controls[i] as TextBox;

                    ItemClassify itemClassify = new ItemClassify()
                    {
                        idItem = item.id,
                        amount = int.Parse(txbCount.Text.ToString()),
                        amountCount = txbUnit.Text,
                        classify = txbOption.Text,
                        status = Constant.Instance.itemOptionStatusActive,
                    };
                    kms.ItemClassifies.Add(itemClassify);

                    ItemPrice itemPrice = new ItemPrice()
                    {
                        id = item.id,
                        classify = itemClassify.classify,
                        price = decimal.Parse(txbPrice.Text.ToString()),
                        tax = 2,
                        status = Constant.Instance.itemPriceStatusActive,
                    };
                    kms.ItemPrices.Add(itemPrice);
                }
                kms.SaveChanges();
            }
        }


        public List<string> getListNameItem()
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return kms.Items.Select(item => item.name).ToList();
            }
        }

        public List<FullItemDTO> getFullItem()
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return kms.Items.Join(
                    kms.ItemTypes,
                    item => item.idType,
                    type => type.idType,
                    (item, type) => new
                    {
                        id = item.id,
                        category = type.nameType,
                        item = item.name,
                        idCategory = type.idType,
                    }).Join(kms.ItemClassifies,
                        item => item.id,
                        option => option.idItem,
                        (item, option) => new
                        {
                            id = item.id,
                            item = item.item,
                            category = item.category,
                            option = option.classify,
                            unit = option.amountCount,
                            count = option.amount,
                            idCategory = item.idCategory,

                        }).Join(kms.ItemPrices,
                            item => new { id = item.id, option = item.option },
                            price => new { id = price.id, option = price.classify },
                            (item, price) => new FullItemDTO
                            {
                                Id = item.id,
                                Name = item.item,
                                Category = item.category,
                                Option = item.option,
                                Price = (float)price.price,
                                Count = (int)(item.count),
                                Unit = item.unit,
                                IdCategory = item.idCategory,
                            }
                        ).ToList();
            }
        }
        public void editItem(int id, int idCategory, string name, string option, float price, int count, string unit)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                Item itemEdit = kms.Items.Where(item => item.id == id).FirstOrDefault();
                ItemClassify itemClassifyEdit = kms.ItemClassifies
                    .Where(item => item.idItem == id && item.classify == option).FirstOrDefault();
                ItemPrice itemPriceEdit = kms.ItemPrices
                    .Where(item => item.id == id && item.classify == option).FirstOrDefault();

                itemEdit.name = name;
                itemEdit.idType = idCategory;

                itemClassifyEdit.amount = count;
                itemClassifyEdit.amountCount = unit;

                itemPriceEdit.price = (decimal)price;

                kms.SaveChanges();
            }
        }

    }
}
