using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ProductCatogeries
    {
         public string Username { get; set; }
        public string Password { get; set; }

        public Product(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
