using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Facil.Services
{
    public class AuthService
    {
        private const string usuario = "Admin";

        private const string password = "123456";

        public bool Login(string user, string pass)
        {
            return user == usuario && pass == password;
        }
    }
}
