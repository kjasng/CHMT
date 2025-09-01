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

        public int CustomerID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public string Address { get; set; }

        public string District { get; set; }

        public string Phone { get; set; }

        public string IdentifiCard { get; set; }

        public string Note { get; set; }

        public Customer(int CustomerID,string Firstname, string Lastname, int Gender, DateTime DateOfBirth, string Address, string District, string Phone, string IdentifiCard, string Note) {
            this.CustomerID = CustomerID;
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

        public String getFirstname()
        {
            return this.Firstname;
        }

        public void setFirstname(string Firstname)
        {
            this.Firstname = Firstname;
        }

        public String getLastname()
        {
            return this.Lastname;
        }

        public void setLastname(string Lastname)
        {
            this.Lastname = Lastname;
        }

        public int getGender()
        {
            return this.Gender;
        }

        public void setGender(int Gender) {
            this.Gender = Gender;
        }

        public DateTime getDateOfBirth()
        {
            return (DateTime)this.DateOfBirth;
        }

        public void setDateOfBirth(DateTime DateOfBirth)
        {
            this.DateOfBirth = DateOfBirth;
        }

        public String getAddress()
        {
            return this.Address;
        }

        public void setAddress(string Address)
        {
            this.Address = Address;
        }

        public String getDistrict()
        {
            return this.District;
        }

        public void setDistrict(string District)
        {
            this.District = District;
        }

        public String getPhone()
        {
            return this.Phone;
        }

        public void setPhone(string Phone)
        {
            this.Phone = Phone;
        }

        public String getIdentifiCard()
        {
            return this.IdentifiCard;
        }

        public void setIdentifiCard(string IdentifiCard)
        {
            this.IdentifiCard = IdentifiCard;
        }

        public String getNote()
        {
            return this.Note;
        }

        public void setNote(string Note)
        {
            this.Note = Note;
        }


    }
}
