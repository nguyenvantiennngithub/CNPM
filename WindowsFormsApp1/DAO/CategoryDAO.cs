using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class CategoryDAO
    {
        private static CategoryDAO instance = null;
        internal static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryDAO();
                return instance;
            }
        }

        public List<ItemType> getListCategory()
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return kms.ItemTypes.Select(type => type).ToList();
            }
        }

        public void addCategory(string name)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                ItemType itemType = new ItemType()
                {
                    nameType = name,
                };
                kms.ItemTypes.Add(itemType);
                kms.SaveChanges();
            }
        }

        public void editCategory(int id, string name)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                ItemType itemType = kms.ItemTypes.Where(type => type.idType == id).FirstOrDefault();

                itemType.nameType = name;

                kms.SaveChanges();
            }
        }
    }
}
