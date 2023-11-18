using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CuoiKy
{
    static class ACCOUNT
    {
        private static string username;
        private static string password;
        private static string role;

        public static string Username { get => username; set => username = value; }
        public static string Password { get => password; set => password = value; }
        public static string Role { get => role.ToUpper(); set => role = value.ToUpper(); }
    }
}
