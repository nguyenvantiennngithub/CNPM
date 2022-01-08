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
                };
                kms.Bills.Add(bill);
                
                for (int i = 0; i < rows.Count; i++)
                {
                    int IdItem = int.Parse(rows[i].Cells["idItem"].Value.ToString());
                    Item itemFind = kms.Items.Where(item => item.id == IdItem).FirstOrDefault();
                    int amount = int.Parse(rows[i].Cells["count"].Value.ToString());
                    decimal singlePrice = decimal.Parse(rows[i].Cells["singlePrice"].Value.ToString());
                    BillDetail billDetail = new BillDetail()
                    {
                        idBill = bill.id,
                        idItem = IdItem,
                        classify = rows[i].Cells["option"].Value.ToString(),
                        amount = amount,
                        status = Constant.Instance.billStatusSold,
                        singlePrice = singlePrice,
                        amountCount = itemFind.amountCount,
                    };
                    kms.BillDetails.Add(billDetail);
                }

                kms.SaveChanges();
                return bill.id;
            }
        }

        public int import(DataGridViewRowCollection rows)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                BillBuy bill = new BillBuy()
                {
                    creator = "minhtoan",
                    createdDay = DateTime.Now,
                    status = Constant.Instance.billBuyStatusSold,
                };
                kms.BillBuys.Add(bill);
                kms.SaveChanges();

                for (int i = 0; i < rows.Count; i++)
                {
                    int idItem = int.Parse(rows[i].Cells["idItem"].Value.ToString());
                    int count = int.Parse(rows[i].Cells["count"].Value.ToString());
                    int miss = int.Parse(rows[i].Cells["miss"].Value.ToString());
                    Item itemFind = kms.Items.Where(item => item.id == idItem).FirstOrDefault();

                    BillBuyDetail billDetail = new BillBuyDetail()
                    {
                        idBillBuy = bill.id,
                        idItem = idItem,
                        classify = rows[i].Cells["option"].Value.ToString(),
                        amount = count,
                        remainAmount = count - miss,
                        amountCount = itemFind.amountCount,
                        status = (miss == 0) ? Constant.Instance.billBuyDetailStatusSold : Constant.Instance.billBuyDetailStatusMiss,
                        note = rows[i].Cells["note"].Value.ToString(),
                        singlePrice = decimal.Parse(rows[i].Cells["singlePrice"].Value.ToString()),
                    };

                    kms.BillBuyDetails.Add(billDetail);
                }

                kms.SaveChanges();
                return bill.id;
            }
        }

        public void addItem(int idCategory, string name, string unit,
            FlowLayoutPanel pnlOption, FlowLayoutPanel pnlPrice,
            FlowLayoutPanel pnlCount)
        {
            TextBox txbOption;
            TextBox txbPrice;
            TextBox txbCount;
            using (KMSEntities kms = new KMSEntities())
            {
                Item item = new Item()
                {
                    name = name,
                    idType = idCategory,
                    status = Constant.Instance.itemStatusActive,
                    amountCount = unit,
                };
                kms.Items.Add(item);

                for (int i = 0; i < pnlOption.Controls.Count; i++)
                {
                    txbOption = pnlOption.Controls[i] as TextBox;
                    txbPrice = pnlPrice.Controls[i] as TextBox;
                    txbCount = pnlCount.Controls[i] as TextBox;

                    ItemClassify itemClassify = new ItemClassify()
                    {
                        idItem = item.id,
                        amount = int.Parse(txbCount.Text.ToString()),
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

        public void addOption(string name,
            FlowLayoutPanel pnlOption, FlowLayoutPanel pnlPrice,
            FlowLayoutPanel pnlCount)
        {
            TextBox txbOption;
            TextBox txbPrice;
            TextBox txbCount;
            using (KMSEntities kms = new KMSEntities())
            {
                Item itemGet = kms.Items.Where(item => item.name == name).FirstOrDefault();

                for (int i = 0; i < pnlOption.Controls.Count; i++)
                {
                    txbOption = pnlOption.Controls[i] as TextBox;
                    txbPrice = pnlPrice.Controls[i] as TextBox;
                    txbCount = pnlCount.Controls[i] as TextBox;

                    ItemClassify itemClassify = new ItemClassify()
                    {
                        idItem = itemGet.id,
                        amount = int.Parse(txbCount.Text.ToString()),
                        classify = txbOption.Text,
                        status = Constant.Instance.itemOptionStatusActive,
                    };
                    kms.ItemClassifies.Add(itemClassify);

                    ItemPrice itemPrice = new ItemPrice()
                    {
                        id = itemGet.id,
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
                        unit = item.amountCount,
                    }).Join(kms.ItemClassifies,
                        item => item.id,
                        option => option.idItem,
                        (item, option) => new
                        {
                            id = item.id,
                            item = item.item,
                            category = item.category,
                            option = option.classify,
                            count = option.amount,
                            unit = item.unit,
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
                                IdCategory = item.idCategory,
                                Unit = item.unit,
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
                itemEdit.amountCount = unit;

                itemClassifyEdit.amount = count;

                itemPriceEdit.price = (decimal)price;

                kms.SaveChanges();
            }
        }



        public List<string> getListOptionByIdBill(int idItem)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return kms.ItemClassifies.Where(item => item.idItem == idItem).Select(item => item.classify).ToList();
            }
        }

        public int getIdItemByName(string name)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return kms.Items.Where(item => item.name == name).Select(item => item.id).FirstOrDefault();
            }
        }

        public int getIdCategoryByName(string name)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return kms.Items.Where(item => item.name == name).Select(item => item.idType).FirstOrDefault();
            }
        }


        public List<FullItemDTO> getListItemFind(int idCategory, string nameFind, string optionFind)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return kms.Items.Where(item => item.name.Contains(nameFind))
                    .Join(
                    kms.ItemTypes,
                    item => item.idType,
                    type => type.idType,
                    (item, type) => new
                    {
                        id = item.id,
                        category = type.nameType,
                        item = item.name,
                        idCategory = type.idType,
                        unit = item.amountCount,
                    }).Where(item => item.idCategory== idCategory || idCategory==-1)
                    .Join(kms.ItemClassifies,
                        item => item.id,
                        option => option.idItem,
                        (item, option) => new
                        {
                            id = item.id,
                            item = item.item,
                            category = item.category,
                            option = option.classify,
                            count = option.amount,
                            idCategory = item.idCategory,
                            unit = item.unit,


                        }).Where(item => item.option.Contains(optionFind))
                        .Join(kms.ItemPrices,
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
                                IdCategory = item.idCategory,
                                Unit = item.unit,
                            }
                        ).ToList();
            }
        }

        
        public Acount getAccountByUsername(string username)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return kms.Acounts.Where(acc => acc.username == username).FirstOrDefault();
            }

        }

        public void changePassword(string username, string password)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                Acount acount = kms.Acounts.Where(acc => acc.username == username).FirstOrDefault();
                if (acount != null)
                {
                    acount.password = password;
                    kms.SaveChanges();
                }
            }
        }
        public List<BillBuyDTO> getListBillBuy()
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return kms.BillBuys.Join(
                    kms.BillBuyDetails,
                    b => b.id,
                    bd => bd.idBillBuy,
                    (b, bd) => new
                    {
                        id = b.id,
                        singlePrice = bd.singlePrice,
                        count = bd.amount,
                        status = b.status,
                        creator = b.creator,
                        createdAt = b.createdDay,
                    }
                ).GroupBy(b => new { b.id, b.status, b.creator, b.createdAt })
                .Select(b => new BillBuyDTO()
                {
                    Id = b.Key.id,
                    Status = b.Key.status,
                    Creator = b.Key.creator,
                    CreatedAt = (DateTime)b.Key.createdAt,
                    TotalBill = (float)(b.Sum(bb => bb.singlePrice * bb.count)),
                }).ToList();
            }
        }


        public List<BillBuyDetailDTO> GetBillBuyDetails(int id)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return kms.BillBuyDetails.Where(bd => bd.idBillBuy == id)
                    .Join(
                        kms.Items,
                        bd => bd.idItem,
                        i => i.id,
                        (bd, i) => new BillBuyDetailDTO()
                        {
                            IdItem = i.id,
                            Item = i.name,
                            Option = bd.classify,
                            Count = bd.amount,
                            SinglePrice = (float)bd.singlePrice,
                            Status = bd.status,
                            Miss = bd.remainAmount,
                            Unit = bd.amountCount,
                            Note = bd.note
                        }
                    ).ToList();
            }
        }

        public void editBillBuyDetail(int idBill, string option, int idItem, int count, float singlePrice, int miss, string note)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                BillBuyDetail bill = kms.BillBuyDetails.Where(bd => bd.idBillBuy == idBill && bd.classify==option && bd.idItem==idItem).FirstOrDefault();
                bill.amount = count;
                bill.singlePrice = (decimal)singlePrice;
                bill.remainAmount = miss;
                bill.note = note;
                kms.SaveChanges();
            }
        }
    }
}
