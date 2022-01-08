using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BillDAO
    {
        private static BillDAO instance = null;
        internal static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }
        }

        public List<Bill> FindBillNoTime(string id, string acount, string status)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                if(status.Equals("Tất cả") && acount.Equals("Tất cả"))
                    return kms.Bills.Where(p => p.id.ToString().Contains(id)).ToList();
                else if(status.Equals("Tất cả"))
                    return kms.Bills.Where(p => p.id.ToString().Contains(id)
                                           && p.creator.Contains(acount)).ToList();
                else if(acount.Equals("Tất cả"))
                    return kms.Bills.Where(p => p.id.ToString().Contains(id)
                                           && p.status.Equals(status)).ToList();
                else
                    return kms.Bills.Where(p => p.id.ToString().Contains(id)
                                            && p.status.Equals(status)
                                            && p.creator.Contains(acount)).ToList();
            }
        }

        public List<Bill> FindBillByDate(string id, string acount, string status, DateTime date)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                 

                if (status.Equals("Tất cả") && acount.Equals("Tất cả"))
                    return kms.Bills.Where(p => p.id.ToString().Contains(id)
                                           && p.createdDay.Value.Day == date.Day 
                                           && p.createdDay.Value.Month == date.Month 
                                           && p.createdDay.Value.Year == date.Year).ToList();
                else if (status.Equals("Tất cả"))
                    return kms.Bills.Where(p => p.id.ToString().Contains(id)
                                            && p.creator.Contains(acount)
                                            && p.createdDay.Value.Day == date.Day
                                           && p.createdDay.Value.Month == date.Month
                                           && p.createdDay.Value.Year == date.Year).ToList();
                else if (acount.Equals("Tất cả"))
                    return kms.Bills.Where(p => p.id.ToString().Contains(id)
                                            && p.status.Equals(status)
                                            && p.createdDay.Value.Day == date.Day 
                                           && p.createdDay.Value.Month == date.Month 
                                           && p.createdDay.Value.Year == date.Year).ToList();
                else
                    return kms.Bills.Where(p => p.id.ToString().Contains(id)
                                            && p.status.Equals(status)
                                            && p.creator.Contains(acount)
                                            && p.createdDay.Value.Day == date.Day 
                                           && p.createdDay.Value.Month == date.Month 
                                           && p.createdDay.Value.Year == date.Year).ToList();
            }
        }

        public List<Bill> FindBillByMonthYear(string id,string acount,string status
                                            ,int monthFrom, int monthTo,int yearFrom, int yearTo)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                if( status.Equals("Tất cả") && acount.Equals("Tất cả"))
                    return kms.Bills.Where(p => p.id.ToString().Contains(id)                                           
                                            && p.createdDay.Value.Month >= monthFrom
                                            && p.createdDay.Value.Month <= monthTo
                                            && p.createdDay.Value.Year >= yearFrom
                                            && p.createdDay.Value.Year <= yearTo).ToList();
                else if(status.Equals("Tất cả"))
                    return kms.Bills.Where(p => p.id.ToString().Contains(id)                                            
                                            && p.creator.Contains(acount)
                                            && p.createdDay.Value.Month >= monthFrom
                                            && p.createdDay.Value.Month <= monthTo
                                            && p.createdDay.Value.Year >= yearFrom
                                            && p.createdDay.Value.Year <= yearTo).ToList();
                else if(acount.Equals("Tất cả"))
                    return kms.Bills.Where(p => p.id.ToString().Contains(id)
                                            && p.status.Equals(status)
                                            && p.createdDay.Value.Month >= monthFrom
                                            && p.createdDay.Value.Month <= monthTo
                                            && p.createdDay.Value.Year >= yearFrom
                                            && p.createdDay.Value.Year <= yearTo).ToList();
                else
                    return kms.Bills.Where(p => p.id.ToString().Contains(id)
                                            && p.status.Equals(status)
                                            && p.creator.Contains(acount)
                                            && p.createdDay.Value.Month >= monthFrom
                                            && p.createdDay.Value.Month <= monthTo
                                            && p.createdDay.Value.Year >= yearFrom
                                            && p.createdDay.Value.Year <= yearTo).ToList();

            }

        }

        public List<Bill> GetAllBillList()
        {
            using( KMSEntities kms = new KMSEntities())
            {
                return kms.Bills.ToList();
            }
        }

        public void ChangeBillRecordByList( List<Bill> list)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                foreach( Bill item in list)
                {
                    Bill bill = kms.Bills.Where(p => p.id == item.id).First();
                    bill.status = item.status;

                    if (bill.status.Equals("Đã xóa"))
                    {
                        BillDetailDAO.Instance.ChangeBillDetailStatusToDeledtedByBill(bill);
                    }
                }
                kms.SaveChanges();
            }
        }
    }
}
