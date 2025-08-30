using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Users
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int role { get; set; }


        public Users(string username, string password, int role)
        {
            this.Username = username;
            this.Password = password;
            this.role = role;
        }

    }
}
