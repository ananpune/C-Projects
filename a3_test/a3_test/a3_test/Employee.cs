using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3_test
{
    internal class Employee
    {
        private int id;
        private String Name;
        private String Address;
        private String Email;
        private long Phone;
        private String Role;

        public int Employee_Id
        {
            get { return id; }
            set { if (value > 0) id = value; }
        }
        public String Employee_Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public String Employee_Address
        {
            get { return Address; }
            set { Address = value; }
        }
        public String Employee_Email
        {
            get { return Email; }
            set
            {
                Email = value;
            }
        }
        public long Employee_Phone
        {
            get { return Phone; }
            set { if (value > 0) Phone = value; }

        }
        public String Employee_Role
        {
            get { return Role; }
            set
            {
                Role = value;
            }
        }
        public Employee(int id, string name, string address, string email, long phone, string role)
        {
            Employee_Id = id;
            Employee_Name = name;
            Employee_Address = address;
            Employee_Email = email;
            Employee_Phone = phone;
            Employee_Role = role;

        }
        public override String ToString()
        {
            return "\n" + this.Employee_Id + "\t" + this.Employee_Name + "\t" + this.Employee_Address + "\t" + this.Employee_Email + "\t" + this.Employee_Phone + "\t" + this.Employee_Role;


        }
    }
}
