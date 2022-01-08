using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BillBuyDTO
    {
        private int id;
        private float totalBill;
        private string status;
        private string creator;
        private DateTime createdAt;

        public BillBuyDTO()
        {
        }

        public BillBuyDTO(int id, float totalBill, string status, string creator, DateTime createdAt)
        {
            this.Id = id;
            this.TotalBill = totalBill;
            this.Status = status;
            this.Creator = creator;
            this.CreatedAt = createdAt;
        }

        public int Id { get => id; set => id = value; }
        public float TotalBill { get => totalBill; set => totalBill = value; }
        public string Status { get => status; set => status = value; }
        public string Creator { get => creator; set => creator = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
    }
}
