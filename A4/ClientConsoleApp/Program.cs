using ClientConsoleApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool startAgain = false;

            int menuChosen = 0;
            using (Service1Client client = new Service1Client())

                do
            {
                try
                {
                    while (menuChosen != 5)
                    {
                        string menuPrint = Menu();
                        Console.WriteLine(menuPrint);
                        menuChosen = int.Parse(Console.ReadLine());

                        switch (menuChosen)
                        {
                            case 1:
                                string list = client.ListEmployee();
                                Console.Write(list);
                                break;
                            case 2:

                                Console.Write("Enter Employee ID: ");
                                int id = int.Parse(Console.ReadLine());
                                Console.Write("Enter Employee name: ");
                                string name = Console.ReadLine();
                                Console.Write("Enter Employee address: ");
                                string address = Console.ReadLine();
                                Console.Write("Enter Employee email: ");
                                string eMail = Console.ReadLine();
                                Console.Write("Enter Employee phone number: ");
                                string phone = Console.ReadLine();
                                Console.Write("Enter Employee role: ");
                                string role = Console.ReadLine();

                                string output = client.AddEmployee(id, name, address, eMail, phone, role);
                                Console.Write(output);

                                break;
                            case 3:
                                Console.Write("Enter ID of the employee to update: ");
                                int oldId = int.Parse(Console.ReadLine());
                                Console.Write("Enter Updated Employee ID: ");
                                int newId = int.Parse(Console.ReadLine());
                                Console.Write("Enter Updated Employee name: ");
                                name = Console.ReadLine();
                                Console.Write("Enter Updated Employee address: ");
                                address = Console.ReadLine();
                                Console.Write("Enter Updated Employee email: ");
                                eMail = Console.ReadLine();
                                Console.Write("Enter Updated Employee phone number: ");
                                phone = Console.ReadLine();
                                Console.Write("Enter Updated Employee role: ");
                                role = Console.ReadLine();

                                output = client.UpdateEmployee(oldId, newId, name, address, eMail, phone, role);
                                Console.Write(output);
                                break;
                            case 4:
                                Console.Write("Enter ID of the employee to delete: ");
                                id = int.Parse(Console.ReadLine());
                                output = client.DeleteEmployee(id);
                                Console.Write(output);
                                break;
                            case 5:
                                break;

                            default:
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);

                    //repeat program with an exception thrown
                    startAgain = true;
                }
            } while (startAgain);


        }
        public static string Menu()
        {
            return "Press 1 to list employees\n" +
                            "Press 2 to add new employees\n" +
                            "Press 3 to update an employee\n" +
                            "Press 4 to delete an employee\n" +
                            "Press 5 to return to Exit";
        }

    }
}
