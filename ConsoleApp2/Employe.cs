using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Employee : Human, IComparable<Employee>
    {
        public int Wage{ get; private set; }
        
        public int WorkingHours { get; set; }

        public Employee(string fname, string lname) : base(fname, lname)
        {
        }

        public Employee(string fname, string lname,int wage, int workingHours) : base(fname, lname)
        {
            this.Wage = wage;
            this.WorkingHours = workingHours;
        }

        public double CalculateHourlyWage ()
        {
            double HourlyWage = (double)(this.Wage / this.WorkingHours);
            return HourlyWage;
        }

        public int CompareTo(Employee other)
        {
            return other.Wage.CompareTo(this.Wage);
        }
    }
}
