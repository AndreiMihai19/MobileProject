using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileProject
{
    class Credentials
    {
        private string username;
        private string password;

        public Credentials (string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string GetUsername()
        {
            return username;
        }

        public string GetPassword() 
        { 
            return password;
        }
    }
}
