using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public string Address { get; set; }

        public string District { get; set; }

        public string Phone { get; set; }

        public string IdentifiCard { get; set; }

        public string Note { get; set; }

        public Customer(string Firstname, string Lastname, int Gender, DateTime DateOfBirth, string Address, string District, string Phone, string IdentifiCard, string Note) {
            this.Firstname = Firstname;
            this.Lastname = Lastname;   
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.Address = Address;
            this.District = District;
            this.Phone = Phone;
            this.IdentifiCard = IdentifiCard;
            this.Note = Note;
        }

    }
}
