using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BillBuyDetailDTO
    {

        private int idItem;
        private string item;
        private string option;
        private int count;
        private float singlePrice;
        private string status;
        private int miss;
        private string unit;
        private string note;

        public BillBuyDetailDTO()
        {
        }

        public int IdItem { get => idItem; set => idItem = value; }
        public string Item { get => item; set => item = value; }
        public string Option { get => option; set => option = value; }
        public int Count { get => count; set => count = value; }
        public float SinglePrice { get => singlePrice; set => singlePrice = value; }
        public string Status { get => status; set => status = value; }
        public int Miss { get => miss; set => miss = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Note { get => note; set => note = value; }
    }
}
