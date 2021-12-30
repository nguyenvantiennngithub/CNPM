using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class FullItemDTO
    {
        private int id;
        private string category;
        private string name;
        private string option;
        private float price;
        private int count;
        private string unit;
        private int idCategory;

        public FullItemDTO(int id, string category, string name, string option, float price, int count, string unit)
        {
            this.id = id;
            this.category = category;
            this.name = name;
            this.option = option;
            this.price = price;
            this.count = count;
            this.unit = unit;
        }
        public FullItemDTO()
        {
        }

        public string Category { get => category; set => category = value; }
        public string Name { get => name; set => name = value; }
        public string Option { get => option; set => option = value; }
        public float Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }
        public string Unit { get => unit; set => unit = value; }
        public int Id { get => id; set => id = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
    }
}
