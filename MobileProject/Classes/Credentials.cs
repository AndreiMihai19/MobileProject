using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MobileProject
{
    class Credentials
    {
        public static string username;
        private string password;
        private static string user_type;

        public Credentials (string password)
        {
            this.password = password;
        }

        public static void SetUsername(string u)
        {
            username = u;
        }

        public string GetPassword() 
        { 
            return password;
        }

        public static string GetUserType() 
        { 
            return user_type; 
        }

        public static void SetUserType(string u)
        {
            user_type = u;
        }
    }
}
