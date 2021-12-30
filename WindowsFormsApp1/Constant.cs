using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Constant
    {
        private static Constant instance = null;
        internal static Constant Instance
        {
            get
            {
                if (instance == null)
                    instance = new Constant();
                return instance;
            }
        }
        public string billStatusSold = "Đã thanh toán";
        public string billDetailStatusSold = "Đã bán";
        public string itemStatusActive = "Hoạt động";
        public string itemOptionStatusActive = "Hoạt động";
        public string itemPriceStatusActive = "Hàng bán";
    }
}
