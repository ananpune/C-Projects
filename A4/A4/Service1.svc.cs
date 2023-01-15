using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace A4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
               // List Collections created to store values 
        private List<Employee> employees = new List<Employee>();

        public Service1()
        {
            // Pre-loaded Entries 

            // HERE>>>>>>> Add info of 5 employees to the list 
            Employee emp1 = new Employee(0, "puneet", "212 quinlan ct", "iampuneetanand@gmail.com", "6473907020", "Boss");
            Employee emp2 = new Employee(1, "bob", "123 bob st", "iambob@gmail.com", "1234561234", "Manager");
            Employee emp3 = new Employee(2, "leslie", "123 leslie st", "iamleslie@gmail.com", "9051231236", "Assistant Manager");
            Employee emp4 = new Employee(3, "jack", "321 jack st", "iamjack@gmail.com", "6471236789", "Front Desk");
            Employee emp5 = new Employee(4, "rock", "456 rock st", "iamrock@gmail.com", "6479083456", "General");
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);
            employees.Add(emp5);



            
			
			
			
        }
      
		// list all
        public string ListEmployee()
        {
            var empList = from employee in employees
                          orderby employee.Id
                          select employee;
            string list = "";
            foreach (var e in empList.Distinct())
            {
                list += "Id: " + e.Id + "\tName: " + e.Name + "\tAddress: " + e.Address + "\tEMail: " + e.EMail + "\tPhone: " + e.Phone + "\tRole: " + e.Role + "\n";
            }
            return list;
        }

        // new employee
        public string AddEmployee(int id, string name, string address, string eMail, string phone, string role)
        {
            string resultString = "";

            var empList = from emp in employees
                          orderby emp.Id
                          select emp;

            bool userExists = false;
            foreach (var emp in empList)
            {
                if (id == emp.Id)
                {
                    userExists = true;
                    break;
                }
            }

            if (userExists)
            {
                resultString = "Entered Id already exists for another employee. Cannot add employee.\n";
            }
            else
            {
                Employee e = new Employee(id, name, address, eMail, phone, role);
                employees.Add(e);
                resultString = "Employee: " + name + " added!\n";
            }

            return resultString;
        }

		// update an employee
        public string UpdateEmployee(int oldId, int newId, string name, string address, string eMail, string phone, string role)
        {
            string resultString = "";
            bool userExists = false;

            bool keepGoing = true;

            var empList = from emp in employees
                          orderby emp.Id
                          select emp;

            foreach (var em in empList.Where(e => oldId == e.Id))
            {
                foreach (var emp in empList)
                {
                    if (emp.Id == newId)
                    {
                        userExists = true;
                        break;
                    }
                }
                em.Id = newId;
                em.Name = name;
                em.Address = address;
                em.EMail = eMail;
                em.Phone = phone;
                em.Role = role;

                resultString = userExists ? "Entered Id already exists for another employee\n" : $"Employee: {em.Name} updated!\n";

                keepGoing = false;
            }
            if (keepGoing)
            {
                resultString = "The entered employee ID does not exist!\n";
            }
            return resultString;
        }

		// delete an employee
        public string DeleteEmployee(int id)
        {
            string resultString = "";
            bool ifDeleted = false;

            var empList = from emp in employees
                          orderby emp.Id
                          select emp;

            var updateEmp = from uemp in employees
                            where uemp.Id == id
                            select uemp;

            if (updateEmp.Any())
            {
                foreach (var emp in empList.Where(e => e.Id == id))
                {
                    employees.Remove(emp);
                    ifDeleted = true;
                }
            }
            resultString = ifDeleted ? $"Employee  id {id} deleted!\n" : "The entered employee ID does not exist!\n";
            return resultString;
        }

    }
}
