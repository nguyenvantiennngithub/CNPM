﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace WindowsFormsApp1
{
    class BillDetailDAO
    {
        private static BillDetailDAO instance = null;
        internal static BillDetailDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDetailDAO();
                return instance;
            }
        }

        public List<BillDetail> GetListBillDetailByID( int ID)
        {
            using( KMSEntities kms = new KMSEntities())
            {
                return kms.BillDetails.Where(p => p.idBill == ID).ToList();
            }
        }

        public void ChangeBillDetailStatusToDeleted( List<BillDetail> list)
        {
            using( KMSEntities kms = new KMSEntities())
            {
                Bill bill = kms.Bills.Where(p => p.id == list[0].idBill).First();
                int month = bill.createdDay.Value.Month;
                int year = bill.createdDay.Value.Year;
                foreach (BillDetail item in list)
                {
                    BillDetail billdetail = kms.BillDetails.Where(p => p.idBill == item.idBill
                                               && p.idItem == item.idItem
                                               && p.classify.Equals(item.classify)).First();
                    billdetail.status = "Đã xóa";

                    Cost cost = kms.Costs.Where(p => p.month==month && p.year==year).FirstOrDefault();
                    cost.total = cost.total - billdetail.singlePrice * billdetail.amount;
                }
                kms.SaveChanges();
            }
        }

        public void ChangeBillDetailStatusToDeledtedByBill(Bill bill)
        {
            using( KMSEntities kms = new KMSEntities())
            {
                List<BillDetail> list = kms.BillDetails.Where(p => p.idBill == bill.id).ToList();
                int month = bill.createdDay.Value.Month;
                int year = bill.createdDay.Value.Year;
                foreach (BillDetail item in list)
                {
                    
                    item.status = "Đã xóa";

                    Cost cost = kms.Costs.Where(p => p.month == month && p.year==year).FirstOrDefault();
                    cost.total = cost.total - item.singlePrice * item.amount;
                }
                kms.SaveChanges();
            }
        }

        public float GetTotalPriceByID( int id)
        {
            using(KMSEntities kms = new KMSEntities())
            {
                List<BillDetail> list = kms.BillDetails.Where(p => p.idBill == id
                                                               && p.status != "Đã xóa").ToList();
                float totalPrice = 0;
                foreach (BillDetail item in list)
                {
                    totalPrice = totalPrice + (float)item.singlePrice * item.amount;
                }
                return totalPrice;
            }
        }

        public List<int> GetAmountSaleByYearOfItem(int year, int idItem)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                List<int> list = new List<int>();

                for (int i = 0; i < 12; i++)
                {
                    list.Add(0);
                }
                List<Bill> listBill = kms.Bills.Where(p => p.createdDay.Value.Year == year)
                                               .ToList();

                List<BillDetail> listBillDetail = new List<BillDetail>();

                foreach (Bill item in listBill)
                {
                    int amount = kms.BillDetails.Where(p => p.idBill == item.id
                                                                  && p.idItem.Equals(idItem)
                                                                  && p.status != "Đã xóa")
                                                            .Sum(p => p.amount);
                    list[item.createdDay.Value.Month - 1] = list[item.createdDay.Value.Month - 1] + amount;


                }
                return list;
            }
        }

            public List<int> GetAmountSaleFromYearToYearOfItem( int fromYear, int toYear, int idItem)
            {
                using (KMSEntities kms = new KMSEntities())
                {
                    List<int> list = new List<int>();

                    for (int i = fromYear; i <= toYear; i++)
                    {
                        list.Add(0);
                    }
                    List<Bill> listBill = kms.Bills.Where(p => p.createdDay.Value.Year >= fromYear
                                                            && p.createdDay.Value.Year >= toYear)
                                                   .ToList();

                    foreach (Bill item in listBill)
                    {
                        int amount = kms.BillDetails.Where(p => p.idBill == item.id
                                                                      && p.idItem.Equals(idItem)
                                                                      && p.status != "Đã xóa")
                                                                .Sum(p => p.amount);
                        list[item.createdDay.Value.Year-fromYear] = list[item.createdDay.Value.Year-fromYear] + amount;


                    }
                    return list;
                }
            }
    }   
}
