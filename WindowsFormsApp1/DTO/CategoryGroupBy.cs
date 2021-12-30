using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CategoryGroupBy
    {
        private string category;
        private List<ItemGroupBy> listItem;
        public CategoryGroupBy()
        {
        }

        public CategoryGroupBy(string category, List<ItemGroupBy> listItem)
        {
            this.Category = category;
            this.ListItem = listItem;
        }

        public string Category { get => category; set => category = value; }
        public List<ItemGroupBy> ListItem { get => listItem; set => listItem = value; }
    }
}
