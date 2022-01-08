using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ItemDAO
    {
        private static ItemDAO instance = null;
        internal static ItemDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ItemDAO();
                return instance;
            }
        }

        public List<string> GetListItemName()
        {
            using( KMSEntities kms = new KMSEntities())
            {
                return kms.Items.Select(p => p.name).ToList();
            }
        }

        public int GetItemIDByName(string name)
        {
            using( KMSEntities kms = new KMSEntities())
            {
                return kms.Items.Where(p => p.name.Equals(name)).Select(p => p.id).First();

            }
        }
    }
}
