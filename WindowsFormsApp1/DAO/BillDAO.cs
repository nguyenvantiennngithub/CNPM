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
                return kms.Bills.Where(p => p.id.ToString().Contains(id)
                                            && p.status.Equals(status)
                                            && p.creator.Contains(acount)).ToList();
            }
        }

        public List<Bill> FindBillByDate(string id, string acount, string status, DateTime date)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return kms.Bills.Where(p => p.id.ToString().Contains(id.ToString())
                                            && p.status.Equals(status)
                                            && p.creator.Contains(acount)
                                            && p.createdDay.Equals(date)).ToList();
            }
        }

        public List<Bill> FindBillByMonthYear(string id,string acount,string status
                                            ,int monthFrom, int monthTo,int yearFrom, int yearTo)
        {
            using (KMSEntities kms = new KMSEntities())
            {
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

        public void SetBillRecordByList( List<Bill> list)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                kms.Bills.RemoveRange(kms.Bills);
                kms.Bills.AddRange(list);
                kms.SaveChanges();
            }
        }
    }
}
