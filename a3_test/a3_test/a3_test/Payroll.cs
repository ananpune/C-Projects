using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3_test
{
    internal class Payroll
    {
        private int Id;
        private int EmployeeId;
        private int HoursWorked;
        private double HourlyRate;
        private String Date;

        public int Payroll_Id
        {
            get { return Id; }
            set { if (value > 0) Id = value; }

        }
        public int Employee_Id
        {
            get { return EmployeeId; }
            set { if (value > 0) EmployeeId = value; }
        }

        public int Hours_Worked
        {
            get { return HoursWorked; }
            set { if (value >= 0) HoursWorked = value; }
        }
        public double Hourly_Rate
        {
            get { return HourlyRate; }
            set
            {
                if (value >= 0)
                    HourlyRate = value;
            }
        }
        public String Date_Time
        {
            get { return Date; }
            set { Date = value; }
        }
        public Payroll(int id, int employeeId, int hoursWorked, double hourlyRate, String date)
        {
            Payroll_Id = id;
            Employee_Id = employeeId;
            Hours_Worked = hoursWorked;
            Hourly_Rate = hourlyRate;
            Date_Time = date;



        }
        public override string ToString()
        {
            return "\n" + this.Payroll_Id + "\t" + this.Employee_Id + "\t" + this.Hours_Worked + "\t" + this.Hourly_Rate + "\t" + this.Date_Time;
        }
    }
}

