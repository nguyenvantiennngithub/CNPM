using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    class CostDAO
    {
        private static CostDAO instance = null;
        internal static CostDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CostDAO();
                return instance;
            }
        }
        public float getTotal()
        {

            using (KMSEntities kms = new KMSEntities())
            {
                return float.Parse(kms.Costs.Sum(p => p.total).ToString());
            }
        }
        public float getTotalFund()
        {
            using (KMSEntities kms = new KMSEntities())
            {
                float a = float.Parse(kms.Costs
                           .Sum(p => p.totalFundCost).ToString());
                return a;
 
            }
        }
        public float getTotalIncome()
        {
            using (KMSEntities kms = new KMSEntities())
            {

                return float.Parse(kms.Costs.Sum(p => p.totalIncome).ToString());
            }
        }
        public float getTotalFee()
        {
            using (KMSEntities kms = new KMSEntities())
            {
                float a = float.Parse(kms.Costs.Sum(p => (p.premiseCost 
                                         + p.electricityCost + p.waterCost + p.totalTaxCost) +
                                         (p.premiseCost + p.totalTaxCost
                                         + p.electricityCost + p.waterCost) * p.bankInterestExpensePercent / 100
                                      ).ToString());
                return a;
            }
        }
        public float GetTotaltax()
        {
            using(KMSEntities kms = new KMSEntities())
            {
                return float.Parse(kms.Costs.Sum(p => p.totalTaxCost).ToString());
                
            }
        }
        public int GetFirstYear()
        {

            using (KMSEntities kms = new KMSEntities())
            {
                int a = kms.Costs.Select(p => p.year).FirstOrDefault();
                return a;
            }


        }
        public int GetLastYear()
        {

            using (KMSEntities kms = new KMSEntities())
            {
                int a = kms.Costs.OrderByDescending(p => p.year).Select(p => p.year).FirstOrDefault();
                return a;
            }
        }

        public float GetTotalByMonth(int month, int year)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return float.Parse(kms.Costs.Where(p => p.month == month && p.year == year)
                                            .Select(p => p.total).FirstOrDefault().ToString());
            }
        }

        public float GetTotalFundByMonth(int month, int year)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return  float.Parse(kms.Costs.Where(p => p.month == month && p.year == year)
                                            .Select(p => p.totalFundCost).FirstOrDefault().ToString());
            }
        }

        public float GetTotalFeeByMonth( int month, int year)
        {
            using(KMSEntities kms = new KMSEntities())
            {

                return float.Parse(kms.Costs.Where( p => p.month == month && p.year == year)
                                        .Select(p => (p.premiseCost 
                                         + p.electricityCost + p.waterCost + p.totalTaxCost) +
                                         (p.premiseCost + p.totalTaxCost
                                         + p.electricityCost + p.waterCost) * p.bankInterestExpensePercent / 100
                                      ).FirstOrDefault().ToString());
            }
        }
        
        public float GetTotalIncomeByMonth(int month, int year)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return float.Parse(kms.Costs.Where(p => p.month == month && p.year == year)
                                            .Select(p => p.totalIncome).FirstOrDefault().ToString());
            }
        }

        public float GetTotalByYear( int year)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return float.Parse(kms.Costs.Where(p => p.year == year)
                                            .Sum(p => p.total).ToString());
            }
        }

        public float GetTotalFundByYear( int year)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                float totalFund = float.Parse(kms.Costs.Where(p =>  p.year == year)
                                            .Sum(p => p.totalFundCost)
                                            .ToString());
                return totalFund;
            }
        }

        public float GetTotalTaxByYear( int year)
        {
            using(KMSEntities kms = new KMSEntities())
            {
                return float.Parse(kms.Costs.Where(p => p.year == year)
                                            .Sum(p => p.totalTaxCost).ToString());
            }
        }

        public float GetTotalFeeByYear( int year)
        {
            using (KMSEntities kms = new KMSEntities())
            {

                return float.Parse(kms.Costs.Where(p => p.year == year)
                                        .Sum(p => (p.premiseCost 
                                         + p.electricityCost + p.waterCost + p.totalTaxCost) +
                                         (p.premiseCost  + p.totalTaxCost
                                         + p.electricityCost + p.waterCost) * p.bankInterestExpensePercent / 100
                                      ).ToString());
            }
        }

        public float GetTotalIncomeByYear( int year)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return float.Parse(kms.Costs.Where(p =>  p.year == year)
                                            .Sum(p => p.totalIncome).ToString());
            }
        }

        public bool CheckRecordByMonth(int month, int year)
        {
            using(KMSEntities kms = new KMSEntities())
            {
                var a = kms.Costs.Where(p => p.month == month && p.year == year).Count();
                return a > 0;
            }
        }

        public bool CheckRecordByYear( int year)
        {
            using(KMSEntities kms = new KMSEntities())
            {
                var a = kms.Costs.Where(p => p.year == year).Count();
                return a > 0;
            }
        }

        public Cost GetRecordCostByMonth(int a, int b)
        {
            using( KMSEntities kms = new KMSEntities())
            {
                return kms.Costs.Where(p => p.month == a && p.year == b).First();
            }
        }

        public List<Cost> GetListCostByYear( int b)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return kms.Costs.Where(p => p.year == b).ToList();
            }
        }

        public List<Cost> GetListCostFromYearToYear( int a, int b)
        {
            using( KMSEntities kms = new KMSEntities())
            {
                return kms.Costs.Where(p => p.year >= a && p.year <= b).ToList();
            }
        }

        public void UpdateCostByMonth( int month, int year, float electric, float water, float premise, float bankIntered)
        {
            using( KMSEntities kms = new KMSEntities())
            {
                Cost cost = kms.Costs.Where(p => p.month == month && p.year == year).First();
                cost.electricityCost = (decimal)electric;
                cost.waterCost = (decimal)water;
                cost.premiseCost = (decimal)premise;
                cost.bankInterestExpensePercent = (decimal)bankIntered;

                kms.SaveChanges();
            }
        }
    }

}
