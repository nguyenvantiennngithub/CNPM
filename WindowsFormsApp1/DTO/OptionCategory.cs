using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class OptionCategory
    {
        private int id;
        private string item;
        private string category;
        private float price;
        private string option;

        public OptionCategory()
        {
        }

        public OptionCategory(int id, string item, string category, float price, string option)
        {
            this.id = id;
            this.item = item;
            this.category = category;
            this.price = price;
            this.option = option;
        }

        public int Id { get => id; set => id = value; }
        public string Item { get => item; set => item = value; }
        public string Category { get => category; set => category = value; }
        public float Price { get => price; set => price = value; }
        public string Option { get => option; set => option = value; }
    }
}
