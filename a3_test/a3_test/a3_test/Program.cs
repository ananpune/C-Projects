using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace a3_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create Employee objects
            Employee Emp1 = new Employee(1, "Puneet", "212 Quinlan Court", "ananpune@sheridancollege.ca", 6471231234, "Boss");
            Employee Emp2 = new Employee(2, "Joe", "123 Sesame St", "JoeJoe@sheridancollege.ca", 6473213214, "Developer");
            Employee Emp3 = new Employee(3, "Rachel", "123 Mississauga Rd", "rachel@sheridancollege.ca", 6471456231, "Jr Dev");
            Employee Emp4 = new Employee(4, "Rad", "321 Rad St", "rad@sheridancollege.ca", 6471231233, "Jr Dev");
            Employee Emp5 = new Employee(5, "Christine", "312 Boom St", "christine@sheridancollege.ca", 6471230000, "Secretary");

            //create Payroll objects
            Payroll Payroll1 = new Payroll(1, 1, 40, 27.00, "Jan 6, 2022");
            Payroll Payroll2 = new Payroll(2, 2, 30, 20.00, "Feb 2, 2022");
            Payroll Payroll3 = new Payroll(3, 3, 30, 15.00, "March 3, 2022");
            Payroll Payroll4 = new Payroll(4, 4, 40, 15.00, "May 17, 2022");
            Payroll Payroll5 = new Payroll(5, 5, 40, 10.00, "August 1, 2022");

            //create Vacation objects
            Vacation Vacation1 = new Vacation(1, 1, 14);
            Vacation Vacation2 = new Vacation(2, 2, 14);
            Vacation Vacation3 = new Vacation(3, 3, 14);
            Vacation Vacation4 = new Vacation(4, 4, 14);
            Vacation Vacation5 = new Vacation(5, 5, 14);

            //using ArrayLists -> add the created objects above to their respective ArrayList
            ArrayList EmployeesAL = new ArrayList();
            ArrayList Payrolls = new ArrayList();
            ArrayList Vacations = new ArrayList();

            EmployeesAL.Add(Emp1);
            EmployeesAL.Add(Emp2);
            EmployeesAL.Add(Emp3);
            EmployeesAL.Add(Emp4);
            EmployeesAL.Add(Emp5);



            Payrolls.Add(Payroll1);
            Payrolls.Add(Payroll2);
            Payrolls.Add(Payroll3);
            Payrolls.Add(Payroll4);
            Payrolls.Add(Payroll5);

            Vacations.Add(Vacation1);
            Vacations.Add(Vacation2);
            Vacations.Add(Vacation3);
            Vacations.Add(Vacation4);
            Vacations.Add(Vacation5);
            String User_Choice;
            var emps = from Employee emp in EmployeesAL
                       select emp;
            var pays = from Payroll p in Payrolls
                       select p;
            var vacs = from Vacation v in Vacations
                       select v;
            while (true)
            {
                //(MENU 1)
                Console.WriteLine("Welcome, please choose an Option:");
                Console.WriteLine("1 to access Employee menu");
                Console.WriteLine("2 to access Payroll menu");
                Console.WriteLine("3 to view Vacation days");
                Console.WriteLine("4 to exit");

                User_Choice = Console.ReadLine();
                //exit case
                if (User_Choice == "4")
                {
                    Environment.Exit(0);
                }
                else if (User_Choice == "1")
                {
                    Console.WriteLine("Press 1 to list all Employees");
                    Console.WriteLine("Press 2 to add a new Employee");
                    Console.WriteLine("Press 3 to update Employee");
                    Console.WriteLine("Press 4 to delete an Employee");
                    Console.WriteLine("Press 5 to return to main menu");
                    User_Choice = Console.ReadLine();

                    if (User_Choice == "1")
                    {
                        //LINQ

                        foreach (Employee e in emps)
                            Console.WriteLine(e.ToString());
                    }
                    if (User_Choice == "2")
                    {
                        String NewId;
                        String NewName;
                        String NewAddress;
                        String NewEmail;
                        String NewPhone;
                        String NewRole;
                        int new_id;
                        long new_phone;
                        int val;
                        long val2;

                        Console.WriteLine("Please Enter the Employee id");
                        NewId = (Console.ReadLine());
                        Console.WriteLine("Please Enter the Employee Name");
                        NewName = (Console.ReadLine());
                        Console.WriteLine("Please Enter the Employee Address");
                        NewAddress = (Console.ReadLine());
                        Console.WriteLine("Please Enter the Employee Email");
                        NewEmail = (Console.ReadLine());
                        Console.WriteLine("Please Enter the Employee Phone");
                        NewPhone = (Console.ReadLine());
                        Console.WriteLine("Please Enter the Employee Role");
                        NewRole = (Console.ReadLine());

                        //basic type checking and conversion from types to appropriate values to be used later
                        if (!int.TryParse(NewId, out val))
                        {
                            //exit case
                            new_id = 1;
                        }
                        else
                        {
                            //conversion
                            new_id = Convert.ToInt32(NewId);
                        }
                        if (!long.TryParse(NewPhone, out val2))
                        {
                            //exit case
                            Console.WriteLine("Enter Valid Number");
                            new_phone = 1;
                        }
                        else
                        {
                            //conversion
                            new_phone = Convert.ToInt64(NewPhone);

                        }
                        //LINQ

                        int yesNo = 0;
                        foreach (Employee emp in emps)
                            if (emp.Employee_Id == new_id)
                            {
                                Console.WriteLine("Need valid/Unique ID");
                                yesNo = 1;
                                break;

                            }
                        if (yesNo == 0)
                        {
                            Employee NewEmp = new Employee(new_id, NewName, NewAddress, NewEmail, new_phone, NewRole);
                            EmployeesAL.Add(NewEmp);
                        }
                        User_Choice = "5";

                    }
                    if (User_Choice == "3")
                    {
                        Console.WriteLine("Enter the ID of the Employee you wish to edit");
                        String editID = Console.ReadLine();
                        int editChoice;
                        if (!int.TryParse(editID, out editChoice))
                        {
                            Console.WriteLine("Valid ID please");

                        }
                        else
                        {
                            editChoice = Convert.ToInt32(editChoice);
                        }
                        //LINQ
                        emps = from Employee emp in EmployeesAL
                               where emp.Employee_Id != editChoice
                               select emp;
                        //holds employee to edit
                        Employee tester;

                        //removing the selected employee to edit
                        for (int i = 0; i < EmployeesAL.Count; i++)
                        {
                            tester = (Employee)EmployeesAL[i];
                            if (tester.Employee_Id == editChoice)
                            {
                                EmployeesAL.Remove(tester);
                            }
                        }
                        String NewId;
                        String NewName;
                        String NewAddress;
                        String NewEmail;
                        String NewPhone;
                        String NewRole;
                        int new_id;
                        long new_phone;
                        int val;
                        long val2;

                        Console.WriteLine("Please Enter the Employee id");
                        NewId = (Console.ReadLine());
                        Console.WriteLine("Please Enter the Employee Name");
                        NewName = (Console.ReadLine());
                        Console.WriteLine("Please Enter the Employee Address");
                        NewAddress = (Console.ReadLine());
                        Console.WriteLine("Please Enter the Employee Email");
                        NewEmail = (Console.ReadLine());
                        Console.WriteLine("Please Enter the Employee Phone");
                        NewPhone = (Console.ReadLine());
                        Console.WriteLine("Please Enter the Employee Role");
                        NewRole = (Console.ReadLine());

                        //basic type checking and conversion from types to appropriate values to be used later
                        if (!int.TryParse(NewId, out val))
                        {
                            //exit case
                            new_id = 1;
                        }
                        else
                        {
                            //conversion
                            new_id = Convert.ToInt32(NewId);
                        }
                        if (!long.TryParse(NewPhone, out val2))
                        {
                            //exit case
                            Console.WriteLine("Enter Valid Number");
                            new_phone = 1;
                        }
                        else
                        {
                            //conversion
                            new_phone = Convert.ToInt64(NewPhone);

                        }
                        //LINQ

                        int yesNo = 0;
                        foreach (Employee emp in emps)
                            if (emp.Employee_Id == new_id)
                            {
                                Console.WriteLine("Need valid/Unique ID");
                                yesNo = 1;
                                break;

                            }
                        if (yesNo == 0)
                        {
                            Employee NewEmp = new Employee(new_id, NewName, NewAddress, NewEmail, new_phone, NewRole);
                            EmployeesAL.Add(NewEmp);
                        }
                        User_Choice = "5";

                    }
                    if (User_Choice == "4")
                    {

                        Console.WriteLine("Enter the ID of the Employee you wish to delete");
                        String editID = Console.ReadLine();
                        int editChoice;
                        if (!int.TryParse(editID, out editChoice))
                        {
                            Console.WriteLine("Valid ID please");

                        }
                        else
                        {
                            editChoice = Convert.ToInt32(editChoice);
                        }
                        //LINQ
                        emps = from Employee emp in EmployeesAL
                               where emp.Employee_Id != editChoice
                               select emp;
                        //holds employee to edit
                        Employee tester;

                        //removing the selected employee to edit
                        for (int i = 0; i < EmployeesAL.Count; i++)
                        {
                            tester = (Employee)EmployeesAL[i];
                            if (tester.Employee_Id == editChoice)
                            {
                                EmployeesAL.Remove(tester);
                            }
                        }
                        User_Choice = "5";


                    }
                    if (User_Choice == "5")
                    {
                        continue;
                    }
                }
                if (User_Choice == "2")
                {
                    Console.WriteLine("Press 1 for new payroll entry");
                    Console.WriteLine("Press 2 to view payroll history for employee");
                    Console.WriteLine("Press 3 for main menu");
                    User_Choice = Console.ReadLine();
                    int val;
                    double val2;
                    //adding Payroll
                    if (User_Choice == "1")
                    {
                        Console.WriteLine("Please Enter Payroll ID");
                        String pay_Id = Console.ReadLine();
                        Console.WriteLine("Please Enter Employee ID");
                        String E_Id = Console.ReadLine();
                        Console.WriteLine("Please Enter Hours Worked");
                        String Hours_Worked = Console.ReadLine();
                        Console.WriteLine("Enter hourly rate");
                        String Hourly_Rate = Console.ReadLine();
                        Console.WriteLine("Enter Date");
                        String Date = Console.ReadLine();
                        if (!int.TryParse(pay_Id, out val))
                        {
                            Console.WriteLine("Enter Valid number");

                        }
                        else if (!int.TryParse(E_Id, out val))
                        {
                            Console.WriteLine("Enter Valid number");

                        }
                        else if (!int.TryParse(Hours_Worked, out val))
                        {
                            Console.WriteLine("Enter Valid number");

                        }
                        else if (!double.TryParse(Hourly_Rate, out val2))
                        {
                            Console.WriteLine("Enter Valid rate");

                        }
                        else
                        {
                            int p_Id = Convert.ToInt32(pay_Id);
                            int emp_Id = Convert.ToInt32(E_Id);
                            int hrsWorked = Convert.ToInt32(Hours_Worked);
                            double rate = Convert.ToDouble(Hourly_Rate);
                            int yesNo = 0;

                            foreach (Payroll p in pays)
                                if (p.Payroll_Id == p_Id)
                                {
                                    Console.WriteLine("Need valid/Unique ID");
                                    yesNo = 1;
                                    break;

                                }
                            if(yesNo == 0)
                            {
                                Payroll payer = new Payroll(p_Id, emp_Id, hrsWorked, rate, Date);
                                Payrolls.Add(payer);
                            }
                            User_Choice = "5";

                        }

                    }
                    if (User_Choice == "2")
                    {
                        Console.WriteLine("Enter the employee ID you wish to see payroll information for");
                        int value1;
                        int val3;
                        String value2 = Console.ReadLine();
                        if (!int.TryParse(value2, out value1))
                        {
                            Console.WriteLine("Enter Valid number");
                        }
                        else
                        {
                            val3 = Convert.ToInt32(value2);

                            var payrolls = from Payroll p in Payrolls
                                           where p.Employee_Id == val3
                                           select p;
                            foreach (Payroll payroll in payrolls)
                                Console.WriteLine(payroll.ToString());
                        }
                        User_Choice = "5";

                    }
                    if (User_Choice == "3")
                    {
                        continue;
                    }
                }

                if (User_Choice == "3")
                {
                    Console.WriteLine("Press 1 to see Vacation Days");
                    Console.WriteLine("Press 2 for main menu");
                    User_Choice = (Console.ReadLine());
                    if (User_Choice == "1")
                    {
                        Console.WriteLine("Please enter the Employee ID of the Employee for Vacation Days");
                        String vac_ID = Console.ReadLine();
                        int val1;

                        if (!int.TryParse(vac_ID, out val1))
                        {
                            Console.WriteLine("Enter a valid number");
                        }
                        val1 = Convert.ToInt32(vac_ID);
                        var vacs1 = from Vacation vac in vacs
                                    where vac.Employee_Id == val1
                                    select vac;
                        foreach(var vac in vacs1)
                            Console.WriteLine(vac.ToString());
                        User_Choice = "5";

                    }
                    if(User_Choice == "2")
                    {
                        continue;
                    }
                }
            }

        
        }
    }
}
