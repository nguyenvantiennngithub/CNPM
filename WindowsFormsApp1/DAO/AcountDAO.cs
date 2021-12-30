using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class AcountDAO
    {
        private static AcountDAO instance = null;
        internal static AcountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AcountDAO();
                return instance;
            }
        }

        public List<string> GetAllAcountUserNameList()
        {
            using( KMSEntities kms = new KMSEntities())
            {
                return kms.Acounts.Select(p => p.username).ToList();
            }
        }
    }
}
