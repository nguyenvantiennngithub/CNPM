using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class EmployeeDAO
    {
        private static EmployeeDAO instance = null;
        internal static EmployeeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeDAO();
                return instance;
            }
        }
        public Employee GetEmployeeByID(int id)
        {
            using (KMSEntities kms = new KMSEntities())
            {
                Employee e = kms.Employees.Where(p => p.id == 1).First();
                return e;
            }

        }
    }
}
