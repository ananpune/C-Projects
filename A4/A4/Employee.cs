using System;
using System.Net;

namespace A4
{
    internal class Employee
    {
        private int id;
        private string name;
        private string Email;
        private string Address1;
        private string Phone1;
        private string Role1;

        public int Id
        {
            get { return id; }
            set { id = value; }

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public String EMail
        {
            get { return Email; }
            set
            {
                Email = value;
            }
        }
        public string Address
        {
            get { return Address1; }
            set { Address1 = value; }
        }
        public string Phone
        {
            get { return Phone1; }
            set { Phone1 = value; } 
        }
        public string Role
        {
            get { return Role1; }
            set { Role1 = value; }
        }

        public Employee(int id, string name, string address, string email, string phone, string role)
        {
            Id = id;
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
            Role = role;

        }

      

    }

}
