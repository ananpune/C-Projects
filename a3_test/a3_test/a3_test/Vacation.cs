using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3_test
{
    internal class Vacation
    {
        private int Id;
        private int EmployeeId;
        private int NumberOfDays;

        public int Vacation_Id
        {
            get { return Id; }
            set { if (value > 0) Id = value; }
        }
        public int Employee_Id
        {
            get { return EmployeeId; }
            set { if (value > 0) EmployeeId = value; }
        }
        public int Num_Days
        {
            get { return NumberOfDays; }
            set { if (value >= 0) NumberOfDays = value; }
        }
        public Vacation(int id, int employeeId, int numberOfDays)
        {
            Vacation_Id = id;
            Employee_Id = employeeId;
            NumberOfDays = numberOfDays;

        }

        public override string ToString()
        {
            return "\n Vacation ID: "+this.Vacation_Id + "\t Employee ID: " + this.Employee_Id+ "\t Vacation Days: "+this.NumberOfDays;
        }
    }
}
