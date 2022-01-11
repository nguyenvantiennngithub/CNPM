using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class AccountDTO
    {
        private string username;
        private string email;

        public AccountDTO()
        {
        }

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
    }
}
