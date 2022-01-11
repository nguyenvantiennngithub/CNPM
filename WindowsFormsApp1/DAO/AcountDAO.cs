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

        public List<AccountDTO> GetUsernameEmail()
        {
            using (KMSEntities kms = new KMSEntities())
            {
                return kms.Acounts.Select(p => new AccountDTO() {
                    Username = p.username,
                    Email = p.mailAddress,
                }).ToList();
            }
        }

        public void CreateAccount(string username, string password, string email)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                Acount a = new Acount()
                {
                    username = username,
                    password = password,
                    mailAddress = email,
                    status = "Hoạt động",
                    idEmployee = 1,
                    post = 1,
                    img = "",
                };
                kms.Acounts.Add(a);
                kms.SaveChanges();
            }
        }
    }
}
