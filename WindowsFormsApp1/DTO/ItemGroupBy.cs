using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ItemGroupBy
    {
        private int id;
        private string item;
        private string category;
        private List<OptionCategory> option;

        public int Id { get => id; set => id = value; }
        public string Item { get => item; set => item = value; }
        public string Category { get => category; set => category = value; }
        public List<OptionCategory> Option { get => option; set => option = value; }

        public ItemGroupBy(int id, string item, string category, List<OptionCategory> option)
        {
            this.Id = id;
            this.Item = item;
            this.Category = category;
            this.Option = option;
        }
        public ItemGroupBy()
        {
          
        }
    }
}
