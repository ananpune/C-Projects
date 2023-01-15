using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1
{
    internal class Program
    {

        class Employee
        {

            public int Id { get; set; }
            public string Name { get; set; }
            public String Address { get; set; }
            public String Email { get; set; }
            public long Phone { get; set; }
            public String Role { get; set; }
            public Employee(int id, String name, String address, String email, long phone, String role)
            {
                Id = id;
                Name = name;
                Address = address;
                Email = email;
                Phone = phone;
                Role = role;


            }
        }
        class Payroll
        {
            public int Id { get; set; }
            public int EmployeeId { get; set; }
            public int HoursWorked { get; set; }
            public double HourlyRate { get; set; }
            public DateTime Date { get; set; }

            public Payroll(int id, int employeeId, int hoursWorked, double hourlyRate, DateTime date)
            {
                Id = id;
                EmployeeId = employeeId;
                HoursWorked = hoursWorked;
                HourlyRate = hourlyRate;
                Date = date;
            }
        }
        class Vacation
        {
            public int Id { get; set; }
            public int EmployeeId { get; set; }
            public int NumberofDays { get; set; }

            public Vacation(int id, int employeeId, int numberofDays)
            {
                Id = id;
                EmployeeId = employeeId;
                NumberofDays = numberofDays;
            }
        }

        static void Main(string[] args)
        {
            //create employees
            Employee Emp1 = new Employee(1, "Puneet", "212 Quinlan Court", "ananpune@sheridancollege.ca", 6471231234, "Boss");
            Employee Emp2 = new Employee(2, "Joe","123 Sesame St", "JoeJoe@sheridancollege.ca", 6473213214, "Developer");
            Employee Emp3 = new Employee(3, "Rachel","123 Mississauga Rd", "rachel@sheridancollege.ca", 6471456231, "Jr Dev");
            Employee Emp4 = new Employee(4, "Rad", "321 Rad St", "rad@sheridancollege.ca", 6471231233, "Jr Dev");
            Employee Emp5 = new Employee(5, "Christine","312 Boom St", "christine@sheridancollege.ca", 6471230000, "Secretary");

            //initializing an Employee Array
            List<Employee> EmpArray = new List<Employee>();

            //adding our employees into the array
            EmpArray.Add(Emp1);
            EmpArray.Add(Emp2);
            EmpArray.Add(Emp3);
            EmpArray.Add(Emp4);
            EmpArray.Add(Emp5);

            //create our Payrolls
            Payroll Payroll1 = new Payroll(1, 1, 40, 27.00, DateTime.Today);
            Payroll Payroll2 = new Payroll(2, 2, 30, 20.00, DateTime.Today);
            Payroll Payroll3 = new Payroll(3, 3, 30, 15.00, DateTime.Today);
            Payroll Payroll4 = new Payroll(4, 4, 40, 15.00, DateTime.Today);
            Payroll Payroll5 = new Payroll(5, 5, 40, 10.00, DateTime.Today);

            //initializing Payroll Array
            List<Payroll> PayArray = new List<Payroll>();

            //adding to our arrays
            PayArray.Add(Payroll1);
            PayArray.Add(Payroll2);
            PayArray.Add(Payroll3);
            PayArray.Add(Payroll4);
            PayArray.Add(Payroll5);

            //create Vacation objects
            Vacation Vacation1 = new Vacation(1, 1, 14);
            Vacation Vacation2 = new Vacation(2, 2, 14);
            Vacation Vacation3 = new Vacation(3, 3, 14);
            Vacation Vacation4 = new Vacation(4, 4, 14);
            Vacation Vacation5 = new Vacation(5, 5, 14);

            //initializing Vacation Array
            List<Vacation> VacationArray = new List<Vacation>();

            //adding Vacation objects to the array
            VacationArray.Add(Vacation1);
            VacationArray.Add(Vacation2);
            VacationArray.Add(Vacation3);
            VacationArray.Add(Vacation4);
            VacationArray.Add(Vacation5);

            String choice;
            
            while (true)
            {
                Console.WriteLine("Welcome, please choose a command:");
                Console.WriteLine("1 to access Employee menu");
                Console.WriteLine("2 to access Payroll menu");
                Console.WriteLine("3 to view Vacation days");
                Console.WriteLine("4 to exit");

                choice = (Console.ReadLine());

                if (choice == "4")
                {
                    Environment.Exit(0);

                }

                if (choice == "1")
                {

                    Console.WriteLine("Press 1 to list all Employees");
                    Console.WriteLine("Press 2 to add a new Employee");
                    Console.WriteLine("Press 3 to update Employee");
                    Console.WriteLine("Press 4 to delete an Emplyee");
                    Console.WriteLine("Press 5 to return to main menu");
                    choice = (Console.ReadLine());
                    if (choice == "5")
                    {
                  
                    }
                    if (choice == "1")
                    {
                        int EmpSize = EmpArray.Count();
                        
                        for (int i = 0; i < EmpSize; i++)
                        {

                            Console.WriteLine(EmpArray[i].Id + "\t" + EmpArray[i].Name + "\t" + EmpArray[i].Address + "\t" + EmpArray[i].Email + "\t" + EmpArray[i].Phone + "\t" + EmpArray[i].Role);

                        }
                        
                    }
                    if (choice == "2")
                    {
                        int NewId;
                        String NewName;
                        String NewAddress;
                        String NewEmail;
                        int NewPhone;
                        String NewRole;
                        Console.WriteLine("Please Enter the Employee id");
                        NewId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please Enter the Employee Name");
                        NewName = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Please Enter the Employee Address");
                        NewAddress = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Please Enter the Employee Email");
                        NewEmail = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Please Enter the Employee Phone");
                        NewPhone = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please Enter the Employee Role");
                        NewRole = Convert.ToString(Console.ReadLine());
                        if (NewId > 0)
                        {
                            EmpArray.Add(new Employee(NewId, NewName, NewAddress, NewEmail, NewPhone, NewRole));
                        }


                    }
                    if (choice == "4")
                    {
                        
                        int EmpSizer = EmpArray.Count();
                        Console.WriteLine("Please Enter index of the Employee you would like to delete");
                        int empId = Convert.ToInt32(Console.ReadLine());
                        if (empId <= EmpSizer)
                        {
                            EmpArray.RemoveAt(empId);
                        }
                      
                        

                    }
                    if (choice == "3")
                    {
                        int EmpSizer = EmpArray.Count();
                        Console.WriteLine("Please Enter the index of the Employee you would like to remove");
                        int empindex = Convert.ToInt32(Console.ReadLine());
                        if (empindex <= EmpSizer)
                        {
                            EmpArray.RemoveAt(empindex);
                            int NewId;
                            String NewName;
                            String NewAddress;
                            String NewEmail;
                            int NewPhone;
                            String NewRole;
                            Console.WriteLine("Please Enter the Employee id");
                            NewId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please Enter the Employee Name");
                            NewName = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Please Enter the Employee Address");
                            NewAddress = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Please Enter the Employee Email");
                            NewEmail = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Please Enter the Employee Phone");
                            NewPhone = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please Enter the Employee Role");
                            NewRole = Convert.ToString(Console.ReadLine());
                            if (NewId > 0)
                            {
                                EmpArray.Add(new Employee(NewId, NewName, NewAddress, NewEmail, NewPhone, NewRole));
                            }
                        }
                    }
                   
                }

                if (choice == "2")
                {
                    Console.WriteLine("Press 1 for new payroll entry");
                    Console.WriteLine("Press 2 to view payroll history for employee");
                    Console.WriteLine("Press 3 for main menu");
                    choice = (Console.ReadLine());

                    if (choice == "3")
                    {

                    }
                    if (choice == "1")
                    {
                     
                        Console.WriteLine("Please Enter Payroll ID");
                        int payId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please Enter Employee ID");
                        int empId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please Enter hours worked");
                        int hrsWorked = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the hourly rate");
                        double ratePay = Convert.ToDouble(Console.ReadLine());

                        DateTime date = DateTime.Today;
                        if (payId > 0 && empId > 0 && hrsWorked > 0 && ratePay > 0)
                        {
                            PayArray.Add(new Payroll(payId, empId, hrsWorked, ratePay, date));
                        }
                        for (int i = 0; i < VacationArray.Count; i++)
                        {
                            if (VacationArray[i].EmployeeId == empId)
                            {
                                VacationArray[i].NumberofDays++;

                            }
                        }
                        

                    }
                    if (choice == "2")
                    {
                        Console.WriteLine("Please Enter the Employee ID");
                        int employeeID = Convert.ToInt32(Console.ReadLine());
                        int PaySize = PayArray.Count();
                        for (int i = 0; i < PaySize; i++)
                        {
                            if (employeeID == PayArray[i].EmployeeId)
                            {
                                Console.WriteLine(PayArray[i].Id + "\t" + PayArray[i].EmployeeId + "\t" + PayArray[i].HoursWorked + "\t" + PayArray[i].HourlyRate + "\t" + PayArray[i].Date);
                            }
                        }
                    }

                }
                if (choice == "3")
                {
                    Console.WriteLine("Press 1 to see Vacation Days");
                    Console.WriteLine("Press 2 for main menu");
                    choice =(Console.ReadLine());

                    if (choice == "2")
                    {

                    }
                    if (choice == "2")
                    {
                        Console.WriteLine("Please Enter Employee Id");
                        int empId = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < VacationArray.Count; i++)
                        {
                            if (VacationArray[i].EmployeeId == empId)
                            {
                                Console.WriteLine(VacationArray[i].Id + "\t" + VacationArray[i].EmployeeId + "\t" + VacationArray[i].NumberofDays);
                            }
                        }

                    }
                }






            }
        }
    }
}
